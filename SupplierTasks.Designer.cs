namespace ONBOARDING
{
    partial class form_supplier_tasks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_supplier_tasks));
            lbl_sup_profile = new Label();
            lbl_contract_type = new Label();
            lbl_sup_name = new Label();
            lbl_supplier_notes = new Label();
            dgv_tasks = new DataGridView();
            txtbox_supplier_search = new TextBox();
            img_search_icon = new PictureBox();
            menu_supplier_tasks = new MenuStrip();
            menu_action = new ToolStripMenuItem();
            action_reset_tasks = new ToolStripMenuItem();
            strip_supplier_tasks = new StatusStrip();
            strip_button = new ToolStripSplitButton();
            strip_time = new ToolStripStatusLabel();
            strip_status = new ToolStripStatusLabel();
            strip_message = new ToolStripStatusLabel();
            panel_supplier_tasks_top = new Panel();
            txtbox_supplier_notes = new TextBox();
            txtbox_contract_type = new TextBox();
            txtbox_sup_profile = new TextBox();
            panel_supplier_tasks_bottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_tasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_search_icon).BeginInit();
            menu_supplier_tasks.SuspendLayout();
            strip_supplier_tasks.SuspendLayout();
            panel_supplier_tasks_top.SuspendLayout();
            panel_supplier_tasks_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_sup_profile
            // 
            lbl_sup_profile.AutoSize = true;
            lbl_sup_profile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_sup_profile.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_sup_profile.Location = new Point(45, 91);
            lbl_sup_profile.Margin = new Padding(1, 0, 1, 0);
            lbl_sup_profile.Name = "lbl_sup_profile";
            lbl_sup_profile.Size = new Size(143, 21);
            lbl_sup_profile.TabIndex = 3;
            lbl_sup_profile.Text = "SUPPLIER PROFILE";
            // 
            // lbl_contract_type
            // 
            lbl_contract_type.AutoSize = true;
            lbl_contract_type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_contract_type.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_contract_type.Location = new Point(45, 144);
            lbl_contract_type.Margin = new Padding(1, 0, 1, 0);
            lbl_contract_type.Name = "lbl_contract_type";
            lbl_contract_type.Size = new Size(132, 21);
            lbl_contract_type.TabIndex = 5;
            lbl_contract_type.Text = "CONTRACT TYPE";
            // 
            // lbl_sup_name
            // 
            lbl_sup_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sup_name.AutoSize = true;
            lbl_sup_name.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sup_name.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_sup_name.Location = new Point(594, 25);
            lbl_sup_name.Margin = new Padding(1, 0, 1, 0);
            lbl_sup_name.Name = "lbl_sup_name";
            lbl_sup_name.Size = new Size(167, 28);
            lbl_sup_name.TabIndex = 7;
            lbl_sup_name.Text = "SUPPLIER NAME";
            // 
            // lbl_supplier_notes
            // 
            lbl_supplier_notes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_supplier_notes.AutoSize = true;
            lbl_supplier_notes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_supplier_notes.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_supplier_notes.Location = new Point(594, 74);
            lbl_supplier_notes.Margin = new Padding(1, 0, 1, 0);
            lbl_supplier_notes.Name = "lbl_supplier_notes";
            lbl_supplier_notes.Size = new Size(132, 21);
            lbl_supplier_notes.TabIndex = 16;
            lbl_supplier_notes.Text = "SUPPLIER NOTES";
            // 
            // dgv_tasks
            // 
            dgv_tasks.AccessibleRole = AccessibleRole.None;
            dgv_tasks.AllowUserToAddRows = false;
            dgv_tasks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 54, 62);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 231, 241);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 54, 62);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_tasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tasks.BackgroundColor = Color.FromArgb(42, 45, 53);
            dgv_tasks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(230, 231, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(42, 45, 53);
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(42, 45, 53);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_tasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tasks.Dock = DockStyle.Fill;
            dgv_tasks.GridColor = Color.DimGray;
            dgv_tasks.Location = new Point(0, 0);
            dgv_tasks.Margin = new Padding(2);
            dgv_tasks.Name = "dgv_tasks";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(230, 231, 241);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 54, 62);
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 54, 62);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_tasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_tasks.RowHeadersVisible = false;
            dgv_tasks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(42, 45, 53);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 231, 241);
            dataGridViewCellStyle4.Padding = new Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(51, 54, 62);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_tasks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_tasks.RowTemplate.Height = 80;
            dgv_tasks.RowTemplate.Resizable = DataGridViewTriState.True;
            dgv_tasks.Size = new Size(1284, 445);
            dgv_tasks.TabIndex = 1;
            dgv_tasks.CellClick += dgv_tasks_CellClick;
            dgv_tasks.CellValueChanged += dgv_tasks_CellValueChanged;
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
            txtbox_supplier_search.Location = new Point(29, 26);
            txtbox_supplier_search.Margin = new Padding(4);
            txtbox_supplier_search.MaxLength = 80;
            txtbox_supplier_search.Name = "txtbox_supplier_search";
            txtbox_supplier_search.Size = new Size(525, 34);
            txtbox_supplier_search.TabIndex = 0;
            txtbox_supplier_search.TextAlign = HorizontalAlignment.Center;
            txtbox_supplier_search.KeyDown += txtbox_supplier_search_KeyDown;
            // 
            // img_search_icon
            // 
            img_search_icon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_search_icon.BackColor = Color.FromArgb(230, 231, 241);
            img_search_icon.BackgroundImage = Properties.Resources.search_icon;
            img_search_icon.BackgroundImageLayout = ImageLayout.Zoom;
            img_search_icon.Location = new Point(30, 28);
            img_search_icon.Margin = new Padding(3, 2, 3, 2);
            img_search_icon.MaximumSize = new Size(31, 29);
            img_search_icon.Name = "img_search_icon";
            img_search_icon.Size = new Size(31, 29);
            img_search_icon.TabIndex = 37;
            img_search_icon.TabStop = false;
            // 
            // menu_supplier_tasks
            // 
            menu_supplier_tasks.BackColor = Color.FromArgb(32, 35, 43);
            menu_supplier_tasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_supplier_tasks.ImageScalingSize = new Size(20, 20);
            menu_supplier_tasks.Items.AddRange(new ToolStripItem[] { menu_action });
            menu_supplier_tasks.Location = new Point(0, 0);
            menu_supplier_tasks.Name = "menu_supplier_tasks";
            menu_supplier_tasks.Padding = new Padding(5, 2, 0, 2);
            menu_supplier_tasks.RightToLeft = RightToLeft.No;
            menu_supplier_tasks.Size = new Size(1284, 31);
            menu_supplier_tasks.TabIndex = 40;
            // 
            // menu_action
            // 
            menu_action.DropDownItems.AddRange(new ToolStripItem[] { action_reset_tasks });
            menu_action.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu_action.ForeColor = Color.FromArgb(230, 231, 241);
            menu_action.Margin = new Padding(1);
            menu_action.Name = "menu_action";
            menu_action.Size = new Size(81, 25);
            menu_action.Text = "ACTION";
            // 
            // action_reset_tasks
            // 
            action_reset_tasks.BackColor = Color.FromArgb(230, 231, 241);
            action_reset_tasks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            action_reset_tasks.ForeColor = Color.FromArgb(42, 45, 53);
            action_reset_tasks.Margin = new Padding(3);
            action_reset_tasks.Name = "action_reset_tasks";
            action_reset_tasks.RightToLeft = RightToLeft.No;
            action_reset_tasks.Size = new Size(175, 26);
            action_reset_tasks.Text = "RESET TASKS";
            action_reset_tasks.TextAlign = ContentAlignment.MiddleLeft;
            action_reset_tasks.Click += action_reset_tasks_Click;
            // 
            // strip_supplier_tasks
            // 
            strip_supplier_tasks.BackColor = Color.FromArgb(32, 35, 43);
            strip_supplier_tasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strip_supplier_tasks.ImageScalingSize = new Size(20, 20);
            strip_supplier_tasks.Items.AddRange(new ToolStripItem[] { strip_button, strip_time, strip_status, strip_message });
            strip_supplier_tasks.Location = new Point(0, 670);
            strip_supplier_tasks.Margin = new Padding(2);
            strip_supplier_tasks.Name = "strip_supplier_tasks";
            strip_supplier_tasks.Padding = new Padding(1, 0, 12, 0);
            strip_supplier_tasks.Size = new Size(1284, 31);
            strip_supplier_tasks.TabIndex = 41;
            // 
            // strip_button
            // 
            strip_button.Image = (Image)resources.GetObject("strip_button.Image");
            strip_button.ImageTransparentColor = Color.Magenta;
            strip_button.Margin = new Padding(2);
            strip_button.Name = "strip_button";
            strip_button.Padding = new Padding(3);
            strip_button.Size = new Size(42, 27);
            strip_button.TextAlign = ContentAlignment.MiddleLeft;
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
            // strip_status
            // 
            strip_status.ForeColor = Color.FromArgb(230, 231, 241);
            strip_status.Margin = new Padding(2);
            strip_status.Name = "strip_status";
            strip_status.Padding = new Padding(3);
            strip_status.RightToLeft = RightToLeft.No;
            strip_status.Size = new Size(69, 27);
            strip_status.Text = "STATUS";
            // 
            // strip_message
            // 
            strip_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strip_message.ForeColor = Color.FromArgb(230, 231, 241);
            strip_message.Margin = new Padding(2);
            strip_message.Name = "strip_message";
            strip_message.Padding = new Padding(3);
            strip_message.Size = new Size(285, 27);
            strip_message.Text = "WELCOME TO THE TASK LIST  ( ˶°ㅁ°) !!";
            // 
            // panel_supplier_tasks_top
            // 
            panel_supplier_tasks_top.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_supplier_tasks_top.Controls.Add(txtbox_supplier_notes);
            panel_supplier_tasks_top.Controls.Add(txtbox_contract_type);
            panel_supplier_tasks_top.Controls.Add(txtbox_sup_profile);
            panel_supplier_tasks_top.Controls.Add(lbl_sup_profile);
            panel_supplier_tasks_top.Controls.Add(lbl_contract_type);
            panel_supplier_tasks_top.Controls.Add(img_search_icon);
            panel_supplier_tasks_top.Controls.Add(txtbox_supplier_search);
            panel_supplier_tasks_top.Controls.Add(lbl_supplier_notes);
            panel_supplier_tasks_top.Controls.Add(lbl_sup_name);
            panel_supplier_tasks_top.Dock = DockStyle.Top;
            panel_supplier_tasks_top.Location = new Point(0, 31);
            panel_supplier_tasks_top.Margin = new Padding(3, 2, 3, 2);
            panel_supplier_tasks_top.Name = "panel_supplier_tasks_top";
            panel_supplier_tasks_top.Size = new Size(1284, 194);
            panel_supplier_tasks_top.TabIndex = 42;
            // 
            // txtbox_supplier_notes
            // 
            txtbox_supplier_notes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_supplier_notes.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_supplier_notes.BorderStyle = BorderStyle.None;
            txtbox_supplier_notes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_supplier_notes.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_supplier_notes.Location = new Point(730, 74);
            txtbox_supplier_notes.Multiline = true;
            txtbox_supplier_notes.Name = "txtbox_supplier_notes";
            txtbox_supplier_notes.Size = new Size(532, 101);
            txtbox_supplier_notes.TabIndex = 109;
            txtbox_supplier_notes.Text = "placeholder notes";
            // 
            // txtbox_contract_type
            // 
            txtbox_contract_type.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_contract_type.BorderStyle = BorderStyle.None;
            txtbox_contract_type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_contract_type.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_contract_type.Location = new Point(208, 144);
            txtbox_contract_type.Margin = new Padding(3, 2, 3, 2);
            txtbox_contract_type.Name = "txtbox_contract_type";
            txtbox_contract_type.Size = new Size(168, 22);
            txtbox_contract_type.TabIndex = 6;
            txtbox_contract_type.Text = "placeholder contract";
            // 
            // txtbox_sup_profile
            // 
            txtbox_sup_profile.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_sup_profile.BorderStyle = BorderStyle.None;
            txtbox_sup_profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_sup_profile.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_sup_profile.Location = new Point(208, 91);
            txtbox_sup_profile.Margin = new Padding(3, 2, 3, 2);
            txtbox_sup_profile.Name = "txtbox_sup_profile";
            txtbox_sup_profile.Size = new Size(168, 22);
            txtbox_sup_profile.TabIndex = 4;
            txtbox_sup_profile.Text = "placeholder profile";
            // 
            // panel_supplier_tasks_bottom
            // 
            panel_supplier_tasks_bottom.Controls.Add(dgv_tasks);
            panel_supplier_tasks_bottom.Dock = DockStyle.Fill;
            panel_supplier_tasks_bottom.Location = new Point(0, 225);
            panel_supplier_tasks_bottom.Name = "panel_supplier_tasks_bottom";
            panel_supplier_tasks_bottom.Size = new Size(1284, 445);
            panel_supplier_tasks_bottom.TabIndex = 43;
            // 
            // form_supplier_tasks
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(51, 54, 62);
            ClientSize = new Size(1284, 701);
            Controls.Add(panel_supplier_tasks_bottom);
            Controls.Add(strip_supplier_tasks);
            Controls.Add(panel_supplier_tasks_top);
            Controls.Add(menu_supplier_tasks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu_supplier_tasks;
            Margin = new Padding(1);
            Name = "form_supplier_tasks";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUPPLIER TASKS";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgv_tasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_search_icon).EndInit();
            menu_supplier_tasks.ResumeLayout(false);
            menu_supplier_tasks.PerformLayout();
            strip_supplier_tasks.ResumeLayout(false);
            strip_supplier_tasks.PerformLayout();
            panel_supplier_tasks_top.ResumeLayout(false);
            panel_supplier_tasks_top.PerformLayout();
            panel_supplier_tasks_bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sup_profile;
        private Label lbl_contract_type;
        private Label lbl_sup_name;
        private Label lbl_supplier_notes;
        private DataGridView dgv_tasks;
        private TextBox txtbox_supplier_search;
        private PictureBox img_search_icon;
        private MenuStrip menu_supplier_tasks;
        private ToolStripMenuItem menu_action;
        private ToolStripMenuItem action_reset_tasks;
        private StatusStrip strip_supplier_tasks;
        private ToolStripStatusLabel strip_message;
        private Panel panel_supplier_tasks_top;
        private ToolStripSplitButton strip_button;
        private TextBox txtbox_contract_type;
        private TextBox txtbox_sup_profile;
        private ToolStripStatusLabel strip_status;
        private ToolStripStatusLabel strip_time;
        private Panel panel_supplier_tasks_bottom;
        private TextBox txtbox_supplier_notes;
    }
}