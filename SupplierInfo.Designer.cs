namespace ONBOARDING
{
    partial class form_supplier_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_supplier_info));
            panel_supplier_name = new Panel();
            lbl_supplier_name = new TextBox();
            img_search_icon = new PictureBox();
            txtbox_supplier_search = new TextBox();
            bttn_update_profile = new Button();
            menu_supplier_info = new MenuStrip();
            menu_action = new ToolStripMenuItem();
            action_delete_supplier = new ToolStripMenuItem();
            label12 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_asterisk = new Label();
            combox_contract_type = new ComboBox();
            txtbox_supplier_name = new TextBox();
            combox_sm_name = new ComboBox();
            combox_supplier_country = new ComboBox();
            combox_supplier_state = new ComboBox();
            txtbox_supplier_city = new TextBox();
            label_contact_phone = new Label();
            label_contract_type = new Label();
            label_sup_name = new Label();
            label_sm_name = new Label();
            label_supplier_country = new Label();
            label_supplier_state = new Label();
            label_supplier_city = new Label();
            txtbox_contact_email = new TextBox();
            label_supplier_email = new Label();
            txtbox_contact_name = new TextBox();
            label_supplier_contact_name = new Label();
            combox_status = new ComboBox();
            label_supplier_no = new Label();
            lbl_supplier_no = new Label();
            strip_supplier_info = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            strip_time = new ToolStripStatusLabel();
            strip_message = new ToolStripStatusLabel();
            panel_supplier_info = new Panel();
            txtbox_spa_email = new TextBox();
            label_spa_email = new Label();
            txtbox_comments = new TextBox();
            lbl_comments = new Label();
            txtbox_contact_phone = new TextBox();
            panel_supplier_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_search_icon).BeginInit();
            menu_supplier_info.SuspendLayout();
            strip_supplier_info.SuspendLayout();
            panel_supplier_info.SuspendLayout();
            SuspendLayout();
            // 
            // panel_supplier_name
            // 
            panel_supplier_name.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_supplier_name.BackColor = Color.FromArgb(51, 54, 62);
            panel_supplier_name.Controls.Add(lbl_supplier_name);
            panel_supplier_name.Controls.Add(img_search_icon);
            panel_supplier_name.Controls.Add(txtbox_supplier_search);
            panel_supplier_name.Controls.Add(bttn_update_profile);
            panel_supplier_name.Controls.Add(menu_supplier_info);
            panel_supplier_name.Dock = DockStyle.Top;
            panel_supplier_name.Location = new Point(0, 0);
            panel_supplier_name.Margin = new Padding(3, 2, 3, 2);
            panel_supplier_name.Name = "panel_supplier_name";
            panel_supplier_name.Size = new Size(1469, 129);
            panel_supplier_name.TabIndex = 58;
            // 
            // lbl_supplier_name
            // 
            lbl_supplier_name.BackColor = Color.FromArgb(51, 54, 62);
            lbl_supplier_name.BorderStyle = BorderStyle.None;
            lbl_supplier_name.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_supplier_name.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_name.Location = new Point(562, 46);
            lbl_supplier_name.Multiline = true;
            lbl_supplier_name.Name = "lbl_supplier_name";
            lbl_supplier_name.Size = new Size(782, 77);
            lbl_supplier_name.TabIndex = 108;
            lbl_supplier_name.Text = "SUPPLIER NAME";
            // 
            // img_search_icon
            // 
            img_search_icon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_search_icon.BackColor = Color.FromArgb(230, 231, 241);
            img_search_icon.BackgroundImage = Properties.Resources.search_icon;
            img_search_icon.BackgroundImageLayout = ImageLayout.Zoom;
            img_search_icon.Location = new Point(30, 66);
            img_search_icon.Margin = new Padding(3, 2, 3, 2);
            img_search_icon.MaximumSize = new Size(34, 29);
            img_search_icon.Name = "img_search_icon";
            img_search_icon.Size = new Size(34, 29);
            img_search_icon.TabIndex = 103;
            img_search_icon.TabStop = false;
            // 
            // txtbox_supplier_search
            // 
            txtbox_supplier_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtbox_supplier_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbox_supplier_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtbox_supplier_search.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_search.BorderStyle = BorderStyle.FixedSingle;
            txtbox_supplier_search.Cursor = Cursors.IBeam;
            txtbox_supplier_search.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_supplier_search.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_supplier_search.Location = new Point(29, 64);
            txtbox_supplier_search.Margin = new Padding(4);
            txtbox_supplier_search.MaxLength = 80;
            txtbox_supplier_search.Name = "txtbox_supplier_search";
            txtbox_supplier_search.Size = new Size(505, 34);
            txtbox_supplier_search.TabIndex = 0;
            txtbox_supplier_search.TextAlign = HorizontalAlignment.Center;
            txtbox_supplier_search.KeyDown += txtbox_supplier_search_KeyDown;
            // 
            // bttn_update_profile
            // 
            bttn_update_profile.BackColor = Color.LightSkyBlue;
            bttn_update_profile.Cursor = Cursors.Hand;
            bttn_update_profile.Dock = DockStyle.Right;
            bttn_update_profile.FlatStyle = FlatStyle.Flat;
            bttn_update_profile.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_update_profile.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_update_profile.Location = new Point(1364, 31);
            bttn_update_profile.Margin = new Padding(4);
            bttn_update_profile.Name = "bttn_update_profile";
            bttn_update_profile.Size = new Size(105, 98);
            bttn_update_profile.TabIndex = 15;
            bttn_update_profile.Text = "UPDATE";
            bttn_update_profile.UseVisualStyleBackColor = false;
            bttn_update_profile.Click += bttn_update_profile_Click;
            // 
            // menu_supplier_info
            // 
            menu_supplier_info.AutoSize = false;
            menu_supplier_info.BackColor = Color.FromArgb(32, 35, 43);
            menu_supplier_info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_supplier_info.ImageScalingSize = new Size(20, 20);
            menu_supplier_info.Items.AddRange(new ToolStripItem[] { menu_action });
            menu_supplier_info.Location = new Point(0, 0);
            menu_supplier_info.Name = "menu_supplier_info";
            menu_supplier_info.Padding = new Padding(5, 2, 0, 2);
            menu_supplier_info.Size = new Size(1469, 31);
            menu_supplier_info.TabIndex = 104;
            // 
            // menu_action
            // 
            menu_action.DropDownItems.AddRange(new ToolStripItem[] { action_delete_supplier });
            menu_action.ForeColor = Color.FromArgb(230, 231, 241);
            menu_action.Margin = new Padding(1);
            menu_action.Name = "menu_action";
            menu_action.Size = new Size(81, 25);
            menu_action.Text = "ACTION";
            // 
            // action_delete_supplier
            // 
            action_delete_supplier.ForeColor = Color.FromArgb(42, 45, 53);
            action_delete_supplier.Margin = new Padding(3);
            action_delete_supplier.Name = "action_delete_supplier";
            action_delete_supplier.Size = new Size(205, 26);
            action_delete_supplier.Text = "DELETE SUPPLIER";
            action_delete_supplier.Click += action_delete_supplier_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F);
            label12.ForeColor = Color.SkyBlue;
            label12.Location = new Point(1100, 74);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 100;
            label12.Text = "*";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F);
            label9.ForeColor = Color.SkyBlue;
            label9.Location = new Point(661, 359);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(20, 25);
            label9.TabIndex = 97;
            label9.Text = "*";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.ForeColor = Color.SkyBlue;
            label7.Location = new Point(695, 266);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 95;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.ForeColor = Color.LightSkyBlue;
            label6.Location = new Point(708, 171);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 94;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.ForeColor = Color.SkyBlue;
            label5.Location = new Point(734, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 93;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.ForeColor = Color.SkyBlue;
            label4.Location = new Point(399, 455);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 92;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.SkyBlue;
            label3.Location = new Point(391, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 91;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.SkyBlue;
            label2.Location = new Point(391, 264);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 90;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(318, 167);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 89;
            label1.Text = "*";
            // 
            // lbl_asterisk
            // 
            lbl_asterisk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_asterisk.AutoSize = true;
            lbl_asterisk.Font = new Font("Segoe UI", 13.8F);
            lbl_asterisk.ForeColor = Color.SkyBlue;
            lbl_asterisk.Location = new Point(255, 75);
            lbl_asterisk.Margin = new Padding(4, 0, 4, 0);
            lbl_asterisk.Name = "lbl_asterisk";
            lbl_asterisk.Size = new Size(20, 25);
            lbl_asterisk.TabIndex = 88;
            lbl_asterisk.Text = "*";
            // 
            // combox_contract_type
            // 
            combox_contract_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_contract_type.BackColor = Color.FromArgb(230, 231, 241);
            combox_contract_type.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_contract_type.Font = new Font("Segoe UI", 12F);
            combox_contract_type.ForeColor = Color.FromArgb(51, 54, 62);
            combox_contract_type.FormattingEnabled = true;
            combox_contract_type.Items.AddRange(new object[] { "SAL", "CREDIT PACKAGE", "PO TERMS" });
            combox_contract_type.Location = new Point(964, 105);
            combox_contract_type.Margin = new Padding(4);
            combox_contract_type.MaxLength = 100;
            combox_contract_type.Name = "combox_contract_type";
            combox_contract_type.Size = new Size(320, 29);
            combox_contract_type.TabIndex = 13;
            // 
            // txtbox_supplier_name
            // 
            txtbox_supplier_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_supplier_name.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_name.CharacterCasing = CharacterCasing.Upper;
            txtbox_supplier_name.Font = new Font("Segoe UI", 12F);
            txtbox_supplier_name.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_supplier_name.Location = new Point(184, 200);
            txtbox_supplier_name.Margin = new Padding(4);
            txtbox_supplier_name.MaxLength = 100;
            txtbox_supplier_name.Name = "txtbox_supplier_name";
            txtbox_supplier_name.Size = new Size(320, 29);
            txtbox_supplier_name.TabIndex = 2;
            // 
            // combox_sm_name
            // 
            combox_sm_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_sm_name.AutoCompleteMode = AutoCompleteMode.Suggest;
            combox_sm_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            combox_sm_name.BackColor = Color.FromArgb(230, 231, 241);
            combox_sm_name.Font = new Font("Segoe UI", 12F);
            combox_sm_name.ForeColor = Color.FromArgb(51, 54, 62);
            combox_sm_name.FormattingEnabled = true;
            combox_sm_name.Location = new Point(574, 390);
            combox_sm_name.Margin = new Padding(4);
            combox_sm_name.Name = "combox_sm_name";
            combox_sm_name.Size = new Size(320, 29);
            combox_sm_name.TabIndex = 10;
            combox_sm_name.Leave += combox_sm_name_Leave;
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
            combox_supplier_country.Location = new Point(574, 105);
            combox_supplier_country.Margin = new Padding(4);
            combox_supplier_country.Name = "combox_supplier_country";
            combox_supplier_country.Size = new Size(320, 29);
            combox_supplier_country.TabIndex = 6;
            combox_supplier_country.Leave += combox_supplier_country_Leave;
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
            combox_supplier_state.Location = new Point(576, 200);
            combox_supplier_state.Margin = new Padding(4);
            combox_supplier_state.MaxLength = 2;
            combox_supplier_state.Name = "combox_supplier_state";
            combox_supplier_state.Size = new Size(320, 29);
            combox_supplier_state.TabIndex = 7;
            combox_supplier_state.Leave += combox_supplier_state_Leave;
            // 
            // txtbox_supplier_city
            // 
            txtbox_supplier_city.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_supplier_city.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_city.CharacterCasing = CharacterCasing.Upper;
            txtbox_supplier_city.Font = new Font("Segoe UI", 12F);
            txtbox_supplier_city.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_supplier_city.Location = new Point(574, 295);
            txtbox_supplier_city.Margin = new Padding(4);
            txtbox_supplier_city.Name = "txtbox_supplier_city";
            txtbox_supplier_city.Size = new Size(320, 29);
            txtbox_supplier_city.TabIndex = 8;
            // 
            // label_contact_phone
            // 
            label_contact_phone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_contact_phone.AutoSize = true;
            label_contact_phone.Font = new Font("Segoe UI", 12F);
            label_contact_phone.ForeColor = Color.FromArgb(230, 231, 241);
            label_contact_phone.Location = new Point(184, 458);
            label_contact_phone.Margin = new Padding(4, 0, 4, 0);
            label_contact_phone.Name = "label_contact_phone";
            label_contact_phone.Size = new Size(207, 21);
            label_contact_phone.TabIndex = 87;
            label_contact_phone.Text = "SUPPLIER CONTACT PHONE";
            // 
            // label_contract_type
            // 
            label_contract_type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_contract_type.AutoSize = true;
            label_contract_type.Font = new Font("Segoe UI", 12F);
            label_contract_type.ForeColor = Color.FromArgb(230, 231, 241);
            label_contract_type.Location = new Point(964, 78);
            label_contract_type.Margin = new Padding(4, 0, 4, 0);
            label_contract_type.Name = "label_contract_type";
            label_contract_type.Size = new Size(128, 21);
            label_contract_type.TabIndex = 85;
            label_contract_type.Text = "CONTRACT TYPE";
            // 
            // label_sup_name
            // 
            label_sup_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_sup_name.AutoSize = true;
            label_sup_name.Font = new Font("Segoe UI", 12F);
            label_sup_name.ForeColor = Color.FromArgb(230, 231, 241);
            label_sup_name.Location = new Point(184, 173);
            label_sup_name.Margin = new Padding(4, 0, 4, 0);
            label_sup_name.Name = "label_sup_name";
            label_sup_name.Size = new Size(126, 21);
            label_sup_name.TabIndex = 84;
            label_sup_name.Text = "SUPPLIER NAME";
            // 
            // label_sm_name
            // 
            label_sm_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_sm_name.AutoSize = true;
            label_sm_name.Font = new Font("Segoe UI", 12F);
            label_sm_name.ForeColor = Color.FromArgb(230, 231, 241);
            label_sm_name.Location = new Point(572, 363);
            label_sm_name.Margin = new Padding(4, 0, 4, 0);
            label_sm_name.Name = "label_sm_name";
            label_sm_name.Size = new Size(81, 21);
            label_sm_name.TabIndex = 81;
            label_sm_name.Text = "SM NAME";
            // 
            // label_supplier_country
            // 
            label_supplier_country.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_country.AutoSize = true;
            label_supplier_country.Font = new Font("Segoe UI", 12F);
            label_supplier_country.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_country.Location = new Point(572, 78);
            label_supplier_country.Margin = new Padding(4, 0, 4, 0);
            label_supplier_country.Name = "label_supplier_country";
            label_supplier_country.Size = new Size(154, 21);
            label_supplier_country.TabIndex = 78;
            label_supplier_country.Text = "SUPPLIER COUNTRY";
            // 
            // label_supplier_state
            // 
            label_supplier_state.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_state.AutoSize = true;
            label_supplier_state.Font = new Font("Segoe UI", 12F);
            label_supplier_state.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_state.Location = new Point(574, 173);
            label_supplier_state.Margin = new Padding(4, 0, 4, 0);
            label_supplier_state.Name = "label_supplier_state";
            label_supplier_state.Size = new Size(123, 21);
            label_supplier_state.TabIndex = 76;
            label_supplier_state.Text = "SUPPLIER STATE";
            // 
            // label_supplier_city
            // 
            label_supplier_city.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_city.AutoSize = true;
            label_supplier_city.Font = new Font("Segoe UI", 12F);
            label_supplier_city.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_city.Location = new Point(574, 268);
            label_supplier_city.Margin = new Padding(4, 0, 4, 0);
            label_supplier_city.Name = "label_supplier_city";
            label_supplier_city.Size = new Size(113, 21);
            label_supplier_city.TabIndex = 73;
            label_supplier_city.Text = "SUPPLIER CITY";
            // 
            // txtbox_contact_email
            // 
            txtbox_contact_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_email.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_email.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_email.Font = new Font("Segoe UI", 12F);
            txtbox_contact_email.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_email.Location = new Point(184, 390);
            txtbox_contact_email.Margin = new Padding(4);
            txtbox_contact_email.Name = "txtbox_contact_email";
            txtbox_contact_email.Size = new Size(320, 29);
            txtbox_contact_email.TabIndex = 4;
            // 
            // label_supplier_email
            // 
            label_supplier_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_email.AutoSize = true;
            label_supplier_email.Font = new Font("Segoe UI", 12F);
            label_supplier_email.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_email.Location = new Point(184, 363);
            label_supplier_email.Margin = new Padding(4, 0, 4, 0);
            label_supplier_email.Name = "label_supplier_email";
            label_supplier_email.Size = new Size(199, 21);
            label_supplier_email.TabIndex = 70;
            label_supplier_email.Text = "SUPPLIER CONTACT EMAIL";
            // 
            // txtbox_contact_name
            // 
            txtbox_contact_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_name.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_name.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_name.Font = new Font("Segoe UI", 12F);
            txtbox_contact_name.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_name.Location = new Point(184, 295);
            txtbox_contact_name.Margin = new Padding(4);
            txtbox_contact_name.MaxLength = 100;
            txtbox_contact_name.Name = "txtbox_contact_name";
            txtbox_contact_name.Size = new Size(320, 29);
            txtbox_contact_name.TabIndex = 3;
            // 
            // label_supplier_contact_name
            // 
            label_supplier_contact_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_contact_name.AutoSize = true;
            label_supplier_contact_name.Font = new Font("Segoe UI", 12F);
            label_supplier_contact_name.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_contact_name.Location = new Point(184, 268);
            label_supplier_contact_name.Margin = new Padding(4, 0, 4, 0);
            label_supplier_contact_name.Name = "label_supplier_contact_name";
            label_supplier_contact_name.Size = new Size(199, 21);
            label_supplier_contact_name.TabIndex = 67;
            label_supplier_contact_name.Text = "SUPPLIER CONTACT NAME";
            // 
            // combox_status
            // 
            combox_status.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combox_status.BackColor = Color.FromArgb(230, 231, 241);
            combox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_status.Font = new Font("Segoe UI", 12F);
            combox_status.ForeColor = Color.FromArgb(51, 54, 62);
            combox_status.FormattingEnabled = true;
            combox_status.Items.AddRange(new object[] { "ONBOARDING", "SUSPENDED", "WITHDRAWN" });
            combox_status.Location = new Point(184, 105);
            combox_status.Margin = new Padding(4);
            combox_status.Name = "combox_status";
            combox_status.Size = new Size(320, 29);
            combox_status.TabIndex = 1;
            // 
            // label_supplier_no
            // 
            label_supplier_no.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_supplier_no.AutoSize = true;
            label_supplier_no.Font = new Font("Segoe UI", 12F);
            label_supplier_no.ForeColor = Color.FromArgb(230, 231, 241);
            label_supplier_no.Location = new Point(184, 78);
            label_supplier_no.Margin = new Padding(4, 0, 4, 0);
            label_supplier_no.Name = "label_supplier_no";
            label_supplier_no.Size = new Size(63, 21);
            label_supplier_no.TabIndex = 64;
            label_supplier_no.Text = "STATUS";
            // 
            // lbl_supplier_no
            // 
            lbl_supplier_no.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_supplier_no.AutoSize = true;
            lbl_supplier_no.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_supplier_no.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_no.Location = new Point(184, 21);
            lbl_supplier_no.Margin = new Padding(4, 0, 4, 0);
            lbl_supplier_no.Name = "lbl_supplier_no";
            lbl_supplier_no.Size = new Size(186, 28);
            lbl_supplier_no.TabIndex = 62;
            lbl_supplier_no.Text = "SUPPLIER NUMBER";
            // 
            // strip_supplier_info
            // 
            strip_supplier_info.BackColor = Color.FromArgb(32, 35, 43);
            strip_supplier_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strip_supplier_info.ImageScalingSize = new Size(20, 20);
            strip_supplier_info.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, strip_time, strip_message });
            strip_supplier_info.Location = new Point(0, 670);
            strip_supplier_info.Name = "strip_supplier_info";
            strip_supplier_info.Padding = new Padding(1, 0, 12, 0);
            strip_supplier_info.Size = new Size(1469, 31);
            strip_supplier_info.TabIndex = 101;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = Properties.Resources.grainger_logo;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Margin = new Padding(2);
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Padding = new Padding(3);
            toolStripSplitButton1.Size = new Size(42, 27);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // strip_time
            // 
            strip_time.ForeColor = Color.FromArgb(230, 231, 241);
            strip_time.Margin = new Padding(2);
            strip_time.Name = "strip_time";
            strip_time.Padding = new Padding(3);
            strip_time.Size = new Size(76, 27);
            strip_time.Text = "00:00:00";
            // 
            // strip_message
            // 
            strip_message.ForeColor = Color.FromArgb(230, 231, 241);
            strip_message.Margin = new Padding(2);
            strip_message.Name = "strip_message";
            strip_message.Padding = new Padding(3);
            strip_message.Size = new Size(294, 27);
            strip_message.Text = "WELCOME TO SUPPLIER INFO  ( ˶°ㅁ°) !!";
            // 
            // panel_supplier_info
            // 
            panel_supplier_info.AutoScroll = true;
            panel_supplier_info.AutoSize = true;
            panel_supplier_info.Controls.Add(txtbox_contact_phone);
            panel_supplier_info.Controls.Add(txtbox_spa_email);
            panel_supplier_info.Controls.Add(label_spa_email);
            panel_supplier_info.Controls.Add(txtbox_comments);
            panel_supplier_info.Controls.Add(lbl_comments);
            panel_supplier_info.Controls.Add(label9);
            panel_supplier_info.Controls.Add(label7);
            panel_supplier_info.Controls.Add(label12);
            panel_supplier_info.Controls.Add(label6);
            panel_supplier_info.Controls.Add(label_contract_type);
            panel_supplier_info.Controls.Add(label5);
            panel_supplier_info.Controls.Add(label4);
            panel_supplier_info.Controls.Add(label3);
            panel_supplier_info.Controls.Add(label2);
            panel_supplier_info.Controls.Add(combox_contract_type);
            panel_supplier_info.Controls.Add(label1);
            panel_supplier_info.Controls.Add(combox_sm_name);
            panel_supplier_info.Controls.Add(lbl_asterisk);
            panel_supplier_info.Controls.Add(lbl_supplier_no);
            panel_supplier_info.Controls.Add(label_supplier_no);
            panel_supplier_info.Controls.Add(txtbox_supplier_name);
            panel_supplier_info.Controls.Add(combox_status);
            panel_supplier_info.Controls.Add(label_supplier_contact_name);
            panel_supplier_info.Controls.Add(txtbox_contact_name);
            panel_supplier_info.Controls.Add(combox_supplier_country);
            panel_supplier_info.Controls.Add(label_supplier_email);
            panel_supplier_info.Controls.Add(combox_supplier_state);
            panel_supplier_info.Controls.Add(txtbox_contact_email);
            panel_supplier_info.Controls.Add(txtbox_supplier_city);
            panel_supplier_info.Controls.Add(label_supplier_city);
            panel_supplier_info.Controls.Add(label_contact_phone);
            panel_supplier_info.Controls.Add(label_supplier_state);
            panel_supplier_info.Controls.Add(label_sup_name);
            panel_supplier_info.Controls.Add(label_supplier_country);
            panel_supplier_info.Controls.Add(label_sm_name);
            panel_supplier_info.Dock = DockStyle.Fill;
            panel_supplier_info.Location = new Point(0, 129);
            panel_supplier_info.Name = "panel_supplier_info";
            panel_supplier_info.Size = new Size(1469, 541);
            panel_supplier_info.TabIndex = 102;
            // 
            // txtbox_spa_email
            // 
            txtbox_spa_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_spa_email.CharacterCasing = CharacterCasing.Upper;
            txtbox_spa_email.Font = new Font("Segoe UI", 12F);
            txtbox_spa_email.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_spa_email.Location = new Point(574, 485);
            txtbox_spa_email.Margin = new Padding(2);
            txtbox_spa_email.Name = "txtbox_spa_email";
            txtbox_spa_email.Size = new Size(320, 29);
            txtbox_spa_email.TabIndex = 106;
            // 
            // label_spa_email
            // 
            label_spa_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_spa_email.AutoSize = true;
            label_spa_email.Font = new Font("Segoe UI", 12F);
            label_spa_email.ForeColor = Color.FromArgb(230, 231, 241);
            label_spa_email.Location = new Point(572, 458);
            label_spa_email.Name = "label_spa_email";
            label_spa_email.Size = new Size(85, 21);
            label_spa_email.TabIndex = 107;
            label_spa_email.Text = "SPA EMAIL";
            // 
            // txtbox_comments
            // 
            txtbox_comments.Anchor = AnchorStyles.Top;
            txtbox_comments.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_comments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_comments.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_comments.Location = new Point(964, 200);
            txtbox_comments.Multiline = true;
            txtbox_comments.Name = "txtbox_comments";
            txtbox_comments.ScrollBars = ScrollBars.Vertical;
            txtbox_comments.Size = new Size(360, 219);
            txtbox_comments.TabIndex = 14;
            // 
            // lbl_comments
            // 
            lbl_comments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_comments.AutoSize = true;
            lbl_comments.Font = new Font("Segoe UI", 12F);
            lbl_comments.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_comments.Location = new Point(964, 173);
            lbl_comments.Margin = new Padding(4, 0, 4, 0);
            lbl_comments.Name = "lbl_comments";
            lbl_comments.Size = new Size(97, 21);
            lbl_comments.TabIndex = 101;
            lbl_comments.Text = "COMMENTS";
            // 
            // txtbox_contact_phone
            // 
            txtbox_contact_phone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbox_contact_phone.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_contact_phone.CharacterCasing = CharacterCasing.Upper;
            txtbox_contact_phone.Font = new Font("Segoe UI", 12F);
            txtbox_contact_phone.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_contact_phone.Location = new Point(184, 485);
            txtbox_contact_phone.Margin = new Padding(4);
            txtbox_contact_phone.Name = "txtbox_contact_phone";
            txtbox_contact_phone.Size = new Size(320, 29);
            txtbox_contact_phone.TabIndex = 5;
            // 
            // form_supplier_info
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(42, 45, 53);
            ClientSize = new Size(1469, 701);
            Controls.Add(panel_supplier_info);
            Controls.Add(strip_supplier_info);
            Controls.Add(panel_supplier_name);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_supplier_info;
            Margin = new Padding(3, 2, 3, 2);
            Name = "form_supplier_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUPPLIER INFORMATION";
            WindowState = FormWindowState.Maximized;
            panel_supplier_name.ResumeLayout(false);
            panel_supplier_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_search_icon).EndInit();
            menu_supplier_info.ResumeLayout(false);
            menu_supplier_info.PerformLayout();
            strip_supplier_info.ResumeLayout(false);
            strip_supplier_info.PerformLayout();
            panel_supplier_info.ResumeLayout(false);
            panel_supplier_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_supplier_name;
        private Button bttn_update_profile;
        private Label label12;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbl_asterisk;
        private ComboBox combox_contract_type;
        private TextBox txtbox_supplier_name;
        private ComboBox combox_sm_name;
        private ComboBox combox_supplier_country;
        private ComboBox combox_supplier_state;
        private TextBox txtbox_supplier_city;
        private Label label_contact_phone;
        private Label label_contract_type;
        private Label label_sup_name;
        private Label label_sm_name;
        private Label label_supplier_country;
        private Label label_supplier_state;
        private Label label_supplier_city;
        private TextBox txtbox_contact_email;
        private Label label_supplier_email;
        private TextBox txtbox_contact_name;
        private Label label_supplier_contact_name;
        private ComboBox combox_status;
        private Label label_supplier_no;
        private Label lbl_supplier_no;
        private PictureBox img_search_icon;
        private TextBox txtbox_supplier_search;
        private MenuStrip menu_supplier_info;
        private ToolStripMenuItem menu_action;
        private ToolStripMenuItem action_delete_supplier;
        private StatusStrip strip_supplier_info;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel strip_message;
        private ToolStripStatusLabel strip_time;
        private Panel panel_supplier_info;
        private Label lbl_comments;
        private TextBox txtbox_comments;
        private TextBox txtbox_spa_email;
        private Label label_spa_email;
        private TextBox lbl_supplier_name;
        private TextBox txtbox_contact_phone;
    }
}