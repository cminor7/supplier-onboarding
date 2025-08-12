using System;
using System.Diagnostics;
using static ONBOARDING.DBConnection;
using static ONBOARDING.Email;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace ONBOARDING
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void bttn_supplier_task_Click(object sender, EventArgs e)
        {
            form_supplier_tasks formSupplierTask = new();
            formSupplierTask.Show();
        }

        private void bttn_refresh_tables_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("REFRESH ALL BACKEND TABLES?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            BackendCheck.RefreshTables();
            MessageBox.Show("BACKEND TABLES HAVE BEEN REFRESHED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Single_Request_Click(object sender, EventArgs e)
        {
            form_single_request formSingleRequest = new();
            formSingleRequest.Show();
        }

        private void bttn_supplier_info_Click(object sender, EventArgs e)
        {
            form_supplier_info formSupplierInfo = new();
            formSupplierInfo.Show();
        }

        private void action_add_supplier_number_Click(object sender, EventArgs e)
        {
            SnowflakeCommand("CALL ISP.SPM.INSERT_ONBOARDING_SUPPLIER_NUMBER()");
            MessageBox.Show("100 SUPPLIER NUMBERS HAVE BEEN ADDED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void action_add_ggs_supplier_number_Click(object sender, EventArgs e)
        {
            SnowflakeCommand("CALL ISP.SPM.INSERT_ONBOARDING_GGS_SUPPLIER_NUMBER()");
            MessageBox.Show("100 GGS SUPPLIER NUMBERS HAVE BEEN ADDED", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnections();
        }

        private void report_power_bi_Click(object sender, EventArgs e)
        {
            string url = @"https://app.powerbi.com/groups/me/reports/7ab56a62-7a20-4d03-931e-06e935ba167b/8091c05f1a22f24ee02b?ctid=48d1dcb6-bccc-4365-ac7f-b937a7f7fd71&experience=power-bi";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void help_manual_Click(object sender, EventArgs e)
        {
            string url = @"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\supplier_onboarding\documentation.pdf";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void help_process_map_Click(object sender, EventArgs e)
        {
            string url = @"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\supplier_onboarding\NSO_Process_Maps.pdf";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }

        private void MainMenu_Load(object sender, EventArgs e) // check for update, VPN and sharedrive access
        {
            string version;
            try
            {
                version = File.ReadAllText(@"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\supplier_onboarding\current_version.txt");
            }
            catch
            {
                MessageBox.Show("VPN OFF / NO SHAREDRIVE ACESSS", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (version == txtbox_version.Text) return;
            DialogResult result = MessageBox.Show("NEW VERSION AVAILABLE, PLEASE UPDATE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe", @"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\supplier_onboarding\LATEST_VERSION");
            this.Close();
        }

        private void bttn_email_info_Click(object sender, EventArgs e)
        {
            form_email_info formEmailInfo = new();
            formEmailInfo.Show();
        }

        private void bttn_reminder_email_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("SEND REMINDER EMAILS?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            // list of tasks that are opened and needed action + initial contact for onboarding
            DataView reminderTask = SnowflakeView(@"SELECT TASK_TRACK.SUPPLIER_NO, TASK_LIST.TASKID, INITIATED, COMPLETED, REMINDER_EMAIL, 
                CONCAT(TASK_LIST.TASKID, ' -> ', TASK_LIST.TASK_DESCRIPTION) AS TASK_LIST, ONBOARD_SUPPLIER.SM_NAME, 
                CASE 
                    WHEN TASK_LIST.TASKID = '2A' THEN 'SUPPLIER_MAINTENANCE@GRAINGER.COM' 
                    ELSE ONBOARD_SUPPLIER.SM_EMAIL 
                    END AS SM_EMAIL,
                ONBOARD_SUPPLIER.SUPPLIER_NAME, ONBOARD_SUPPLIER.CONTACT_NAME, ONBOARD_SUPPLIER.CONTACT_EMAIL, ONBOARD_SUPPLIER.CONTACT_PHONE
                
                FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK TASK_TRACK
                INNER JOIN (SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_LIST WHERE REMINDER_EMAIL IS NOT NULL) TASK_LIST
                    ON TASK_TRACK.TASKID = TASK_LIST.TASKID
                INNER JOIN (SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER WHERE STATUS = 'ONBOARDING') ONBOARD_SUPPLIER
                    ON TASK_TRACK.SUPPLIER_NO = ONBOARD_SUPPLIER.SUPPLIER_NO
                WHERE INITIATED IS NOT NULL
                AND COMPLETED IS NULL
                AND CURRENT_DATE - TO_DATE(INITIATED) >= 7;");

            // grab the email template
            DataView emailInfo = SnowflakeView("SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_EMAIL WHERE TASKID IN ('SM', 'SUPPLIER');");

            // supplier contacts from the contact table (in case the initial supplier contact is outdated)
            DataView supplierContacts = Query.supplierContact();


            List<long> supplierNoList = reminderTask.Cast<DataRowView>() // get list of distinct supplier_no that has outstanding tasks
                .Select(row => row.Row.Field<long>("SUPPLIER_NO")).Distinct().ToList();

            foreach (long supplierNo in supplierNoList)
            {
                reminderTask.RowFilter = $"SUPPLIER_NO = '{supplierNo}' AND REMINDER_EMAIL = 'SUPPLIER'";
                emailInfo.RowFilter = $"TASKID = 'SUPPLIER'";
                string EmailID = emailInfo[0]["EMAIL_ID"].ToString();

                string emFrom = emailInfo[0]["EMAIL_FROM"].ToString();
                string emCC = emailInfo[0]["EMAIL_FROM"].ToString();
                string emAttachment = emailInfo[0]["EMAIL_ATTACHMENT"].ToString();
                supplierContacts.RowFilter = $"SUPPLIER_NO = '{supplierNo}'";

                string emToSupplier = "";

                if (supplierContacts.Count > 0) // add updated contacts for sending
                {
                    foreach (DataRowView row in supplierContacts) emToSupplier += $"{row["SUPPLIER_EMAIL"]};";
                }

                if (reminderTask.Count > 0) // outstanding supplier tasks found - send email
                {
                    string taskList = "";
                    foreach (DataRowView row in reminderTask) taskList += $"<li>{row["TASK_LIST"]}</li> <br>";
                    string emMessage = emailInfo[0]["EMAIL_MESSAGE"].ToString().Replace("[TaskID – TASK_DESCRIPTION]", taskList);
                    string emSubject = $"({EmailID}) Grainger New Supplier Onboarding: REMINDER for {supplierNo} - {reminderTask[0]["SUPPLIER_NAME"].ToString()}";
                    emToSupplier += $"{reminderTask[0]["CONTACT_EMAIL"].ToString()}";

                    _ = Task.Run(function: async () => await SMTP(emFrom, emToSupplier, emCC, emSubject, emMessage, emAttachment));
                }

                reminderTask.RowFilter = $"SUPPLIER_NO = '{supplierNo}' AND REMINDER_EMAIL = 'SM'";
                emailInfo.RowFilter = $"TASKID = 'SM'";
                EmailID = emailInfo[0]["EMAIL_ID"].ToString();

                if (reminderTask.Count > 0) // outstanding sm tasks found - send email
                {
                    string taskList = "";
                    foreach (DataRowView row in reminderTask) taskList += $"<li>{row["TASK_LIST"]}</li> <br>";
                    string emMessage = emailInfo[0]["EMAIL_MESSAGE"].ToString().Replace("[TaskID – TASK_DESCRIPTION]", taskList);
                    string emSubject = $"({EmailID}) Grainger New Supplier Onboarding: REMINDER for {supplierNo} - {reminderTask[0]["SUPPLIER_NAME"].ToString()}";
                    string emToSM = reminderTask[0]["SM_EMAIL"].ToString();
                    _ = Task.Run(function: async () => await SMTP(emFrom, emToSM, emCC, emSubject, emMessage, emAttachment));
                }
            }
            MessageBox.Show("REMINDER EMAILS SENT", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}