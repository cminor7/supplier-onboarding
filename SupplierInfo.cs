using Azure.Storage.Blobs.Models;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Windows.ApplicationModel.Contacts;

namespace ONBOARDING
{
	public partial class form_supplier_info : Form
	{
		DataView supplierInfo;
		DataView SMSEmployee;
		DataView countryCode;

		public form_supplier_info()
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
			countryCode = Query.CountryCode();
			foreach (DataRowView row in countryCode)
			{
				string country = $"{row["COUNTRY_DESC"]} ({row["COUNTRY"]})";
				combox_supplier_country.Items.Add(country);
			}
		}

		private void txtbox_supplier_search_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtbox_supplier_search.Text.Length > 4) LoadSupplierInfo();
		}

		private void LoadSupplierInfo()
		{
			strip_message.Text = $"HANG ON, I'M SEARCHING...  ─=≡Σʕっ•ᴥ•ʔっ";
			string supplierSearch = txtbox_supplier_search.Text.Replace("'", "''").Trim();
			bool fuzzy = true;
			if (supplierSearch.Replace(" ", "").All(char.IsDigit)) { fuzzy = false; supplierSearch = supplierSearch.Replace(" ", "").TrimStart('0'); }

			supplierInfo = Query.SupplierInfo(supplierSearch, fuzzy);
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			strip_time.Text = currentTime;
			if (supplierInfo.Count == 0)
			{
				strip_message.Text = @$"NO RESULTS FOR <{supplierSearch}>  ¯\_(ツ)_/¯";
				ClearData();
				return;
			}

			DataRowView supplier = supplierInfo[0]; // get the first/only row of the selected supplier
			if (supplier["COUNTRY"].ToString() != "US" && supplier["COUNTRY"].ToString() != "CA") combox_supplier_state.Enabled = false;
			else combox_supplier_state.Enabled = true;

			lbl_supplier_no.Text = $"SUPPLIER  <{supplier["SUPPLIER_NO"]}>";
			lbl_supplier_name.Text = supplier["SUPPLIER_NAME"].ToString();
			combox_status.Text = supplier["STATUS"].ToString();
			txtbox_supplier_name.Text = supplier["SUPPLIER_NAME"].ToString();
			txtbox_contact_name.Text = supplier["CONTACT_NAME"].ToString();
			txtbox_contact_email.Text = supplier["CONTACT_EMAIL"].ToString();
			txtbox_contact_phone.Text = supplier["CONTACT_PHONE"].ToString();
			countryCode.RowFilter = $"COUNTRY = '{supplier["COUNTRY"]}'";
			combox_supplier_country.Text = $"{countryCode[0]["COUNTRY_DESC"]} ({countryCode[0]["COUNTRY"]})";
			combox_supplier_state.Text = supplier["STATE"].ToString();
			txtbox_supplier_city.Text = supplier["CITY"].ToString();
			combox_sm_name.Text = $"{supplier["SM_NAME"]} ({supplier["SM_RACFID"]})";
			combox_contract_type.Text = supplier["CONTRACT_TYPE"].ToString();
			txtbox_comments.Text = supplier["COMMENTS"].ToString();
			txtbox_spa_email.Text = supplier["SPA_EMAIL"].ToString();
			strip_message.Text = $"DISPLAYING INFORMATION FOR SUPPLIER <{supplier["SUPPLIER_NO"]}>  ( ･ω･)ﾉ";
		}

		private void bttn_update_profile_Click(object sender, EventArgs e)
		{
			if (supplierInfo is null || supplierInfo.Count == 0) return;
			var email = new EmailAddressAttribute();
			if (!(email.IsValid(txtbox_contact_email.Text)))
			{
				MessageBox.Show("ENTER A VALID EMAIL  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
            if (!int.TryParse(txtbox_contact_phone.Text.Replace(" ", ""), out _))
            {
                MessageBox.Show("ONLY NUMBERS ALLOWED FOR PHONE NUMBER  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Control ctrl in panel_supplier_info.Controls)
			{
				if (ctrl.Name == "panel_supplier_info" || ctrl.Name == "txtbox_comments" || ctrl is Label || ctrl is StatusStrip || ctrl.Name == "combox_pm_code") continue;
				if (string.IsNullOrWhiteSpace(ctrl.Text))
				{
					if (ctrl.Name == "combox_supplier_state" && combox_supplier_country.Text != "USA (US)" && combox_supplier_country.Text != "CANADA (CA)") continue;
					MessageBox.Show("REQUIRED FIELD(S) ARE EMPTY  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			DialogResult result = MessageBox.Show("UPDATE SUPPLIER INFO  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No) return;

			DataRowView supplier = supplierInfo[0];
			string supNo = supplier["SUPPLIER_NO"].ToString();
			string smRacfid = Regex.Matches(combox_sm_name.Text, @"\((.+?)\)")[0].Groups[1].Value;
			SMSEmployee.RowFilter = $"COMPUTERID = '{smRacfid}'";
			string smEmail = SMSEmployee[0]["EMAIL"].ToString();
			string smRole = SMSEmployee[0]["ROLE"].ToString();
			string smName = SMSEmployee[0]["EMPLOYEE"].ToString();
			string requestorRacfid = Environment.UserName.ToUpper();
			string supName = txtbox_supplier_name.Text.ToUpper().Replace("'", "''").Trim();
			string supContactName = txtbox_contact_name.Text.ToUpper().Replace("'", "''").Trim();
			string supContactEmail = txtbox_contact_email.Text;
			string supContactPhone = txtbox_contact_phone.Text;
			string supCountry = Regex.Matches(combox_supplier_country.Text, @"\((.+?)\)")[0].Groups[1].Value;
			string supState = combox_supplier_state.Text;
			string supCity = txtbox_supplier_city.Text.ToUpper().Replace("'", "''").Trim();
			string status = combox_status.Text;
			string contractType = combox_contract_type.Text;
			string comments = txtbox_comments.Text.Replace("\n", "\r\n").ToUpper().Replace("'", "''").Trim();
			string spaEmail = txtbox_spa_email.Text.ToUpper().Trim();
			
			string[] onboardingValues = {supName, supContactName, supContactEmail, supContactPhone, supCountry, supState, supCity, contractType, comments,
				 smName, smRacfid, smEmail, smRole, status, spaEmail };
			string valueString = string.Join(",", onboardingValues.Select(value => $"'{value}'"));

			Query.UpdateSupplier(supNo, valueString);
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			strip_message.Text = $"SUPPLIER <{supNo}> HAS BEEN UPDATED  ( ﾉ･o･ )ﾉ";
			strip_time.Text = currentTime;
		}

		private void ClearData()
		{
			foreach (Control ctrl in panel_supplier_info.Controls)
			{
				if (ctrl.Name == "panel_supplier_info" || ctrl is Label || ctrl.Name == "txtbox_spa_email") continue;
				ctrl.Text = "";
			}
			lbl_supplier_name.Text = "";
			txtbox_supplier_search.Text = "";
		}

		private void combox_supplier_country_Leave(object sender, EventArgs e)
		{
			if (combox_supplier_country.Text.Length > 0 && !combox_supplier_country.Items.Contains(combox_supplier_country.Text))
			{
				MessageBox.Show("INVALID COUNTRY, SELECT FROM OPTION  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				combox_supplier_country.Text = "";
			}
			else if (combox_supplier_country.Text.ToUpper() != "USA (US)" && combox_supplier_country.Text.ToUpper() != "CANADA (CA)")
			{
				combox_supplier_state.Text = "";
				combox_supplier_state.Enabled = false;
			}
			else combox_supplier_state.Enabled = true;
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
				MessageBox.Show("INVALID SM, SELECT FROM OPTION  ヾ( ･`⌓´･)ﾉﾞ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				combox_sm_name.Text = "";
			}
		}

		private void action_delete_supplier_Click(object sender, EventArgs e)
		{
			if (supplierInfo is null || supplierInfo.Count == 0) return;
			DialogResult result = MessageBox.Show("DELETE THIS SUPPLIER  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.No) return;
			string supNo = supplierInfo[0]["SUPPLIER_NO"].ToString();
			string supProfile = supplierInfo[0]["PROFILE"].ToString();
			Query.DeleteSupplier(supNo, supProfile);
			ClearData();
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			strip_message.Text = $"SUPPLIER <{supNo}> HAS BEEN DELETED  (╯°□°)╯︵ ┻━┻";
			strip_time.Text = currentTime;
		}
	}
}