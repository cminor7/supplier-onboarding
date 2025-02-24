using System.Data;
using System.ComponentModel.DataAnnotations;
using static ONBOARDING.Email;
using System.Text.RegularExpressions;


namespace ONBOARDING
{
	public partial class form_single_request : Form
	{
		DataView SMSEmployee;

		public form_single_request()
		{
			InitializeComponent();
			Parallel.Invoke(() => LoadComboxSF(), () => LoadComboxSQL());
		}

		private void LoadComboxSQL()
		{
			SMSEmployee = Query.SMSEmployee();
			foreach (DataRowView row in SMSEmployee)
			{
				string nameID = $"{row["EMPLOYEE"]} ({row["COMPUTERID"]})";
				combox_sm_name.Items.Add(nameID);
			}
		}

		private void LoadComboxSF()
		{
			DataView countryCode = Query.CountryCode();
			foreach (DataRowView row in countryCode)
			{
				string country = $"{row["COUNTRY_DESC"]} ({row["COUNTRY"]})";
				combox_supplier_country.Items.Add(country);
			}
		}

		private void combox_profile_SelectedIndexChanged(object sender, EventArgs e)
		{
			string supProfile = combox_profile.Text;
			DataView minSupplierNo = Query.MinSupplierNo(supProfile);
			combox_supplier_no.DataSource = minSupplierNo;
			combox_supplier_no.ValueMember = "SUPPLIER_NO";
			Query.UpdateSupplierNumber(minSupplierNo[0]["SUPPLIER_NO"].ToString(), supProfile); // reserve the supplier number in advance to prevent others from using it.
		}

		private void bttn_submit_profile_Click(object sender, EventArgs e)
		{
			var email = new EmailAddressAttribute();
			if (!(email.IsValid(txtbox_contact_email.Text)))
			{
				MessageBox.Show("ENTER A VALID EMAIL  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            if (!(Regex.Replace(txtbox_contact_phone.Text, @"[\s-]", "").All(char.IsDigit)))
			{
                MessageBox.Show("ONLY NUMBERS ALLOWED FOR PHONE NUMBER  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Control ctrl in panel_supplier_info.Controls) // check if any required fields are empty
			{
				if (ctrl.Name == "panel_single_request" || ctrl.Name == "txtbox_comments" || ctrl is Label || ctrl.Name == "combox_pm_code") continue;
				if (string.IsNullOrWhiteSpace(ctrl.Text))
				{
					if (ctrl.Name == "combox_supplier_state" && combox_supplier_country.Text != "USA (US)" && combox_supplier_country.Text != "CANADA (CA)") continue;
					MessageBox.Show("REQUIRED FIELD(S) ARE EMPTY  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			DialogResult result = MessageBox.Show("SUBMIT SUPPLIER INFO  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;

			string smRacfid = Regex.Matches(combox_sm_name.Text, @"\((.+?)\)")[0].Groups[1].Value;
			SMSEmployee.RowFilter = $"COMPUTERID = '{smRacfid}'";
			string smName = SMSEmployee[0]["EMPLOYEE"].ToString();
			string smEmail = SMSEmployee[0]["EMAIL"].ToString();
			string smRole = SMSEmployee[0]["ROLE"].ToString();
			string requestorRacfid = Environment.UserName.ToUpper();
			string supNo = combox_supplier_no.Text;
			string supProfile = combox_profile.Text;
			string supName = txtbox_supplier_name.Text.ToUpper().Replace("'", "''").Trim();
			string supContactName = txtbox_contact_name.Text.ToUpper().Replace("'", "''").Trim();
			string supContactEmail = txtbox_contact_email.Text;
			string supContactPhone = txtbox_contact_phone.Text;
			string supCountry = Regex.Matches(combox_supplier_country.Text, @"\((.+?)\)")[0].Groups[1].Value;
			string supState = combox_supplier_state.Text;
			string supCity = txtbox_supplier_city.Text.ToUpper().Replace("'", "''").Trim();
			string SPAEmail = txtbox_spa_email.Text;
			string contractType = combox_contract_type.Text;
			string comments = txtbox_comments.Text.Replace("\n", "\r\n").ToUpper().Replace("'", "''").Trim();

			string contactForm = @"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\Vendor Masters\New Supplier Contact Form.xlsx";
			string newContactForm = $"{supNo}_New Supplier Contact Form.xlsx";
			string destinationFilePath = $@"\\us.grainger.com\files\Office\LF\DB\PM\MerchandisingDBs\New Supplier Onboarding\Vendor Masters\{newContactForm}";

			string[] onboardingValues = {supNo, supName, supProfile,  supContactName, supContactEmail, supContactPhone, supCountry, supState, supCity, SPAEmail, contractType, comments,
				 smName, smRacfid, smEmail, smRole, requestorRacfid };
			string valueString = string.Join(",", onboardingValues.Select(value => $"'{value}'"));

			Parallel.Invoke(() => File.Copy(contactForm, destinationFilePath, true), 
				() => Query.InsertSupplierInfo(valueString), 
				() => Query.InsertTaskTrack(supNo, supProfile));


			Parallel.Invoke(() => SendTaskCompleteEmails("1A", supNo, supProfile), 
				() => Query.CompleteFirstTask(supNo), 
				() => Query.InitiateSecondTask(supNo));

			MessageBox.Show($"SUPPLIER <{supNo}> HAS BEEN ADDED  ( ﾉ･o･ )ﾉ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void combox_supplier_country_Leave(object sender, EventArgs e)
		{
			if (combox_supplier_country.Text.Length > 0 && !combox_supplier_country.Items.Contains(combox_supplier_country.Text))
			{
				MessageBox.Show("INVALID COUNTRY, SELECT FROM OPTION  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				combox_supplier_country.Text = "";
			}
			else if (combox_supplier_country.Text != "USA (US)" && combox_supplier_country.Text != "CANADA (CA)")
			{
				combox_supplier_state.Text = "";
				combox_supplier_state.Enabled = false;
			}
			else
			{
				combox_supplier_state.Enabled = true;
			}
		}

		private void combox_supplier_state_Leave(object sender, EventArgs e)
		{
			if (combox_supplier_state.Text.Length > 0 && !combox_supplier_state.Items.Contains(combox_supplier_state.Text.ToUpper()))
			{
				MessageBox.Show("INVALID STATE, SELECT FROM OPTION  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				combox_supplier_state.Text = "";
			}
		}

		private void combox_sm_name_Leave(object sender, EventArgs e)
		{
			if (combox_sm_name.Text.Length > 0 && !combox_sm_name.Items.Contains(combox_sm_name.Text))
			{
				MessageBox.Show("INVALID SM NAME, SELECT FROM OPTION  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				combox_sm_name.Text = "";
			}
		}
	}
}