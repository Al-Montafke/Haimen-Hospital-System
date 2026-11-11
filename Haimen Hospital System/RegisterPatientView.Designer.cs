namespace Haimen_Hospital_System
{
    partial class RegisterPatientView
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
            lblRegisterCaption = new Label();
            lblNationalIdCaption = new Label();
            lblEmailCaption = new Label();
            txtNationalId = new TextBox();
            txtEmail = new TextBox();
            identityBlockResult = new IdentityBlockView();
            pnlRegisterDivider = new Panel();
            btnRegisterCancel = new Button();
            btnRegisterConfirm = new Button();
            lblImportedCaption = new Label();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblPageTitle.ForeColor = SystemColors.ActiveCaption;
            lblPageTitle.Location = new Point(24, 16);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(224, 38);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Register Patient";
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
            pnldivider.TabIndex = 6;
            // 
            // lblRegisterCaption
            // 
            lblRegisterCaption.AutoSize = true;
            lblRegisterCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblRegisterCaption.Location = new Point(24, 76);
            lblRegisterCaption.Name = "lblRegisterCaption";
            lblRegisterCaption.Size = new Size(200, 25);
            lblRegisterCaption.TabIndex = 7;
            lblRegisterCaption.Text = "Register a new patient";
            // 
            // lblNationalIdCaption
            // 
            lblNationalIdCaption.AutoSize = true;
            lblNationalIdCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblNationalIdCaption.Location = new Point(24, 112);
            lblNationalIdCaption.Name = "lblNationalIdCaption";
            lblNationalIdCaption.Size = new Size(84, 19);
            lblNationalIdCaption.TabIndex = 8;
            lblNationalIdCaption.Text = "National ID:";
            // 
            // lblEmailCaption
            // 
            lblEmailCaption.AutoSize = true;
            lblEmailCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblEmailCaption.Location = new Point(24, 152);
            lblEmailCaption.Name = "lblEmailCaption";
            lblEmailCaption.Size = new Size(46, 19);
            lblEmailCaption.TabIndex = 8;
            lblEmailCaption.Text = "Email:";
            // 
            // txtNationalId
            // 
            txtNationalId.BackColor = Color.White;
            txtNationalId.BorderStyle = BorderStyle.FixedSingle;
            txtNationalId.Font = new Font("Segoe UI", 10.5F);
            txtNationalId.Location = new Point(116, 108);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.PlaceholderText = "ex: **-****-****-**";
            txtNationalId.Size = new Size(240, 26);
            txtNationalId.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.Location = new Point(116, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g.: example@gmail.com";
            txtEmail.Size = new Size(240, 26);
            txtEmail.TabIndex = 1;
            // 
            // identityBlockResult
            // 
            identityBlockResult.Age = "26";
            identityBlockResult.Birthday = "14/04/1999";
            identityBlockResult.Email = "example@gmail.com";
            identityBlockResult.Ethnicity = "European";
            identityBlockResult.Gender = "Male";
            identityBlockResult.Location = new Point(24, 228);
            identityBlockResult.Name = "identityBlockResult";
            identityBlockResult.NationalID = "241-21443553423-11212-42";
            identityBlockResult.Size = new Size(1464, 266);
            identityBlockResult.TabIndex = 10;
            identityBlockResult.UserId = new Guid("661736b1-3d79-4664-9601-fa05e3871d56");
            identityBlockResult.UserImage = null;
            identityBlockResult.UserName = "Jacob";
            // 
            // pnlRegisterDivider
            // 
            pnlRegisterDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRegisterDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlRegisterDivider.ForeColor = Color.White;
            pnlRegisterDivider.Location = new Point(24, 639);
            pnlRegisterDivider.MinimumSize = new Size(400, 1);
            pnlRegisterDivider.Name = "pnlRegisterDivider";
            pnlRegisterDivider.Size = new Size(1464, 4);
            pnlRegisterDivider.TabIndex = 6;
            // 
            // btnRegisterCancel
            // 
            btnRegisterCancel.BackColor = Color.White;
            btnRegisterCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnRegisterCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRegisterCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnRegisterCancel.FlatStyle = FlatStyle.Flat;
            btnRegisterCancel.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnRegisterCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnRegisterCancel.Location = new Point(1268, 651);
            btnRegisterCancel.Name = "btnRegisterCancel";
            btnRegisterCancel.Size = new Size(104, 37);
            btnRegisterCancel.TabIndex = 3;
            btnRegisterCancel.Text = "Cancel";
            btnRegisterCancel.UseVisualStyleBackColor = false;
            // 
            // btnRegisterConfirm
            // 
            btnRegisterConfirm.BackColor = Color.FromArgb(15, 108, 189);
            btnRegisterConfirm.FlatAppearance.BorderSize = 0;
            btnRegisterConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRegisterConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnRegisterConfirm.FlatStyle = FlatStyle.Flat;
            btnRegisterConfirm.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnRegisterConfirm.ForeColor = Color.White;
            btnRegisterConfirm.Location = new Point(1384, 651);
            btnRegisterConfirm.Name = "btnRegisterConfirm";
            btnRegisterConfirm.Size = new Size(104, 37);
            btnRegisterConfirm.TabIndex = 2;
            btnRegisterConfirm.Text = "Register";
            btnRegisterConfirm.UseVisualStyleBackColor = false;
            // 
            // lblImportedCaption
            // 
            lblImportedCaption.AutoSize = true;
            lblImportedCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblImportedCaption.Location = new Point(24, 196);
            lblImportedCaption.Name = "lblImportedCaption";
            lblImportedCaption.Size = new Size(245, 19);
            lblImportedCaption.TabIndex = 8;
            lblImportedCaption.Text = "Imported from the National Registery";
            // 
            // RegisterPatientView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnRegisterCancel);
            Controls.Add(btnRegisterConfirm);
            Controls.Add(identityBlockResult);
            Controls.Add(txtEmail);
            Controls.Add(txtNationalId);
            Controls.Add(lblImportedCaption);
            Controls.Add(lblEmailCaption);
            Controls.Add(lblNationalIdCaption);
            Controls.Add(lblRegisterCaption);
            Controls.Add(pnlRegisterDivider);
            Controls.Add(pnldivider);
            Controls.Add(lblPageTitle);
            Name = "RegisterPatientView";
            Size = new Size(1512, 712);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private Label lblRegisterCaption;
        private Label lblNationalIdCaption;
        private Label lblEmailCaption;
        private TextBox txtNationalId;
        private TextBox txtEmail;
        private IdentityBlockView identityBlockResult;
        private Panel pnlRegisterDivider;
        private Button btnRegisterCancel;
        private Button btnRegisterConfirm;
        private Label lblImportedCaption;
    }
}
