namespace ONBOARDING
{
    partial class form_email_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_email_info));
            panel1 = new Panel();
            combox_email_id = new ComboBox();
            label4 = new Label();
            txtbox_taskID = new TextBox();
            lbl_task_ID = new Label();
            txtbox_sup_profile = new TextBox();
            lbl_sup_profile = new Label();
            bttn_update_email = new Button();
            panel2 = new Panel();
            txtbox_email_message = new TextBox();
            strip_email_info = new StatusStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            strip_time = new ToolStripStatusLabel();
            strip_message = new ToolStripStatusLabel();
            label3 = new Label();
            txtbox_email_subject = new TextBox();
            label2 = new Label();
            txtbox_email_cc = new TextBox();
            label1 = new Label();
            txtbox_email_to = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            strip_email_info.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 54, 62);
            panel1.Controls.Add(combox_email_id);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtbox_taskID);
            panel1.Controls.Add(lbl_task_ID);
            panel1.Controls.Add(txtbox_sup_profile);
            panel1.Controls.Add(lbl_sup_profile);
            panel1.Controls.Add(bttn_update_email);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 104);
            panel1.TabIndex = 0;
            // 
            // combox_email_id
            // 
            combox_email_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combox_email_id.AutoCompleteSource = AutoCompleteSource.ListItems;
            combox_email_id.BackColor = Color.FromArgb(230, 231, 241);
            combox_email_id.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combox_email_id.ForeColor = Color.FromArgb(51, 54, 62);
            combox_email_id.FormattingEnabled = true;
            combox_email_id.Location = new Point(27, 46);
            combox_email_id.Margin = new Padding(4);
            combox_email_id.MaxLength = 2;
            combox_email_id.Name = "combox_email_id";
            combox_email_id.Size = new Size(192, 33);
            combox_email_id.TabIndex = 0;
            combox_email_id.SelectedValueChanged += combox_email_id_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(230, 231, 241);
            label4.Location = new Point(27, 21);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 19;
            label4.Text = "EMAIL ID";
            // 
            // txtbox_taskID
            // 
            txtbox_taskID.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_taskID.BorderStyle = BorderStyle.None;
            txtbox_taskID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_taskID.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_taskID.Location = new Point(475, 52);
            txtbox_taskID.Margin = new Padding(3, 2, 3, 2);
            txtbox_taskID.Name = "txtbox_taskID";
            txtbox_taskID.Size = new Size(130, 22);
            txtbox_taskID.TabIndex = 21;
            txtbox_taskID.Text = "placeholder ID";
            // 
            // lbl_task_ID
            // 
            lbl_task_ID.AutoSize = true;
            lbl_task_ID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_task_ID.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_task_ID.Location = new Point(475, 21);
            lbl_task_ID.Margin = new Padding(1, 0, 1, 0);
            lbl_task_ID.Name = "lbl_task_ID";
            lbl_task_ID.Size = new Size(68, 21);
            lbl_task_ID.TabIndex = 20;
            lbl_task_ID.Text = "TASK ID";
            // 
            // txtbox_sup_profile
            // 
            txtbox_sup_profile.BackColor = Color.FromArgb(42, 45, 53);
            txtbox_sup_profile.BorderStyle = BorderStyle.None;
            txtbox_sup_profile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_sup_profile.ForeColor = Color.FromArgb(230, 231, 241);
            txtbox_sup_profile.Location = new Point(264, 52);
            txtbox_sup_profile.Margin = new Padding(3, 2, 3, 2);
            txtbox_sup_profile.Name = "txtbox_sup_profile";
            txtbox_sup_profile.Size = new Size(168, 22);
            txtbox_sup_profile.TabIndex = 19;
            txtbox_sup_profile.Text = "placeholder profile";
            // 
            // lbl_sup_profile
            // 
            lbl_sup_profile.AutoSize = true;
            lbl_sup_profile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_sup_profile.ForeColor = Color.FromArgb(230, 231, 241);
            lbl_sup_profile.Location = new Point(264, 21);
            lbl_sup_profile.Margin = new Padding(1, 0, 1, 0);
            lbl_sup_profile.Name = "lbl_sup_profile";
            lbl_sup_profile.Size = new Size(143, 21);
            lbl_sup_profile.TabIndex = 18;
            lbl_sup_profile.Text = "SUPPLIER PROFILE";
            // 
            // bttn_update_email
            // 
            bttn_update_email.BackColor = Color.LightSkyBlue;
            bttn_update_email.Cursor = Cursors.Hand;
            bttn_update_email.Dock = DockStyle.Right;
            bttn_update_email.FlatStyle = FlatStyle.Flat;
            bttn_update_email.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttn_update_email.ForeColor = Color.FromArgb(51, 54, 62);
            bttn_update_email.Location = new Point(977, 0);
            bttn_update_email.Margin = new Padding(4);
            bttn_update_email.Name = "bttn_update_email";
            bttn_update_email.Size = new Size(105, 104);
            bttn_update_email.TabIndex = 16;
            bttn_update_email.Text = "UPDATE";
            bttn_update_email.UseVisualStyleBackColor = false;
            bttn_update_email.Click += bttn_update_email_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 45, 53);
            panel2.Controls.Add(txtbox_email_message);
            panel2.Controls.Add(strip_email_info);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtbox_email_subject);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtbox_email_cc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtbox_email_to);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 381);
            panel2.TabIndex = 1;
            // 
            // txtbox_email_message
            // 
            txtbox_email_message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_email_message.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_email_message.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_email_message.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_email_message.Location = new Point(12, 207);
            txtbox_email_message.Multiline = true;
            txtbox_email_message.Name = "txtbox_email_message";
            txtbox_email_message.ScrollBars = ScrollBars.Vertical;
            txtbox_email_message.Size = new Size(1059, 133);
            txtbox_email_message.TabIndex = 4;
            // 
            // strip_email_info
            // 
            strip_email_info.BackColor = Color.FromArgb(32, 35, 43);
            strip_email_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strip_email_info.ImageScalingSize = new Size(20, 20);
            strip_email_info.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, strip_time, strip_message });
            strip_email_info.Location = new Point(0, 350);
            strip_email_info.Name = "strip_email_info";
            strip_email_info.Padding = new Padding(1, 0, 12, 0);
            strip_email_info.Size = new Size(1082, 31);
            strip_email_info.TabIndex = 102;
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
            strip_message.Size = new Size(270, 27);
            strip_message.Text = "WELCOME TO EMAIL INFO  ( ˶°ㅁ°) !!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(230, 231, 241);
            label3.Location = new Point(27, 150);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 24;
            label3.Text = "SUBJECT:";
            // 
            // txtbox_email_subject
            // 
            txtbox_email_subject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_email_subject.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_email_subject.Font = new Font("Segoe UI", 12F);
            txtbox_email_subject.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_email_subject.Location = new Point(123, 147);
            txtbox_email_subject.Margin = new Padding(4);
            txtbox_email_subject.Name = "txtbox_email_subject";
            txtbox_email_subject.Size = new Size(948, 29);
            txtbox_email_subject.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(230, 231, 241);
            label2.Location = new Point(27, 90);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 21;
            label2.Text = "CC:";
            // 
            // txtbox_email_cc
            // 
            txtbox_email_cc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_email_cc.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_email_cc.CharacterCasing = CharacterCasing.Upper;
            txtbox_email_cc.Font = new Font("Segoe UI", 12F);
            txtbox_email_cc.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_email_cc.Location = new Point(123, 87);
            txtbox_email_cc.Margin = new Padding(4);
            txtbox_email_cc.Name = "txtbox_email_cc";
            txtbox_email_cc.Size = new Size(948, 29);
            txtbox_email_cc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(230, 231, 241);
            label1.Location = new Point(27, 29);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 21);
            label1.TabIndex = 19;
            label1.Text = "TO:";
            // 
            // txtbox_email_to
            // 
            txtbox_email_to.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_email_to.BackColor = Color.FromArgb(230, 231, 241);
            txtbox_email_to.CharacterCasing = CharacterCasing.Upper;
            txtbox_email_to.Font = new Font("Segoe UI", 12F);
            txtbox_email_to.ForeColor = Color.FromArgb(51, 54, 62);
            txtbox_email_to.Location = new Point(123, 27);
            txtbox_email_to.Margin = new Padding(4);
            txtbox_email_to.Name = "txtbox_email_to";
            txtbox_email_to.Size = new Size(948, 29);
            txtbox_email_to.TabIndex = 1;
            // 
            // form_email_info
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1082, 485);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form_email_info";
            Text = "EmailInfo";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            strip_email_info.ResumeLayout(false);
            strip_email_info.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button bttn_update_email;
        private TextBox txtbox_taskID;
        private Label lbl_task_ID;
        private TextBox txtbox_sup_profile;
        private Label lbl_sup_profile;
        private Label label1;
        private TextBox txtbox_email_to;
        private Label label2;
        private TextBox txtbox_email_cc;
        private Label label3;
        private TextBox txtbox_email_subject;
        private Label label4;
        private ComboBox combox_email_id;
        private StatusStrip strip_email_info;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel strip_time;
        private ToolStripStatusLabel strip_message;
        private TextBox txtbox_email_message;
    }
}