using System.Data;
using static ONBOARDING.DBConnection;

namespace ONBOARDING
{
	public partial class form_email_info : Form
	{
		DataView emailInfo;
		public form_email_info()
		{
			InitializeComponent();
			LoadEmailInfo();
		}

		private void LoadEmailInfo()
		{
			emailInfo = SnowflakeView("SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_EMAIL");
			foreach (DataRowView row in emailInfo)
			{
				string emailID = $"{row["EMAIL_ID"]}";
				combox_email_id.Items.Add(emailID);
			}
		}

		private void combox_email_id_SelectedValueChanged(object sender, EventArgs e)
		{
			emailInfo.RowFilter = $"EMAIL_ID = '{combox_email_id.Text}'";
			DataRowView emailIDRow = emailInfo[0];
			txtbox_sup_profile.Text = emailIDRow["PROFILE"].ToString();
			txtbox_taskID.Text = emailIDRow["TASKID"].ToString();
			txtbox_email_to.Text = emailIDRow["EMAIL_TO"].ToString();
			txtbox_email_cc.Text = emailIDRow["EMAIL_CC"].ToString();
			txtbox_email_subject.Text = emailIDRow["EMAIL_SUBJECT"].ToString();
			txtbox_email_message.Text = emailIDRow["EMAIL_MESSAGE"].ToString().Replace("\n", "\r\n");

			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			strip_time.Text = currentTime;
			strip_message.Text = $"DISPLAYING INFORMATION FOR EMAIL_ID <{combox_email_id.Text}>  ( ･ω･)ﾉ";
		}

		private void bttn_update_email_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("UPDATE EMAIL INFO  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;

			string emailID = combox_email_id.Text;
			SnowflakeCommand(@$"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_EMAIL SET 
				EMAIL_TO = '{txtbox_email_to.Text}',
				EMAIL_CC = '{txtbox_email_cc.Text}',
				EMAIL_SUBJECT = '{txtbox_email_subject.Text.Replace("'", "''")}', 
				EMAIL_MESSAGE = '{txtbox_email_message.Text.Replace("'", "''").Replace("\r\n", "\n")}'
				WHERE EMAIL_ID = '{emailID}'");
			emailInfo = SnowflakeView("SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_EMAIL");
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			strip_time.Text = currentTime;
			strip_message.Text = $"EMAIL_ID <{combox_email_id.Text}> HAS BEEN UPDATED  ( ﾉ･o･ )ﾉ";
		}
	}
}
