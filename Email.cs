using System.Text;
using System.Data;
using static ONBOARDING.DBConnection;
using Org.BouncyCastle.Bcpg;


namespace ONBOARDING
{
	internal class Email
	{
		static readonly DataView secret = SnowflakeView("SELECT TO_VARCHAR(DECRYPT(API_KEY, '-sAlly$N3verLies!'), 'UTF-8') AS API_KEY FROM ISP.RA.SMTP_SECRET;");

        public static string ConvertFileToHexString(string filePath)
		{
			byte[] bytes = File.ReadAllBytes(filePath);
			string hexString = BitConverter.ToString(bytes).Replace("-", string.Empty);
			return hexString;
		}

		// How to use
		//  _ = Task.Run(function: async () => await EMAIL.SMTP("", "", "", "", "", ""));
		public static async Task<string> SMTP(string emFrom, string emTo, string emCC, string emSubject, string emMessage, string emAttachment)
		{
			if (!string.IsNullOrEmpty(emAttachment)) {
				emAttachment = Path.GetFileName(emAttachment) + ":" + ConvertFileToHexString(emAttachment);
			}

			emMessage = emMessage.Replace("\n", "<br>");
			emMessage = $"<div style='padding: 3px; width: 120px; word-wrap: break-word;'>{emMessage}</div>";

			string TransportProtocol = secret[0]["API_KEY"].ToString();

            string url = "https://netapps.grainger.com/deptutil/ProdMgmt.asmx";

			string soapString = $@"<?xml version=""1.0"" encoding=""utf-8""?>
				<soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">
				  <soap12:Body>
					<SMTPEmail xmlns=""http://www.supplierconnect.com/LINUX_RULES"">
					  <RacfID></RacfID>
					  <EmailAddress>{emFrom}</EmailAddress>
					  <To>{emTo}</To>
					  <CC>{emCC}</CC>
					  <BCC></BCC>
					  <Subj><![CDATA[{emSubject}]]></Subj>
					  <Text><![CDATA[{emMessage}]]></Text>
					  <IsBodyHtml>True</IsBodyHtml>
					  <Server></Server>
					  <Debug>False</Debug>
					  <GUID><![CDATA[{TransportProtocol}]]></GUID>
					  <Attachments><![CDATA[{emAttachment}]]></Attachments>
					  <RelayCount></RelayCount>
					</SMTPEmail>
				  </soap12:Body>
				</soap12:Envelope>";

			HttpResponseMessage response = await PostXmlRequest(url, soapString);
			string content = await response.Content.ReadAsStringAsync();
			//MessageBox.Show(content);
			return content;
		}

		public static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
		{
			var httpClient = new HttpClient();
			var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
			return await httpClient.PostAsync(baseUrl, httpContent);
		}

		public static void SendTaskCompleteEmails(string taskID, string supNo, string profile)
		{
			DataView supplierInfo = Query.SupplierInfo(supNo, false); 
			DataView emailTable = SnowflakeView($"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_EMAIL WHERE TASKID = '{taskID}' AND PROFILE = '{profile}'");
			string smEmail = supplierInfo[0]["SM_EMAIL"].ToString();
			string spaEmail = supplierInfo[0]["SPA_EMAIL"].ToString();
			string supplierName = supplierInfo[0]["SUPPLIER_NAME"].ToString();
            string initialSupplierContact = supplierInfo[0]["CONTACT_EMAIL"].ToString();

            foreach (DataRowView row in emailTable)
			{
				string emFrom = row["EMAIL_FROM"].ToString();
				string emTo = row["EMAIL_TO"].ToString();
				string emCC = row["EMAIL_CC"].ToString();
				string emSubject = $"({row["EMAIL_ID"]}) {row["EMAIL_SUBJECT"]} {supNo} - {supplierName}";
				string emMessage = row["EMAIL_MESSAGE"].ToString();
				string emAttachment = $@"{row["EMAIL_ATTACHMENT"]}";
				string supplierDestination = row["SUPPLIER_DESTINATION"].ToString();
				string sm = row["SM"].ToString();
				string spa = row["SPA"].ToString();
				string customFile = row["CUSTOM_ATTACHMENT"].ToString();

				if (customFile == "True") emAttachment = @$"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\Vendor Masters\{supNo}_New Supplier Contact Form.xlsx";
				if (!string.IsNullOrEmpty(supplierDestination))
				{
					emTo += $";{initialSupplierContact}";
					DataView supplierContacts = SQLView(Query.SupplierContacts(supNo, supplierDestination));
					foreach(DataRowView roleRow in supplierContacts) emTo += $";{roleRow["EMAIL"]}";
				}

				if (sm.Contains("CC")) emCC += $";{smEmail}";
				if (spa.Contains("CC")) emCC += $";{spaEmail}";
				if (sm.Contains("TO")) emTo += $";{smEmail}";
				if (spa.Contains("TO")) emTo += $";{spaEmail}";
				_ = Task.Run(function: async () => await SMTP(emFrom, emTo, emCC, emSubject, emMessage, emAttachment));
			}
		}
	}
}