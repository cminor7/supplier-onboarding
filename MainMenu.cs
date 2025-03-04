using System;
using System.Diagnostics;
using static ONBOARDING.DBConnection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static ONBOARDING.Email;
using System.Data;
using Windows.ApplicationModel.Email;

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
    }
}