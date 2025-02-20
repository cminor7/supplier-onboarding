using Azure.Storage.Blobs.Models;
using System.Data;
using System.Xml.Linq;
using static ONBOARDING.DBConnection;

namespace ONBOARDING
{
	internal class Query
	{
		//SUPPLIER TASKS QUERIES
		public static DataView TaskTrack(string supNo)
		{
			return SnowflakeView(@$"SELECT SUPPLIER_NO, TASKID, INITIATED, COMPLETED, AUTO_COMPLETED, BACKEND_CHECK, COMMENTS, BYPASSED, TASK_DESCRIPTION 
					FROM (SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO = '{supNo}')
					ORDER BY TASKID ASC");
		}

		public static DataView SupplierInfo(string supplierSearch, bool fuzzy) 
		{
			if (fuzzy)
			{
				return SnowflakeView(@$"SELECT ONBOARDING.*, JAROWINKLER_SIMILARITY(SUPPLIER_NAME, '{supplierSearch}') AS MATCH_PERCENT
						FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER ONBOARDING
						WHERE STATUS IN ('ONBOARDING', 'WITHDRAWN', 'SUSPENDED') AND MATCH_PERCENT >= 75
						ORDER BY MATCH_PERCENT DESC LIMIT 1");
			}
			else
			{
				return SnowflakeView(@$"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER WHERE SUPPLIER_NO = '{supplierSearch}' 
					AND STATUS IN ('ONBOARDING', 'WITHDRAWN', 'SUSPENDED')");
			}
		}

		public static bool DependentTaskComplete(string supNo, string taskID)
		{
			string[] taskList = taskID.Replace(" ", "").Split(",");
			string taskListFilter =  string.Join(",", taskList.Select(taskID => $"'{taskID}'")); // formats list "one, two, three" -> 'one','two','three'
			DataView taskResult = SnowflakeView($"SELECT SUPPLIER_NO, TASKID FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO = '{supNo}' AND TASKID IN ({taskListFilter}) AND COMPLETED IS NULL");
			return taskResult.Count == 0; // return true if all task(s) are completed
		}

		public static void CompleteTasks(string supNo, string taskID)
		{
			string[] taskList = taskID.Replace(" ", "").Split(",");
			string taskListFilter = string.Join(",", taskList.Select(taskID => $"'{taskID}'"));
			SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET COMPLETED = CURRENT_DATE WHERE TASKID IN ({taskListFilter}) AND SUPPLIER_NO = '{supNo}'");
		}

		public static void InitiateTasks(string supNo, string taskID)
		{
			string[] taskList = taskID.Replace(" ", "").Split(",");
			string taskListFilter = string.Join(",", taskList.Select(taskID => $"'{taskID}'"));
			SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET INITIATED = CURRENT_DATE WHERE TASKID IN ({taskListFilter}) AND SUPPLIER_NO = '{supNo}'");
		}

		public static string SupplierContacts(string supNo, string role)
		{
			string[] roleList = role.Replace(" ", "").Split(",");
			string roleListFilter = string.Join(",", roleList.Select(role => $"'{role}'"));

			return $@"SELECT c.EMAIL FROM Itemmanagement.dbo.tblResponsibilities r INNER JOIN Itemmanagement.dbo.tblContact c ON r.ContactID = c.ContactID WHERE Supplier = '{supNo}' AND Role IN ({roleListFilter})";
		}

		public static void ResetAllTasks(string supNo)
		{
			SnowflakeCommand($@"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK 
					SET 
						INITIATED = CASE
							WHEN TASKID IN = '1A' AND SUPPLIER_NO = '{supNo}' THEN CURRENT_DATE
							WHEN TASKID <> '1A' AND SUPPLIER_NO = '{supNo}' THEN NULL
							ELSE INITIATED
							END,
						COMPLETED = CASE
							WHEN TASKID = '1A' AND SUPPLIER_NO = '{supNo}' THEN CURRENT_DATE
							WHEN TASKID <> '1A' AND SUPPLIER_NO = '{supNo}' THEN NULL
							ELSE COMPLETED
							END,
						BYPASSED = FALSE
					 WHERE SUPPLIER_NO = '{supNo}'");
			InitiateSecondTask(supNo);
		}

		public static void DeleteSupplier (string supNo, string supProfile)
		{
			if (supProfile == "GGS")
			{
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_GGS_SUPPLIER_NUMBER SET DATE_USED = NULL WHERE SUPPLIER_NO ='{supNo}'");
			}
			else
			{
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER_NUMBER SET DATE_USED = NULL WHERE SUPPLIER_NO ='{supNo}'");
			}
			Parallel.Invoke(() => SnowflakeCommand($"DELETE FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO ='{supNo}'"),
				() => SnowflakeCommand($"DELETE FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER WHERE SUPPLIER_NO ='{supNo}'")
			);
		}


		//SINGLE REQUEST FORM QUERIES
		public static DataView MinSupplierNo(string supProfile)
		{
			string minSupNo;
			if (supProfile == "GGS")
			{
				minSupNo = @"SELECT MIN(SUPPLIER_NO) AS SUPPLIER_NO 
					FROM (SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_GGS_SUPPLIER_NUMBER WHERE DATE_USED IS NULL) GGS_NUMBERS
					LEFT JOIN (SELECT SUPPLIER_INT FROM PUBLISH.GSCCE.SUPPLIER_EDV WHERE SUPPLIER_CHAR LIKE '00208%') SUPPLIER_EDV
						ON GGS_NUMBERS.SUPPLIER_NO = SUPPLIER_EDV.SUPPLIER_INT
					WHERE SUPPLIER_INT IS NULL";
			}
			else
			{
				minSupNo = @"SELECT MIN(SUPPLIER_NO) AS SUPPLIER_NO
					FROM (SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER_NUMBER WHERE DATE_USED IS NULL) SUPPLIER_NUMBERS 
					LEFT JOIN (SELECT SUPPLIER_INT FROM PUBLISH.GSCCE.SUPPLIER_EDV WHERE SUPPLIER_CHAR LIKE '00200%') SUPPLIER_EDV 
						ON SUPPLIER_NUMBERS.SUPPLIER_NO = SUPPLIER_EDV.SUPPLIER_INT
					WHERE SUPPLIER_INT IS NULL";
			}
			return SnowflakeView(minSupNo);
		}

		public static DataView CountryCode()
		{
			return SnowflakeView("SELECT COUNTRY, UPPER(COUNTRY_DESC) AS COUNTRY_DESC FROM TERADATA.PRD_DWH_VIEW_LMT.COUNTRY_V");
		}

		public static DataView SMSEmployee()
		{
			return SQLView(@"SELECT UPPER(EMPLOYEE) AS EMPLOYEE, UPPER(COMPUTERID) AS COMPUTERID, UPPER(EMAIL) AS EMAIL,
								CASE 
									WHEN [ROLE] IN ('PM','MM') THEN 'PMMGR'
									ELSE 'PMS'
									END AS [ROLE]
								FROM Itemmanagement.dbo.tblemployees WHERE (tblemployees.[role]) IN ('PM','MM', 'PMS')");
		}

		public static void InsertSupplierInfo(string values) 
		{
			SnowflakeCommand(@$"INSERT INTO ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER (SUPPLIER_NO, SUPPLIER_NAME, PROFILE,  CONTACT_NAME, CONTACT_EMAIL,  CONTACT_PHONE, 
				COUNTRY, STATE, CITY, SPA_EMAIL, CONTRACT_TYPE, COMMENTS, 
				SM_NAME, SM_RACFID, SM_EMAIL, SM_ROLE, REQUESTOR_RACFID,  CREATE_DATE, STATUS) 
				VALUES(
			{values}, CURRENT_DATE, 'ONBOARDING')");
		}

		public static void UpdateSupplierNumber(string supNo, string profile)
		{
			if (profile == "GGS")
			{
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_GGS_SUPPLIER_NUMBER SET DATE_USED = CURRENT_DATE WHERE SUPPLIER_NO = {supNo}");
			}
			else
			{
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER_NUMBER SET DATE_USED = CURRENT_DATE WHERE SUPPLIER_NO = {supNo}");
			}
		}

		public static void InsertTaskTrack(string supNo, string profile)
		{
			SnowflakeCommand($@"INSERT INTO ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK (SUPPLIER_NO, TASKID, TASK_DESCRIPTION, AUTO_COMPLETED, BACKEND_CHECK, PROFILE, BYPASSED)
							   SELECT '{supNo}' AS SUPPLIER_NO, TASKID, TASK_DESCRIPTION, AUTO_COMPLETED, BACKEND_CHECK, '{profile}', FALSE
							   FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_LIST WHERE {profile} = TRUE");
		}

		public static void CompleteFirstTask(string supNo)
		{
			SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET INITIATED = CURRENT_DATE, COMPLETED = CURRENT_DATE WHERE SUPPLIER_NO = '{supNo}' AND TASKID = '1A'");
		}

		public static void InitiateSecondTask(string supNo)
		{
			SnowflakeCommand(@$"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET INITIATED = CURRENT_DATE WHERE SUPPLIER_NO = '{supNo}' 
				AND TASKID IN (SELECT MIN(TASKID) FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO = '{supNo}' AND TASKID != '1A')");
		}

		//SUPPLIER INFO QUERIES
		public static void UpdateSupplier(string supNo, string values) 
		{
			SnowflakeCommand($@"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER
				SET CONTACT_PHONE = v.CONTACT_PHONE, COMMENTS = v.COMMENTS, CONTRACT_TYPE = v.CONTRACT_TYPE, SUPPLIER_NAME = v.SUPPLIER_NAME, 
				COUNTRY = v.COUNTRY, STATE = v.STATE, CITY = v.CITY, CONTACT_EMAIL = v.CONTACT_EMAIL, CONTACT_NAME = v.CONTACT_NAME,
				SM_NAME = v.SM_NAME, SM_RACFID = v.SM_RACFID, SM_EMAIL = v.SM_EMAIL, SM_ROLE = v.SM_ROLE, STATUS = v.STATUS, SPA_EMAIL = v.SPA_EMAIL
				
				FROM VALUES({values}) v(SUPPLIER_NAME, CONTACT_NAME, CONTACT_EMAIL, CONTACT_PHONE,  COUNTRY, STATE,  CITY, CONTRACT_TYPE, 
				COMMENTS, SM_NAME,  SM_RACFID,  SM_EMAIL, SM_ROLE, STATUS, SPA_EMAIL)
				WHERE SUPPLIER_NO = '{supNo}'");
		}

		// BACKEND QUERIES
		public static void ResetReservedSupplierNo()
		{
			Parallel.Invoke(() => SnowflakeCommand(@"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER_NUMBER SET DATE_USED = NULL WHERE DATE_USED IS NOT NULL AND SUPPLIER_NO NOT IN 
				(SELECT SUPPLIER_NO FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER UNION SELECT SUPPLIER_INT FROM PUBLISH.GSCCE.SUPPLIER_EDV WHERE SUPPLIER_CHAR LIKE '00200%')"),
				() => SnowflakeCommand(@"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_GGS_SUPPLIER_NUMBER SET DATE_USED = NULL WHERE DATE_USED IS NOT NULL AND SUPPLIER_NO NOT IN 
				(SELECT SUPPLIER_NO FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER UNION SELECT SUPPLIER_INT FROM PUBLISH.GSCCE.SUPPLIER_EDV WHERE SUPPLIER_CHAR LIKE '00208%')")
			);
		}
	}
}