using System.Data;
using static ONBOARDING.DBConnection;
using static ONBOARDING.Email;

namespace ONBOARDING
{
	public class BackendCheck
	{
		static DataView backendTasks;
		public static void RefreshTables()
		{
			backendTasks = SnowflakeView($@"SELECT s.SUPPLIER_NO, s.PROFILE, tt.TASKID, tt.INITIATED, tt.COMPLETED
				FROM 
				(
					SELECT SUPPLIER_NO, TASKID, INITIATED, COMPLETED 
					FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK
					WHERE BACKEND_CHECK = true AND INITIATED IS NOT NULL AND COMPLETED IS NULL
				) tt 
				INNER JOIN
				(SELECT SUPPLIER_NO, PROFILE FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER WHERE STATUS = 'ONBOARDING') s
					ON tt.SUPPLIER_NO = s.SUPPLIER_NO");
			
			Query.ResetReservedSupplierNo() ; //reset any unused reserved supplier numbers

			foreach (DataRowView row in backendTasks)
			{
				string supNo = row["SUPPLIER_NO"].ToString();
				string profile = row["PROFILE"].ToString();
				string taskID = row["TASKID"].ToString();
				CompleteBackend(supNo, profile, taskID);
			}
		}

		public static bool CompleteBackend(string supNo, string profile, string taskID)
		{
			return taskID switch
			{
				"2A" => Task_2A(supNo, profile),
				"2B" => Task_2B(supNo, profile),
				"2C" =>	Task_2C(supNo, profile),
				"3E" => Task_3E(supNo, profile),
				"3Y" => Task_3Y(supNo, profile),
				"3B" => Task_3B(supNo, profile),
				"3F" => Task_3F(supNo, profile),
				_ => false,
			};
		}

		private static bool Task_2A(string supNo, string profile)
		{
			object result = ExecuteScalarQuery(Query.CheckTBLSupplier(supNo));
			bool hasValue = result != null && Convert.ToInt32(result) >= 1;
			if (hasValue) { CompleteAutoTask("2A", supNo, profile); return true; } 
			else return false;
		}

		private static bool Task_2B(string supNo, string profile)
		{
			object result = ExecuteScalarQuery(Query.CheckContacts(supNo));
			bool hasBothValues = result != null && Convert.ToInt32(result) == 1;
			if (hasBothValues){ CompleteAutoTask("2B", supNo, profile); return true; } 
			else return false;
		}

		private static bool Task_2C(string supNo, string profile)
		{
			DataView supplierConnect = SnowflakeView($"SELECT VENDOR FROM TERADATA.PRD_DWH_VIEW_LMT.AUTH0_ACTIVE_VENDORS_INFO_VIEW WHERE TRY_TO_NUMBER(VENDOR) = '{supNo}'");
			if (supplierConnect.Count > 0) { CompleteAutoTask("2C", supNo, profile); return true; }
			else return false;
		}

		private static bool Task_3E(string supNo, string profile)
		{
			DataView npiItemV = SnowflakeView($"SELECT vendor_no, MIN(vendor_npi_enter) AS MIN_DATE FROM TERADATA.PURCHASING.NPI_REPORT_ITEM_V WHERE vendor_no = '{supNo}' GROUP BY ALL");
			if (npiItemV.Count == 0) return false;
			
			DataRowView record = npiItemV[0];
			bool recordIsNotNull = !record.Row.IsNull("MIN_DATE");

			if (recordIsNotNull) {CompleteAutoTask("3E", supNo, profile); return true; } 
			else return false;
		}

		private static bool Task_3Y(string supNo, string profile)
		{
			DataView tblMaterial = SQLView($"SELECT MIN([Create Date]) AS MIN_DATE FROM Itemmanagement.dbo.tblMaterials WHERE [Supplier No] = '{supNo}'");
			string rawDateCompleted = tblMaterial[0]["MIN_DATE"].ToString();
			if (!DateTime.TryParse(rawDateCompleted, out DateTime parsedDate)) return false;

			string dateCompleted = parsedDate.ToString("yyyy-MM-dd");
			if (!string.IsNullOrEmpty(dateCompleted)) { CompleteAutoTask("3Y", supNo, profile); return true; } 
			else return false;
		}

		private static bool Task_3B(string supNo, string profile)
		{
			object result = ExecuteScalarQuery($"SELECT COUNT(*) AS COUNT_OF_ORDER_SCHEDULES FROM Itemmanagement.dbo.tblSupplier_OrderCalendar WHERE Supplier = '{supNo}' AND [DAY] LIKE 'z%'");
			bool hasOrderSchedule = Convert.ToInt32(result) >= 1;
			if (hasOrderSchedule) { CompleteAutoTask("3B", supNo, profile); return true; } 
			else return false;
		}

		private static bool Task_3F(string supNo, string profile)
		{
			DataView resultTable = SnowflakeView($"SELECT COUNT(*) AS PO_OUTPUT FROM TERADATA.PURCHASING.PURCH_NACH_V WHERE VENDOR = '{supNo}' AND OUTPUT_TYPE LIKE 'Z%' AND DIVISION LIKE '%SAL%'");
			DataRowView result = resultTable[0];
			int POOutput = Convert.ToInt32(result["PO_OUTPUT"]);
			bool POOutputCheck = POOutput >= 1;

			if (POOutputCheck) { CompleteAutoTask("3F", supNo, profile); return true; } 
			else return false;  
		}
		
		private static void InitiateNextTask(string taskID, string supNo, string supProfile)
		{
			DataView dependency = SnowflakeView($"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_DEPENDENCIES WHERE PROFILE = '{supProfile}' AND TASKID = '{taskID}'");
			if (dependency.Count == 0) return;
			DataRowView taskRow = dependency[0];

			string taskToIntitiate = taskRow["INITIATE"].ToString();
			string dependentTasks = taskRow["CHECK_IF_COMPLETE"].ToString();

			if (!string.IsNullOrEmpty(dependentTasks)) {
				if (!Query.DependentTaskComplete(supNo, dependentTasks)) return; // if any dependent tasks are not completed then dont initiate next task
			}
			if (string.IsNullOrEmpty(taskToIntitiate)) return;
			
			Query.InitiateTasks(supNo, taskToIntitiate);
			DataView taskTrack = SnowflakeView($@"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO = '{supNo}' AND AUTO_COMPLETED = true");
			
			string[] initiateTasks = taskToIntitiate.Split(',');
			foreach (string task in initiateTasks)
			{
				taskTrack.RowFilter = $"TaskID = '{task}'";
				if (taskTrack.Count > 0) CompleteAutoTask(task, supNo, supProfile);
			} 
		}

		static void CompleteAutoTask(string taskID, string supNo, string supProfile)
		{
			Query.CompleteTasks(supNo, taskID);
			Parallel.Invoke(() => InitiateNextTask(taskID, supNo, supProfile), () => SendTaskCompleteEmails(taskID, supNo, supProfile));
		}
	}
}