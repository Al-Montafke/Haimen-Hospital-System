namespace Haimen_Hospital_System
{
    partial class AdminSendWarningsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            identityBlockTarget = new IdentityBlockView();
            btnSearch = new Button();
            txtNationalId = new TextBox();
            lblAdminNationalId = new Label();
            lblAdminFindCaption = new Label();
            pnldivider = new Panel();
            lblPageSubTitle = new Label();
            lblPageTitle = new Label();
            lblWarningCaption = new Label();
            cmbWarningReason = new ComboBox();
            txtWarningMessage = new TextBox();
            pnlWarningBotDivider = new Panel();
            btnSendWarning = new Button();
            btnWarningCancel = new Button();
            lblWarningReasonCaption = new Label();
            lblWarningMessageCaption = new Label();
            SuspendLayout();
            // 
            // identityBlockTarget
            // 
            identityBlockTarget.Age = "26";
            identityBlockTarget.Birthday = "14/04/1999";
            identityBlockTarget.Email = "example@gmail.com";
            identityBlockTarget.Ethnicity = "European";
            identityBlockTarget.Gender = "Male";
            identityBlockTarget.Location = new Point(24, 152);
            identityBlockTarget.Name = "identityBlockTarget";
            identityBlockTarget.NationalID = "241-21443553423-11212-42";
            identityBlockTarget.Size = new Size(1464, 266);
            identityBlockTarget.TabIndex = 20;
            identityBlockTarget.UserId = new Guid("661736b1-3d79-4664-9601-fa05e3871d56");
            identityBlockTarget.UserImage = Properties.Resources.Gemini_Generated_Image_5o38gp5o38gp5o38;
            identityBlockTarget.UserName = "Jacob";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.System;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSearch.Location = new Point(368, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtNationalId
            // 
            txtNationalId.Font = new Font("Segoe UI", 10.5F);
            txtNationalId.Location = new Point(116, 108);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.PlaceholderText = "ex: 241-21443553423-11212-44";
            txtNationalId.Size = new Size(240, 26);
            txtNationalId.TabIndex = 0;
            // 
            // lblAdminNationalId
            // 
            lblAdminNationalId.AutoSize = true;
            lblAdminNationalId.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblAdminNationalId.Location = new Point(24, 112);
            lblAdminNationalId.Name = "lblAdminNationalId";
            lblAdminNationalId.Size = new Size(86, 19);
            lblAdminNationalId.TabIndex = 19;
            lblAdminNationalId.Text = "National ID:";
            // 
            // lblAdminFindCaption
            // 
            lblAdminFindCaption.AutoSize = true;
            lblAdminFindCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblAdminFindCaption.Location = new Point(24, 76);
            lblAdminFindCaption.Name = "lblAdminFindCaption";
            lblAdminFindCaption.Size = new Size(91, 25);
            lblAdminFindCaption.TabIndex = 18;
            lblAdminFindCaption.Text = "Find User";
            // 
            // pnldivider
            // 
            pnldivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnldivider.BackColor = Color.FromArgb(200, 209, 218);
            pnldivider.ForeColor = Color.White;
            pnldivider.Location = new Point(24, 60);
            pnldivider.MinimumSize = new Size(400, 1);
            pnldivider.Name = "pnldivider";
            pnldivider.Size = new Size(1464, 10);
            pnldivider.TabIndex = 17;
            // 
            // lblPageSubTitle
            // 
            lblPageSubTitle.AutoSize = true;
            lblPageSubTitle.BackColor = Color.FromArgb(243, 246, 249);
            lblPageSubTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblPageSubTitle.ForeColor = SystemColors.ActiveCaption;
            lblPageSubTitle.Location = new Point(241, 27);
            lblPageSubTitle.Name = "lblPageSubTitle";
            lblPageSubTitle.Size = new Size(131, 25);
            lblPageSubTitle.TabIndex = 14;
            lblPageSubTitle.Text = "Send Warning";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.FromArgb(243, 246, 249);
            lblPageTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblPageTitle.ForeColor = SystemColors.ActiveCaption;
            lblPageTitle.Location = new Point(24, 16);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(211, 38);
            lblPageTitle.TabIndex = 15;
            lblPageTitle.Text = "Admin Control";
            // 
            // lblWarningCaption
            // 
            lblWarningCaption.AutoSize = true;
            lblWarningCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblWarningCaption.Location = new Point(24, 434);
            lblWarningCaption.Name = "lblWarningCaption";
            lblWarningCaption.Size = new Size(86, 25);
            lblWarningCaption.TabIndex = 21;
            lblWarningCaption.Text = "Warning:";
            // 
            // cmbWarningReason
            // 
            cmbWarningReason.Font = new Font("Segoe UI", 10.5F);
            cmbWarningReason.FormattingEnabled = true;
            cmbWarningReason.Items.AddRange(new object[] { "Out-Of-Date Document", "Wrong data provided", "Missing information required" });
            cmbWarningReason.Location = new Point(116, 466);
            cmbWarningReason.Name = "cmbWarningReason";
            cmbWarningReason.Size = new Size(340, 27);
            cmbWarningReason.TabIndex = 2;
            // 
            // txtWarningMessage
            // 
            txtWarningMessage.BorderStyle = BorderStyle.FixedSingle;
            txtWarningMessage.Font = new Font("Segoe UI", 10.5F);
            txtWarningMessage.Location = new Point(116, 502);
            txtWarningMessage.Multiline = true;
            txtWarningMessage.Name = "txtWarningMessage";
            txtWarningMessage.Size = new Size(700, 120);
            txtWarningMessage.TabIndex = 3;
            // 
            // pnlWarningBotDivider
            // 
            pnlWarningBotDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlWarningBotDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlWarningBotDivider.ForeColor = Color.White;
            pnlWarningBotDivider.Location = new Point(24, 639);
            pnlWarningBotDivider.MinimumSize = new Size(400, 1);
            pnlWarningBotDivider.Name = "pnlWarningBotDivider";
            pnlWarningBotDivider.Size = new Size(1464, 4);
            pnlWarningBotDivider.TabIndex = 17;
            // 
            // btnSendWarning
            // 
            btnSendWarning.BackColor = Color.FromArgb(15, 108, 189);
            btnSendWarning.FlatAppearance.BorderSize = 0;
            btnSendWarning.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnSendWarning.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnSendWarning.FlatStyle = FlatStyle.Flat;
            btnSendWarning.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSendWarning.ForeColor = Color.White;
            btnSendWarning.Location = new Point(1358, 651);
            btnSendWarning.Name = "btnSendWarning";
            btnSendWarning.Size = new Size(130, 37);
            btnSendWarning.TabIndex = 4;
            btnSendWarning.Text = "Send Warning";
            btnSendWarning.UseVisualStyleBackColor = false;
            // 
            // btnWarningCancel
            // 
            btnWarningCancel.BackColor = Color.White;
            btnWarningCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnWarningCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnWarningCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnWarningCancel.FlatStyle = FlatStyle.Flat;
            btnWarningCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnWarningCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnWarningCancel.Location = new Point(1242, 651);
            btnWarningCancel.Name = "btnWarningCancel";
            btnWarningCancel.Size = new Size(104, 37);
            btnWarningCancel.TabIndex = 5;
            btnWarningCancel.Text = "Cancel";
            btnWarningCancel.UseVisualStyleBackColor = false;
            // 
            // lblWarningReasonCaption
            // 
            lblWarningReasonCaption.AutoSize = true;
            lblWarningReasonCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblWarningReasonCaption.Location = new Point(24, 470);
            lblWarningReasonCaption.Name = "lblWarningReasonCaption";
            lblWarningReasonCaption.Size = new Size(57, 19);
            lblWarningReasonCaption.TabIndex = 26;
            lblWarningReasonCaption.Text = "Reason:";
            // 
            // lblWarningMessageCaption
            // 
            lblWarningMessageCaption.AutoSize = true;
            lblWarningMessageCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblWarningMessageCaption.Location = new Point(24, 506);
            lblWarningMessageCaption.Name = "lblWarningMessageCaption";
            lblWarningMessageCaption.Size = new Size(66, 19);
            lblWarningMessageCaption.TabIndex = 26;
            lblWarningMessageCaption.Text = "Message:";
            // 
            // AdminSendWarningsView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(lblWarningMessageCaption);
            Controls.Add(lblWarningReasonCaption);
            Controls.Add(btnSendWarning);
            Controls.Add(btnWarningCancel);
            Controls.Add(txtWarningMessage);
            Controls.Add(cmbWarningReason);
            Controls.Add(lblWarningCaption);
            Controls.Add(identityBlockTarget);
            Controls.Add(btnSearch);
            Controls.Add(txtNationalId);
            Controls.Add(lblAdminNationalId);
            Controls.Add(lblAdminFindCaption);
            Controls.Add(pnlWarningBotDivider);
            Controls.Add(pnldivider);
            Controls.Add(lblPageSubTitle);
            Controls.Add(lblPageTitle);
            Name = "AdminSendWarningsView";
            Size = new Size(1512, 712);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private IdentityBlockView identityBlockTarget;
        private Button btnSearch;
        private TextBox txtNationalId;
        private Label lblAdminNationalId;
        private Label lblAdminFindCaption;
        private Panel pnldivider;
        private Label lblPageSubTitle;
        private Label lblPageTitle;
        private Label lblWarningCaption;
        private ComboBox cmbWarningReason;
        private TextBox txtWarningMessage;
        private Panel pnlWarningBotDivider;
        private Button btnSendWarning;
        private Button btnWarningCancel;
        private Label lblWarningReasonCaption;
        private Label lblWarningMessageCaption;
    }
}
