namespace ONBOARDING
{
    partial class form_single_request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_single_request));
            combox_profile = new ComboBox();
            lbl_supplier_profile = new Label();
            lbl_supplier_no = new Label();
            combox_supplier_no = new ComboBox();
            lbl_supplier_contact_name = new Label();
            txtbox_contact_name = new TextBox();
            lbl_supplier_email = new Label();
            txtbox_contact_email = new TextBox();
            lbl_supplier_city = new Label();
            lbl_supplier_state = new Label();
            lbl_supplier_country = new Label();
            lbl_sm_name = new Label();
            lbl_sup_name = new Label();
            lbl_contract_type = new Label();
            lbl_contact_phone = new Label();
            txtbox_supplier_city = new TextBox();
            combox_supplier_state = new ComboBox();
            combox_supplier_country = new ComboBox();
            combox_sm_name = new ComboBox();
            txtbox_supplier_name = new TextBox();
            combox_contract_type = new ComboBox();
            bttn_submit_profile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_supplier_state_ast = new Label();
            label7 = new Label();
            label9 = new Label();
            label12 = new Label();
            panel_single_request = new Panel();
            label13 = new Label();
            label6 = new Label();
            panel_supplier_info = new Panel();
            txtbox_contact_phone = new TextBox();
            txtbox_comments = new TextBox();
            lbl_comments = new Label();
            txtbox_spa_email = new TextBox();
            label_spa_email = new Label();
            panel_single_request.SuspendLayout();
            panel_supplier_info.SuspendLayout();
            SuspendLayout();
            // 
            // combox_profile
            // 
            combox_profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_profile.BackColor = Color.FromArgb(230, 231, 241);
            combox_profile.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_profile.DropDownWidth = 314;
            combox_profile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combox_profile.ForeColor = Color.FromArgb(51, 54, 62);
            combox_profile.FormattingEnabled = true;
            combox_profile.Items.AddRange(new object[] { "STANDARD_PLE", "CSI", "GGS", "SERVICES", "RETAIN" });
            combox_profile.Location = new Point(186, 58);
            combox_profile.Margin = new Padding(2, 1, 2, 1);
            combox_profile.Name = "combox_profile";
            combox_profile.Size = new Size(320, 33);
            combox_profile.TabIndex = 0;
            combox_profile.SelectedIndexChanged += combox_profile_SelectedIndexChanged;
            // 
            // lbl_supplier_profile
            // 
            lbl_supplier_profile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_profile.AutoSize = true;
            lbl_supplier_profile.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_supplier_profile.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_profile.Location = new Point(186, 21);
            lbl_supplier_profile.Name = "lbl_supplier_profile";
            lbl_supplier_profile.Size = new Size(180, 28);
            lbl_supplier_profile.TabIndex = 4;
            lbl_supplier_profile.Text = "SUPPLIER PROFILE";
            // 
            // lbl_supplier_no
            // 
            lbl_supplier_no.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_no.AutoSize = true;
            lbl_supplier_no.Font = new Font("Segoe UI", 12F);
            lbl_supplier_no.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_no.Location = new Point(188, 80);
            lbl_supplier_no.Name = "lbl_supplier_no";
            lbl_supplier_no.Size = new Size(146, 21);
            lbl_supplier_no.TabIndex = 6;
            lbl_supplier_no.Text = "SUPPLIER NUMBER";
            // 
            // combox_supplier_no
            // 
            combox_supplier_no.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_supplier_no.BackColor = Color.FromArgb(230, 231, 241);
            combox_supplier_no.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_supplier_no.Font = new Font("Segoe UI", 12F);
            combox_supplier_no.ForeColor = Color.FromArgb(51, 54, 62);
            combox_supplier_no.FormattingEnabled = true;
            combox_supplier_no.Location = new Point(188, 106);
            combox_supplier_no.Margin = new Padding(3, 4, 3, 4);
            combox_supplier_no.Name = "combox_supplier_no";
            combox_supplier_no.Size = new Size(320, 29);
            combox_supplier_no.TabIndex = 2;
            // 
            // lbl_supplier_contact_name
            // 
            lbl_supplier_contact_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_contact_name.AutoSize = true;
            lbl_supplier_contact_name.Font = new Font("Segoe UI", 12F);
            lbl_supplier_contact_name.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_contact_name.Location = new Point(188, 270);
            lbl_supplier_contact_name.Name = "lbl_supplier_contact_name";
            lbl_supplier_contact_name.Size = new Size(199, 21);
            lbl_supplier_contact_name.TabIndex = 8;
            lbl_supplier_contact_name.Text = "SUPPLIER CONTACT NAME";
            // 
            // txtbox_contact_name
            // 
            txtbox_contact_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_name.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_name.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_name.Font = new Font("Segoe UI", 12F);
            txtbox_contact_name.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_name.Location = new Point(188, 300);
            txtbox_contact_name.Margin = new Padding(3, 4, 3, 4);
            txtbox_contact_name.MaxLength = 100;
            txtbox_contact_name.Name = "txtbox_contact_name";
            txtbox_contact_name.Size = new Size(320, 29);
            txtbox_contact_name.TabIndex = 4;
            // 
            // lbl_supplier_email
            // 
            lbl_supplier_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_email.AutoSize = true;
            lbl_supplier_email.Font = new Font("Segoe UI", 12F);
            lbl_supplier_email.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_email.Location = new Point(188, 368);
            lbl_supplier_email.Name = "lbl_supplier_email";
            lbl_supplier_email.Size = new Size(199, 21);
            lbl_supplier_email.TabIndex = 10;
            lbl_supplier_email.Text = "SUPPLIER CONTACT EMAIL";
            // 
            // txtbox_contact_email
            // 
            txtbox_contact_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_email.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_email.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_email.Font = new Font("Segoe UI", 12F);
            txtbox_contact_email.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_email.Location = new Point(188, 397);
            txtbox_contact_email.Margin = new Padding(3, 4, 3, 4);
            txtbox_contact_email.MaxLength = 100;
            txtbox_contact_email.Name = "txtbox_contact_email";
            txtbox_contact_email.Size = new Size(320, 29);
            txtbox_contact_email.TabIndex = 5;
            // 
            // lbl_supplier_city
            // 
            lbl_supplier_city.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_city.AutoSize = true;
            lbl_supplier_city.Font = new Font("Segoe UI", 12F);
            lbl_supplier_city.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_city.Location = new Point(578, 275);
            lbl_supplier_city.Name = "lbl_supplier_city";
            lbl_supplier_city.Size = new Size(113, 21);
            lbl_supplier_city.TabIndex = 12;
            lbl_supplier_city.Text = "SUPPLIER CITY";
            // 
            // lbl_supplier_state
            // 
            lbl_supplier_state.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_state.AutoSize = true;
            lbl_supplier_state.Font = new Font("Segoe UI", 12F);
            lbl_supplier_state.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_state.Location = new Point(578, 178);
            lbl_supplier_state.Name = "lbl_supplier_state";
            lbl_supplier_state.Size = new Size(123, 21);
            lbl_supplier_state.TabIndex = 13;
            lbl_supplier_state.Text = "SUPPLIER STATE";
            // 
            // lbl_supplier_country
            // 
            lbl_supplier_country.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_country.AutoSize = true;
            lbl_supplier_country.Font = new Font("Segoe UI", 12F);
            lbl_supplier_country.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_country.Location = new Point(578, 81);
            lbl_supplier_country.Name = "lbl_supplier_country";
            lbl_supplier_country.Size = new Size(154, 21);
            lbl_supplier_country.TabIndex = 14;
            lbl_supplier_country.Text = "SUPPLIER COUNTRY";
            // 
            // lbl_sm_name
            // 
            lbl_sm_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_sm_name.AutoSize = true;
            lbl_sm_name.Font = new Font("Segoe UI", 12F);
            lbl_sm_name.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_sm_name.Location = new Point(578, 368);
            lbl_sm_name.Name = "lbl_sm_name";
            lbl_sm_name.Size = new Size(81, 21);
            lbl_sm_name.TabIndex = 17;
            lbl_sm_name.Text = "SM NAME";
            // 
            // lbl_sup_name
            // 
            lbl_sup_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_sup_name.AutoSize = true;
            lbl_sup_name.Font = new Font("Segoe UI", 12F);
            lbl_sup_name.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_sup_name.Location = new Point(188, 177);
            lbl_sup_name.Name = "lbl_sup_name";
            lbl_sup_name.Size = new Size(126, 21);
            lbl_sup_name.TabIndex = 20;
            lbl_sup_name.Text = "SUPPLIER NAME";
            // 
            // lbl_contract_type
            // 
            lbl_contract_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_contract_type.AutoSize = true;
            lbl_contract_type.Font = new Font("Segoe UI", 12F);
            lbl_contract_type.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_contract_type.Location = new Point(968, 81);
            lbl_contract_type.Name = "lbl_contract_type";
            lbl_contract_type.Size = new Size(128, 21);
            lbl_contract_type.TabIndex = 21;
            lbl_contract_type.Text = "CONTRACT TYPE";
            // 
            // lbl_contact_phone
            // 
            lbl_contact_phone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_contact_phone.AutoSize = true;
            lbl_contact_phone.Font = new Font("Segoe UI", 12F);
            lbl_contact_phone.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_contact_phone.Location = new Point(188, 465);
            lbl_contact_phone.Name = "lbl_contact_phone";
            lbl_contact_phone.Size = new Size(207, 21);
            lbl_contact_phone.TabIndex = 24;
            lbl_contact_phone.Text = "SUPPLIER CONTACT PHONE";
            // 
            // txtbox_supplier_city
            // 
            txtbox_supplier_city.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_supplier_city.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_city.CharacterCasing = CharacterCasing.Upper;
            txtbox_supplier_city.Font = new Font("Segoe UI", 12F);
            txtbox_supplier_city.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_supplier_city.Location = new Point(578, 300);
            txtbox_supplier_city.Margin = new Padding(3, 4, 3, 4);
            txtbox_supplier_city.Name = "txtbox_supplier_city";
            txtbox_supplier_city.Size = new Size(320, 29);
            txtbox_supplier_city.TabIndex = 9;
            // 
            // combox_supplier_state
            // 
            combox_supplier_state.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_supplier_state.AutoCompleteMode = AutoCompleteMode.Suggest;
            combox_supplier_state.AutoCompleteSource = AutoCompleteSource.ListItems;
            combox_supplier_state.BackColor = Color.FromArgb(230, 231, 241);
            combox_supplier_state.Font = new Font("Segoe UI", 12F);
            combox_supplier_state.ForeColor = Color.FromArgb(51, 54, 62);
            combox_supplier_state.FormattingEnabled = true;
            combox_supplier_state.Items.AddRange(new object[] { "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY", "AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT" });
            combox_supplier_state.Location = new Point(578, 203);
            combox_supplier_state.Margin = new Padding(3, 4, 3, 4);
            combox_supplier_state.MaxLength = 2;
            combox_supplier_state.Name = "combox_supplier_state";
            combox_supplier_state.Size = new Size(320, 29);
            combox_supplier_state.TabIndex = 8;
            combox_supplier_state.Leave += combox_supplier_state_Leave;
            // 
            // combox_supplier_country
            // 
            combox_supplier_country.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_supplier_country.AutoCompleteMode = AutoCompleteMode.Suggest;
            combox_supplier_country.AutoCompleteSource = AutoCompleteSource.ListItems;
            combox_supplier_country.BackColor = Color.FromArgb(230, 231, 241);
            combox_supplier_country.Font = new Font("Segoe UI", 12F);
            combox_supplier_country.ForeColor = Color.FromArgb(51, 54, 62);
            combox_supplier_country.FormattingEnabled = true;
            combox_supplier_country.Location = new Point(578, 106);
            combox_supplier_country.Margin = new Padding(3, 4, 3, 4);
            combox_supplier_country.MaxLength = 100;
            combox_supplier_country.Name = "combox_supplier_country";
            combox_supplier_country.RightToLeft = RightToLeft.No;
            combox_supplier_country.Size = new Size(320, 29);
            combox_supplier_country.TabIndex = 7;
            combox_supplier_country.Leave += combox_supplier_country_Leave;
            // 
            // combox_sm_name
            // 
            combox_sm_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_sm_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            combox_sm_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            combox_sm_name.BackColor = Color.FromArgb(230, 231, 241);
            combox_sm_name.DropDownWidth = 390;
            combox_sm_name.Font = new Font("Segoe UI", 12F);
            combox_sm_name.ForeColor = Color.FromArgb(51, 54, 62);
            combox_sm_name.FormattingEnabled = true;
            combox_sm_name.Location = new Point(578, 397);
            combox_sm_name.Margin = new Padding(3, 4, 3, 4);
            combox_sm_name.Name = "combox_sm_name";
            combox_sm_name.Size = new Size(320, 29);
            combox_sm_name.TabIndex = 11;
            combox_sm_name.Leave += combox_sm_name_Leave;
            // 
            // txtbox_supplier_name
            // 
            txtbox_supplier_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_supplier_name.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_name.CharacterCasing = CharacterCasing.Upper;
            txtbox_supplier_name.Font = new Font("Segoe UI", 12F);
            txtbox_supplier_name.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_supplier_name.Location = new Point(188, 203);
            txtbox_supplier_name.Margin = new Padding(3, 4, 3, 4);
            txtbox_supplier_name.MaxLength = 100;
            txtbox_supplier_name.Name = "txtbox_supplier_name";
            txtbox_supplier_name.Size = new Size(320, 29);
            txtbox_supplier_name.TabIndex = 3;
            // 
            // combox_contract_type
            // 
            combox_contract_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_contract_type.BackColor = Color.FromArgb(230, 231, 241);
            combox_contract_type.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_contract_type.DropDownWidth = 314;
            combox_contract_type.Font = new Font("Segoe UI", 12F);
            combox_contract_type.ForeColor = Color.FromArgb(51, 54, 62);
            combox_contract_type.FormattingEnabled = true;
            combox_contract_type.Items.AddRange(new object[] { "SAL", "CREDIT PACKAGE", "PO TERMS" });
            combox_contract_type.Location = new Point(968, 106);
            combox_contract_type.Margin = new Padding(3, 4, 3, 4);
            combox_contract_type.MaxLength = 100;
            combox_contract_type.Name = "combox_contract_type";
            combox_contract_type.Size = new Size(320, 29);
            combox_contract_type.TabIndex = 14;
            // 
            // bttn_submit_profile
            // 
            bttn_submit_profile.BackColor = Color.LightSkyBlue;
            bttn_submit_profile.Cursor = Cursors.Hand;
            bttn_submit_profile.Dock = DockStyle.Right;
            bttn_submit_profile.FlatStyle = FlatStyle.Flat;
            bttn_submit_profile.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_submit_profile.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_submit_profile.Location = new Point(1371, 0);
            bttn_submit_profile.Margin = new Padding(3, 4, 3, 4);
            bttn_submit_profile.Name = "bttn_submit_profile";
            bttn_submit_profile.Size = new Size(105, 120);
            bttn_submit_profile.TabIndex = 16;
            bttn_submit_profile.Text = "SUBMIT";
            bttn_submit_profile.UseVisualStyleBackColor = false;
            bttn_submit_profile.Click += bttn_submit_profile_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(320, 173);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 45;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.SkyBlue;
            label2.Location = new Point(393, 270);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 46;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.SkyBlue;
            label3.Location = new Point(393, 365);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 47;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.ForeColor = Color.SkyBlue;
            label4.Location = new Point(401, 462);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 48;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.ForeColor = Color.SkyBlue;
            label5.Location = new Point(739, 77);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 49;
            label5.Text = "*";
            // 
            // lbl_supplier_state_ast
            // 
            lbl_supplier_state_ast.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_state_ast.AutoSize = true;
            lbl_supplier_state_ast.Font = new Font("Segoe UI", 13.8F);
            lbl_supplier_state_ast.ForeColor = Color.LightSkyBlue;
            lbl_supplier_state_ast.Location = new Point(712, 175);
            lbl_supplier_state_ast.Name = "lbl_supplier_state_ast";
            lbl_supplier_state_ast.Size = new Size(20, 25);
            lbl_supplier_state_ast.TabIndex = 50;
            lbl_supplier_state_ast.Text = "*";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.ForeColor = Color.SkyBlue;
            label7.Location = new Point(699, 271);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 51;
            label7.Text = "*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F);
            label9.ForeColor = Color.SkyBlue;
            label9.Location = new Point(665, 364);
            label9.Name = "label9";
            label9.Size = new Size(20, 25);
            label9.TabIndex = 53;
            label9.Text = "*";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F);
            label12.ForeColor = Color.SkyBlue;
            label12.Location = new Point(1102, 76);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 56;
            label12.Text = "*";
            // 
            // panel_single_request
            // 
            panel_single_request.BackColor = Color.FromArgb(51, 54, 62);
            panel_single_request.Controls.Add(label13);
            panel_single_request.Controls.Add(combox_profile);
            panel_single_request.Controls.Add(lbl_supplier_profile);
            panel_single_request.Controls.Add(bttn_submit_profile);
            panel_single_request.Dock = DockStyle.Top;
            panel_single_request.Location = new Point(0, 0);
            panel_single_request.Margin = new Padding(2);
            panel_single_request.Name = "panel_single_request";
            panel_single_request.Size = new Size(1476, 120);
            panel_single_request.TabIndex = 57;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SkyBlue;
            label13.Location = new Point(372, 21);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 58;
            label13.Text = "*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(230, 231, 241);
            label6.Location = new Point(186, 22);
            label6.Name = "label6";
            label6.Size = new Size(240, 28);
            label6.TabIndex = 58;
            label6.Text = "SUPPLIER INFORMATION";
            // 
            // panel_supplier_info
            // 
            panel_supplier_info.AutoScroll = true;
            panel_supplier_info.AutoSize = true;
            panel_supplier_info.Controls.Add(txtbox_contact_phone);
            panel_supplier_info.Controls.Add(txtbox_comments);
            panel_supplier_info.Controls.Add(lbl_comments);
            panel_supplier_info.Controls.Add(label6);
            panel_supplier_info.Controls.Add(lbl_contact_phone);
            panel_supplier_info.Controls.Add(label12);
            panel_supplier_info.Controls.Add(txtbox_spa_email);
            panel_supplier_info.Controls.Add(lbl_supplier_no);
            panel_supplier_info.Controls.Add(combox_supplier_no);
            panel_supplier_info.Controls.Add(lbl_supplier_contact_name);
            panel_supplier_info.Controls.Add(label_spa_email);
            panel_supplier_info.Controls.Add(txtbox_contact_name);
            panel_supplier_info.Controls.Add(combox_contract_type);
            panel_supplier_info.Controls.Add(lbl_supplier_state_ast);
            panel_supplier_info.Controls.Add(label5);
            panel_supplier_info.Controls.Add(label9);
            panel_supplier_info.Controls.Add(lbl_contract_type);
            panel_supplier_info.Controls.Add(lbl_supplier_email);
            panel_supplier_info.Controls.Add(txtbox_contact_email);
            panel_supplier_info.Controls.Add(label7);
            panel_supplier_info.Controls.Add(lbl_sup_name);
            panel_supplier_info.Controls.Add(txtbox_supplier_name);
            panel_supplier_info.Controls.Add(label4);
            panel_supplier_info.Controls.Add(label1);
            panel_supplier_info.Controls.Add(label3);
            panel_supplier_info.Controls.Add(combox_sm_name);
            panel_supplier_info.Controls.Add(label2);
            panel_supplier_info.Controls.Add(combox_supplier_country);
            panel_supplier_info.Controls.Add(lbl_supplier_city);
            panel_supplier_info.Controls.Add(combox_supplier_state);
            panel_supplier_info.Controls.Add(lbl_supplier_state);
            panel_supplier_info.Controls.Add(txtbox_supplier_city);
            panel_supplier_info.Controls.Add(lbl_supplier_country);
            panel_supplier_info.Controls.Add(lbl_sm_name);
            panel_supplier_info.Dock = DockStyle.Fill;
            panel_supplier_info.Location = new Point(0, 120);
            panel_supplier_info.Name = "panel_supplier_info";
            panel_supplier_info.Size = new Size(1476, 591);
            panel_supplier_info.TabIndex = 59;
            // 
            // txtbox_contact_phone
            // 
            txtbox_contact_phone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_phone.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_phone.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_phone.Font = new Font("Segoe UI", 12F);
            txtbox_contact_phone.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_phone.Location = new Point(188, 494);
            txtbox_contact_phone.Margin = new Padding(3, 4, 3, 4);
            txtbox_contact_phone.MaxLength = 100;
            txtbox_contact_phone.Name = "txtbox_contact_phone";
            txtbox_contact_phone.Size = new Size(320, 29);
            txtbox_contact_phone.TabIndex = 6;
            // 
            // txtbox_comments
            // 
            txtbox_comments.Anchor = AnchorStyles.Top;
            txtbox_comments.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_comments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_comments.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_comments.Location = new Point(968, 203);
            txtbox_comments.Multiline = true;
            txtbox_comments.Name = "txtbox_comments";
            txtbox_comments.ScrollBars = ScrollBars.Vertical;
            txtbox_comments.Size = new Size(360, 223);
            txtbox_comments.TabIndex = 15;
            // 
            // lbl_comments
            // 
            lbl_comments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_comments.AutoSize = true;
            lbl_comments.Font = new Font("Segoe UI", 12F);
            lbl_comments.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_comments.Location = new Point(968, 178);
            lbl_comments.Name = "lbl_comments";
            lbl_comments.Size = new Size(97, 21);
            lbl_comments.TabIndex = 59;
            lbl_comments.Text = "COMMENTS";
            // 
            // txtbox_spa_email
            // 
            txtbox_spa_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_spa_email.CharacterCasing = CharacterCasing.Upper;
            txtbox_spa_email.Enabled = false;
            txtbox_spa_email.Font = new Font("Segoe UI", 12F);
            txtbox_spa_email.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_spa_email.Location = new Point(578, 494);
            txtbox_spa_email.Margin = new Padding(2);
            txtbox_spa_email.Name = "txtbox_spa_email";
            txtbox_spa_email.ReadOnly = true;
            txtbox_spa_email.Size = new Size(320, 29);
            txtbox_spa_email.TabIndex = 13;
            txtbox_spa_email.Text = "SUPPLIER_ONBOARDING@GRAINGER.COM";
            // 
            // label_spa_email
            // 
            label_spa_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_spa_email.AutoSize = true;
            label_spa_email.Font = new Font("Segoe UI", 12F);
            label_spa_email.ForeColor = Color.FromArgb(230, 231, 241);
            label_spa_email.Location = new Point(578, 465);
            label_spa_email.Name = "label_spa_email";
            label_spa_email.Size = new Size(85, 21);
            label_spa_email.TabIndex = 18;
            label_spa_email.Text = "SPA EMAIL";
            // 
            // form_single_request
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(42, 45, 53);
            ClientSize = new Size(1476, 711);
            Controls.Add(panel_supplier_info);
            Controls.Add(panel_single_request);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "form_single_request";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SINGLE REQUEST FORM";
            WindowState = FormWindowState.Maximized;
            panel_single_request.ResumeLayout(false);
            panel_single_request.PerformLayout();
            panel_supplier_info.ResumeLayout(false);
            panel_supplier_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combox_profile;
        private Label lbl_supplier_profile;
        private Label lbl_supplier_no;
        private ComboBox combox_supplier_no;
        private Label lbl_supplier_contact_name;
        private TextBox txtbox_contact_name;
        private Label lbl_supplier_email;
        private TextBox txtbox_contact_email;
        private Label lbl_supplier_city;
        private Label lbl_supplier_state;
        private Label lbl_supplier_country;
        private Label lbl_sm_name;
        private Label lbl_sup_name;
        private Label lbl_contract_type;
        private Label lbl_contact_phone;
        private TextBox txtbox_supplier_city;
        private ComboBox combox_supplier_state;
        private ComboBox combox_supplier_country;
        private ComboBox combox_sm_name;
        private TextBox txtbox_supplier_name;
        private ComboBox combox_contract_type;
        private Button bttn_submit_profile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_supplier_state_ast;
        private Label label7;
        private Label label9;
        private Label label12;
        private Panel panel_single_request;
        private Label label13;
        private Label label6;
        private Panel panel_supplier_info;
        private Label lbl_comments;
        private TextBox txtbox_spa_email;
        private Label label_spa_email;
        private TextBox txtbox_comments;
        private TextBox txtbox_contact_phone;
    }
}