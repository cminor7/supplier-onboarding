namespace ONBOARDING
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            bttn_refresh_tables = new Button();
            bttn_single_request = new Button();
            panel_main_menu = new Panel();
            bttn_email_info = new Button();
            bttn_supplier_info = new Button();
            bttn_supplier_task = new Button();
            lbl_new_supplier = new Label();
            lbl_onboarding_tasks = new Label();
            img_cats_in_box = new PictureBox();
            menu_main = new MenuStrip();
            menu_action = new ToolStripMenuItem();
            action_add_supplier_number = new ToolStripMenuItem();
            action_add_ggs_supplier_number = new ToolStripMenuItem();
            menu_report = new ToolStripMenuItem();
            report_power_bi = new ToolStripMenuItem();
            menu_help = new ToolStripMenuItem();
            help_manual = new ToolStripMenuItem();
            panel1 = new Panel();
            txtbox_version = new TextBox();
            panel_main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_cats_in_box).BeginInit();
            menu_main.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttn_refresh_tables
            // 
            bttn_refresh_tables.BackColor = Color.SkyBlue;
            bttn_refresh_tables.BackgroundImageLayout = ImageLayout.Zoom;
            bttn_refresh_tables.Cursor = Cursors.Hand;
            bttn_refresh_tables.FlatAppearance.BorderSize = 0;
            bttn_refresh_tables.FlatStyle = FlatStyle.Flat;
            bttn_refresh_tables.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_refresh_tables.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_refresh_tables.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_refresh_tables.Location = new Point(47, 180);
            bttn_refresh_tables.Margin = new Padding(4);
            bttn_refresh_tables.Name = "bttn_refresh_tables";
            bttn_refresh_tables.Size = new Size(225, 52);
            bttn_refresh_tables.TabIndex = 1;
            bttn_refresh_tables.Text = "REFRESH TABLES";
            bttn_refresh_tables.TextAlign = ContentAlignment.MiddleLeft;
            bttn_refresh_tables.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_refresh_tables.UseVisualStyleBackColor = false;
            bttn_refresh_tables.Click += bttn_refresh_tables_Click;
            // 
            // bttn_single_request
            // 
            bttn_single_request.BackColor = Color.SkyBlue;
            bttn_single_request.Cursor = Cursors.Hand;
            bttn_single_request.FlatAppearance.BorderSize = 0;
            bttn_single_request.FlatStyle = FlatStyle.Flat;
            bttn_single_request.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_single_request.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_single_request.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_single_request.ImageIndex = 0;
            bttn_single_request.Location = new Point(46, 338);
            bttn_single_request.Name = "bttn_single_request";
            bttn_single_request.Size = new Size(225, 52);
            bttn_single_request.TabIndex = 0;
            bttn_single_request.Text = "REQUEST FORM";
            bttn_single_request.TextAlign = ContentAlignment.MiddleLeft;
            bttn_single_request.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_single_request.UseVisualStyleBackColor = false;
            bttn_single_request.Click += Single_Request_Click;
            // 
            // panel_main_menu
            // 
            panel_main_menu.AutoScroll = true;
            panel_main_menu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_main_menu.BackColor = Color.FromArgb(51, 54, 62);
            panel_main_menu.Controls.Add(bttn_email_info);
            panel_main_menu.Controls.Add(bttn_supplier_info);
            panel_main_menu.Controls.Add(bttn_supplier_task);
            panel_main_menu.Controls.Add(lbl_new_supplier);
            panel_main_menu.Controls.Add(bttn_single_request);
            panel_main_menu.Controls.Add(bttn_refresh_tables);
            panel_main_menu.Controls.Add(lbl_onboarding_tasks);
            panel_main_menu.Dock = DockStyle.Left;
            panel_main_menu.Location = new Point(0, 31);
            panel_main_menu.Name = "panel_main_menu";
            panel_main_menu.Size = new Size(321, 670);
            panel_main_menu.TabIndex = 11;
            // 
            // bttn_email_info
            // 
            bttn_email_info.BackColor = Color.SkyBlue;
            bttn_email_info.Cursor = Cursors.Hand;
            bttn_email_info.FlatAppearance.BorderSize = 0;
            bttn_email_info.FlatStyle = FlatStyle.Flat;
            bttn_email_info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_email_info.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_email_info.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_email_info.ImageIndex = 0;
            bttn_email_info.Location = new Point(46, 506);
            bttn_email_info.Name = "bttn_email_info";
            bttn_email_info.Size = new Size(225, 52);
            bttn_email_info.TabIndex = 20;
            bttn_email_info.Text = "EMAIL INFO";
            bttn_email_info.TextAlign = ContentAlignment.MiddleLeft;
            bttn_email_info.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_email_info.UseVisualStyleBackColor = false;
            bttn_email_info.Click += bttn_email_info_Click;
            // 
            // bttn_supplier_info
            // 
            bttn_supplier_info.BackColor = Color.SkyBlue;
            bttn_supplier_info.Cursor = Cursors.Hand;
            bttn_supplier_info.FlatAppearance.BorderSize = 0;
            bttn_supplier_info.FlatStyle = FlatStyle.Flat;
            bttn_supplier_info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_supplier_info.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_supplier_info.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_supplier_info.ImageIndex = 0;
            bttn_supplier_info.Location = new Point(46, 422);
            bttn_supplier_info.Name = "bttn_supplier_info";
            bttn_supplier_info.Size = new Size(225, 52);
            bttn_supplier_info.TabIndex = 19;
            bttn_supplier_info.Text = "SUPPLIER INFO";
            bttn_supplier_info.TextAlign = ContentAlignment.MiddleLeft;
            bttn_supplier_info.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_supplier_info.UseVisualStyleBackColor = false;
            bttn_supplier_info.Click += bttn_supplier_info_Click;
            // 
            // bttn_supplier_task
            // 
            bttn_supplier_task.BackColor = Color.SkyBlue;
            bttn_supplier_task.BackgroundImageLayout = ImageLayout.Zoom;
            bttn_supplier_task.Cursor = Cursors.Hand;
            bttn_supplier_task.FlatAppearance.BorderSize = 0;
            bttn_supplier_task.FlatStyle = FlatStyle.Flat;
            bttn_supplier_task.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_supplier_task.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_supplier_task.ImageAlign = ContentAlignment.MiddleLeft;
            bttn_supplier_task.Location = new Point(46, 97);
            bttn_supplier_task.Margin = new Padding(4);
            bttn_supplier_task.Name = "bttn_supplier_task";
            bttn_supplier_task.Size = new Size(225, 52);
            bttn_supplier_task.TabIndex = 18;
            bttn_supplier_task.Text = "SUPPLIER TASKS";
            bttn_supplier_task.TextAlign = ContentAlignment.MiddleLeft;
            bttn_supplier_task.TextImageRelation = TextImageRelation.ImageBeforeText;
            bttn_supplier_task.UseVisualStyleBackColor = false;
            bttn_supplier_task.Click += bttn_supplier_task_Click;
            // 
            // lbl_new_supplier
            // 
            lbl_new_supplier.AutoSize = true;
            lbl_new_supplier.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_new_supplier.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_new_supplier.Location = new Point(47, 280);
            lbl_new_supplier.Name = "lbl_new_supplier";
            lbl_new_supplier.Size = new Size(170, 30);
            lbl_new_supplier.TabIndex = 13;
            lbl_new_supplier.Text = "NEW SUPPLIER";
            // 
            // lbl_onboarding_tasks
            // 
            lbl_onboarding_tasks.AutoSize = true;
            lbl_onboarding_tasks.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_onboarding_tasks.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_onboarding_tasks.Location = new Point(43, 39);
            lbl_onboarding_tasks.Name = "lbl_onboarding_tasks";
            lbl_onboarding_tasks.Size = new Size(233, 30);
            lbl_onboarding_tasks.TabIndex = 12;
            lbl_onboarding_tasks.Text = "ONBOARDING TASKS";
            // 
            // img_cats_in_box
            // 
            img_cats_in_box.Anchor = AnchorStyles.Top;
            img_cats_in_box.Image = Properties.Resources.cats_in_box;
            img_cats_in_box.Location = new Point(215, 170);
            img_cats_in_box.Name = "img_cats_in_box";
            img_cats_in_box.Size = new Size(533, 400);
            img_cats_in_box.SizeMode = PictureBoxSizeMode.Zoom;
            img_cats_in_box.TabIndex = 12;
            img_cats_in_box.TabStop = false;
            // 
            // menu_main
            // 
            menu_main.BackColor = Color.FromArgb(32, 35, 43);
            menu_main.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_main.Items.AddRange(new ToolStripItem[] { menu_action, menu_report, menu_help });
            menu_main.Location = new Point(0, 0);
            menu_main.Name = "menu_main";
            menu_main.RightToLeft = RightToLeft.No;
            menu_main.Size = new Size(1284, 31);
            menu_main.TabIndex = 18;
            // 
            // menu_action
            // 
            menu_action.DropDownItems.AddRange(new ToolStripItem[] { action_add_supplier_number, action_add_ggs_supplier_number });
            menu_action.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_action.ForeColor = Color.FromArgb(230, 231, 241);
            menu_action.Margin = new Padding(1);
            menu_action.Name = "menu_action";
            menu_action.Size = new Size(81, 25);
            menu_action.Text = "ACTION";
            // 
            // action_add_supplier_number
            // 
            action_add_supplier_number.Margin = new Padding(3);
            action_add_supplier_number.Name = "action_add_supplier_number";
            action_add_supplier_number.ShowShortcutKeys = false;
            action_add_supplier_number.Size = new Size(281, 26);
            action_add_supplier_number.Text = "ADD SUPPLIER NUMBER";
            action_add_supplier_number.Click += action_add_supplier_number_Click;
            // 
            // action_add_ggs_supplier_number
            // 
            action_add_ggs_supplier_number.BackColor = SystemColors.Control;
            action_add_ggs_supplier_number.Margin = new Padding(3);
            action_add_ggs_supplier_number.Name = "action_add_ggs_supplier_number";
            action_add_ggs_supplier_number.ShowShortcutKeys = false;
            action_add_ggs_supplier_number.Size = new Size(281, 26);
            action_add_ggs_supplier_number.Text = "ADD GGS SUPPLIER NUMBER";
            action_add_ggs_supplier_number.Click += action_add_ggs_supplier_number_Click;
            // 
            // menu_report
            // 
            menu_report.DropDownItems.AddRange(new ToolStripItem[] { report_power_bi });
            menu_report.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_report.ForeColor = Color.FromArgb(230, 231, 241);
            menu_report.Margin = new Padding(1);
            menu_report.Name = "menu_report";
            menu_report.Size = new Size(80, 25);
            menu_report.Text = "REPORT";
            // 
            // report_power_bi
            // 
            report_power_bi.Margin = new Padding(3);
            report_power_bi.Name = "report_power_bi";
            report_power_bi.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
            report_power_bi.Size = new Size(254, 26);
            report_power_bi.Text = "POWER BI";
            report_power_bi.Click += report_power_bi_Click;
            // 
            // menu_help
            // 
            menu_help.DropDownItems.AddRange(new ToolStripItem[] { help_manual });
            menu_help.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_help.ForeColor = Color.FromArgb(230, 231, 241);
            menu_help.Margin = new Padding(1);
            menu_help.Name = "menu_help";
            menu_help.Size = new Size(59, 25);
            menu_help.Text = "HELP";
            // 
            // help_manual
            // 
            help_manual.Margin = new Padding(3);
            help_manual.Name = "help_manual";
            help_manual.ShortcutKeys = Keys.Control | Keys.H;
            help_manual.Size = new Size(207, 26);
            help_manual.Text = "MANUAL";
            help_manual.Click += help_manual_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(txtbox_version);
            panel1.Controls.Add(img_cats_in_box);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(321, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 670);
            panel1.TabIndex = 19;
            // 
            // txtbox_version
            // 
            txtbox_version.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtbox_version.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_version.BorderStyle = BorderStyle.None;
            txtbox_version.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbox_version.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_version.Location = new Point(850, 602);
            txtbox_version.Name = "txtbox_version";
            txtbox_version.Size = new Size(65, 29);
            txtbox_version.TabIndex = 18;
            txtbox_version.Text = "v1.3.2";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(42, 45, 53);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1284, 701);
            Controls.Add(panel1);
            Controls.Add(panel_main_menu);
            Controls.Add(menu_main);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_main;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUPPLIER ONBOARDING";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            panel_main_menu.ResumeLayout(false);
            panel_main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_cats_in_box).EndInit();
            menu_main.ResumeLayout(false);
            menu_main.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bttn_refresh_tables;
        private Button bttn_single_request;
        private Panel panel_main_menu;
        private Label lbl_onboarding_tasks;
        private Label lbl_new_supplier;
        private PictureBox img_cats_in_box;
        private Button bttn_supplier_task;
        private Button bttn_supplier_info;
        private MenuStrip menu_main;
        private ToolStripMenuItem menu_action;
        private ToolStripMenuItem action_add_supplier_number;
        private ToolStripMenuItem action_add_ggs_supplier_number;
        private ToolStripMenuItem menu_help;
        private ToolStripMenuItem menu_report;
        private ToolStripMenuItem report_power_bi;
        private ToolStripMenuItem help_manual;
        private Panel panel1;
        private TextBox txtbox_version;
        private Button bttn_email_info;
    }
}