namespace Haimen_Hospital_System
{
    partial class AdminRequestInformationUpdateView
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
            lblPageTitle = new Label();
            pnldivider = new Panel();
            lblAdminFindCaption = new Label();
            lblAdminNationalId = new Label();
            txtNationalId = new TextBox();
            btnSearch = new Button();
            identityBlockTarget = new IdentityBlockView();
            lblRequestCaption = new Label();
            txtRequestSubject = new TextBox();
            lblSubjectCaption = new Label();
            dtpRequestDue = new DateTimePicker();
            lblDueCaption = new Label();
            pnlDividerBottom = new Panel();
            btnSendRequest = new Button();
            btnRequestCancel = new Button();
            lblPageSubTitle = new Label();
            SuspendLayout();
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
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Admin Control";
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
            pnldivider.TabIndex = 7;
            // 
            // lblAdminFindCaption
            // 
            lblAdminFindCaption.AutoSize = true;
            lblAdminFindCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblAdminFindCaption.Location = new Point(24, 76);
            lblAdminFindCaption.Name = "lblAdminFindCaption";
            lblAdminFindCaption.Size = new Size(91, 25);
            lblAdminFindCaption.TabIndex = 8;
            lblAdminFindCaption.Text = "Find User";
            // 
            // lblAdminNationalId
            // 
            lblAdminNationalId.AutoSize = true;
            lblAdminNationalId.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblAdminNationalId.Location = new Point(24, 112);
            lblAdminNationalId.Name = "lblAdminNationalId";
            lblAdminNationalId.Size = new Size(86, 19);
            lblAdminNationalId.TabIndex = 9;
            lblAdminNationalId.Text = "National ID:";
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
            identityBlockTarget.TabIndex = 12;
            identityBlockTarget.UserId = new Guid("661736b1-3d79-4664-9601-fa05e3871d56");
            identityBlockTarget.UserImage = Properties.Resources.Gemini_Generated_Image_5o38gp5o38gp5o38;
            identityBlockTarget.UserName = "Jacob";
            // 
            // lblRequestCaption
            // 
            lblRequestCaption.AutoSize = true;
            lblRequestCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblRequestCaption.Location = new Point(24, 434);
            lblRequestCaption.Name = "lblRequestCaption";
            lblRequestCaption.Size = new Size(84, 25);
            lblRequestCaption.TabIndex = 9;
            lblRequestCaption.Text = "Request:";
            // 
            // txtRequestSubject
            // 
            txtRequestSubject.Font = new Font("Segoe UI", 10.5F);
            txtRequestSubject.Location = new Point(116, 466);
            txtRequestSubject.Name = "txtRequestSubject";
            txtRequestSubject.PlaceholderText = "ex: 241-21443553423-11212-44";
            txtRequestSubject.Size = new Size(500, 26);
            txtRequestSubject.TabIndex = 2;
            // 
            // lblSubjectCaption
            // 
            lblSubjectCaption.AutoSize = true;
            lblSubjectCaption.Font = new Font("Segoe UI", 10.5F);
            lblSubjectCaption.Location = new Point(24, 470);
            lblSubjectCaption.Name = "lblSubjectCaption";
            lblSubjectCaption.Size = new Size(56, 19);
            lblSubjectCaption.TabIndex = 9;
            lblSubjectCaption.Text = "Subject:";
            // 
            // dtpRequestDue
            // 
            dtpRequestDue.Font = new Font("Segoe UI", 10.5F);
            dtpRequestDue.Location = new Point(116, 502);
            dtpRequestDue.Name = "dtpRequestDue";
            dtpRequestDue.Size = new Size(200, 26);
            dtpRequestDue.TabIndex = 3;
            // 
            // lblDueCaption
            // 
            lblDueCaption.AutoSize = true;
            lblDueCaption.Font = new Font("Segoe UI", 10.5F);
            lblDueCaption.Location = new Point(24, 506);
            lblDueCaption.Name = "lblDueCaption";
            lblDueCaption.Size = new Size(90, 19);
            lblDueCaption.TabIndex = 9;
            lblDueCaption.Text = "Request Due:";
            // 
            // pnlDividerBottom
            // 
            pnlDividerBottom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDividerBottom.BackColor = Color.FromArgb(200, 209, 218);
            pnlDividerBottom.ForeColor = Color.White;
            pnlDividerBottom.Location = new Point(24, 639);
            pnlDividerBottom.MinimumSize = new Size(400, 1);
            pnlDividerBottom.Name = "pnlDividerBottom";
            pnlDividerBottom.Size = new Size(1464, 4);
            pnlDividerBottom.TabIndex = 7;
            // 
            // btnSendRequest
            // 
            btnSendRequest.BackColor = Color.FromArgb(15, 108, 189);
            btnSendRequest.FlatAppearance.BorderSize = 0;
            btnSendRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnSendRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSendRequest.ForeColor = Color.White;
            btnSendRequest.Location = new Point(1358, 651);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(130, 37);
            btnSendRequest.TabIndex = 4;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = false;
            // 
            // btnRequestCancel
            // 
            btnRequestCancel.BackColor = Color.White;
            btnRequestCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnRequestCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRequestCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnRequestCancel.FlatStyle = FlatStyle.Flat;
            btnRequestCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnRequestCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnRequestCancel.Location = new Point(1242, 651);
            btnRequestCancel.Name = "btnRequestCancel";
            btnRequestCancel.Size = new Size(104, 37);
            btnRequestCancel.TabIndex = 5;
            btnRequestCancel.Text = "Cancel";
            btnRequestCancel.UseVisualStyleBackColor = false;
            // 
            // lblPageSubTitle
            // 
            lblPageSubTitle.AutoSize = true;
            lblPageSubTitle.BackColor = Color.FromArgb(243, 246, 249);
            lblPageSubTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblPageSubTitle.ForeColor = SystemColors.ActiveCaption;
            lblPageSubTitle.Location = new Point(241, 27);
            lblPageSubTitle.Name = "lblPageSubTitle";
            lblPageSubTitle.Size = new Size(255, 25);
            lblPageSubTitle.TabIndex = 0;
            lblPageSubTitle.Text = "Request Information Update";
            // 
            // AdminRequestInformationUpdateView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(btnSendRequest);
            Controls.Add(btnRequestCancel);
            Controls.Add(dtpRequestDue);
            Controls.Add(identityBlockTarget);
            Controls.Add(btnSearch);
            Controls.Add(txtRequestSubject);
            Controls.Add(txtNationalId);
            Controls.Add(lblRequestCaption);
            Controls.Add(lblDueCaption);
            Controls.Add(lblSubjectCaption);
            Controls.Add(lblAdminNationalId);
            Controls.Add(lblAdminFindCaption);
            Controls.Add(pnlDividerBottom);
            Controls.Add(pnldivider);
            Controls.Add(lblPageSubTitle);
            Controls.Add(lblPageTitle);
            Name = "AdminRequestInformationUpdateView";
            Size = new Size(1512, 712);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private Label lblAdminFindCaption;
        private Label lblAdminNationalId;
        private TextBox txtNationalId;
        private Button btnSearch;
        private IdentityBlockView identityBlockTarget;
        private Label lblRequestCaption;
        private TextBox txtRequestSubject;
        private Label lblSubjectCaption;
        private DateTimePicker dtpRequestDue;
        private Label lblDueCaption;
        private Panel pnlDividerBottom;
        private Button btnSendRequest;
        private Button btnRequestCancel;
        private Label lblPageSubTitle;
    }
}
