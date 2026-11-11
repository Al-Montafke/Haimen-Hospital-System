namespace Haimen_Hospital_System
{
    partial class ResetPasswordDialog
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
            pnlResetTopDivider = new Panel();
            lblResetTitle = new Label();
            lblResetEmailCaption = new Label();
            txtResetEmail = new TextBox();
            lblNewPasswordCaption = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPasswordCaption = new Label();
            txtConfirmPassword = new TextBox();
            pnlResetBottomDivider = new Panel();
            btnResetConfirm = new Button();
            btnResetCancel = new Button();
            SuspendLayout();
            // 
            // pnlResetTopDivider
            // 
            pnlResetTopDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlResetTopDivider.ForeColor = Color.White;
            pnlResetTopDivider.Location = new Point(24, 60);
            pnlResetTopDivider.Name = "pnlResetTopDivider";
            pnlResetTopDivider.Size = new Size(440, 10);
            pnlResetTopDivider.TabIndex = 23;
            // 
            // lblResetTitle
            // 
            lblResetTitle.AutoSize = true;
            lblResetTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResetTitle.ForeColor = Color.FromArgb(31, 41, 51);
            lblResetTitle.Location = new Point(24, 16);
            lblResetTitle.Name = "lblResetTitle";
            lblResetTitle.Size = new Size(217, 38);
            lblResetTitle.TabIndex = 21;
            lblResetTitle.Text = "Reset Password";
            // 
            // lblResetEmailCaption
            // 
            lblResetEmailCaption.AutoSize = true;
            lblResetEmailCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblResetEmailCaption.Location = new Point(24, 92);
            lblResetEmailCaption.Name = "lblResetEmailCaption";
            lblResetEmailCaption.Size = new Size(46, 19);
            lblResetEmailCaption.TabIndex = 24;
            lblResetEmailCaption.Text = "Email:";
            // 
            // txtResetEmail
            // 
            txtResetEmail.BorderStyle = BorderStyle.FixedSingle;
            txtResetEmail.Font = new Font("Segoe UI", 10.5F);
            txtResetEmail.Location = new Point(160, 88);
            txtResetEmail.Name = "txtResetEmail";
            txtResetEmail.Size = new Size(304, 26);
            txtResetEmail.TabIndex = 0;
            // 
            // lblNewPasswordCaption
            // 
            lblNewPasswordCaption.AutoSize = true;
            lblNewPasswordCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblNewPasswordCaption.Location = new Point(24, 132);
            lblNewPasswordCaption.Name = "lblNewPasswordCaption";
            lblNewPasswordCaption.Size = new Size(104, 19);
            lblNewPasswordCaption.TabIndex = 24;
            lblNewPasswordCaption.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 10.5F);
            txtNewPassword.Location = new Point(160, 128);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(304, 26);
            txtNewPassword.TabIndex = 1;
            // 
            // lblConfirmPasswordCaption
            // 
            lblConfirmPasswordCaption.AutoSize = true;
            lblConfirmPasswordCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblConfirmPasswordCaption.Location = new Point(24, 172);
            lblConfirmPasswordCaption.Name = "lblConfirmPasswordCaption";
            lblConfirmPasswordCaption.Size = new Size(126, 19);
            lblConfirmPasswordCaption.TabIndex = 24;
            lblConfirmPasswordCaption.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.5F);
            txtConfirmPassword.Location = new Point(160, 168);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(304, 26);
            txtConfirmPassword.TabIndex = 2;
            // 
            // pnlResetBottomDivider
            // 
            pnlResetBottomDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlResetBottomDivider.ForeColor = Color.White;
            pnlResetBottomDivider.Location = new Point(24, 214);
            pnlResetBottomDivider.Name = "pnlResetBottomDivider";
            pnlResetBottomDivider.Size = new Size(440, 4);
            pnlResetBottomDivider.TabIndex = 23;
            // 
            // btnResetConfirm
            // 
            btnResetConfirm.BackColor = Color.FromArgb(15, 108, 189);
            btnResetConfirm.FlatAppearance.BorderSize = 0;
            btnResetConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnResetConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnResetConfirm.FlatStyle = FlatStyle.Flat;
            btnResetConfirm.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnResetConfirm.ForeColor = Color.White;
            btnResetConfirm.Location = new Point(360, 226);
            btnResetConfirm.Name = "btnResetConfirm";
            btnResetConfirm.Size = new Size(104, 37);
            btnResetConfirm.TabIndex = 3;
            btnResetConfirm.Text = "Reset";
            btnResetConfirm.UseVisualStyleBackColor = false;
            // 
            // btnResetCancel
            // 
            btnResetCancel.BackColor = Color.White;
            btnResetCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnResetCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnResetCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnResetCancel.FlatStyle = FlatStyle.Flat;
            btnResetCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnResetCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnResetCancel.Location = new Point(244, 226);
            btnResetCancel.Name = "btnResetCancel";
            btnResetCancel.Size = new Size(104, 37);
            btnResetCancel.TabIndex = 4;
            btnResetCancel.Text = "Cancel";
            btnResetCancel.UseVisualStyleBackColor = false;
            // 
            // ResetPasswordDialog
            // 
            AcceptButton = btnResetConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            CancelButton = btnResetCancel;
            ClientSize = new Size(488, 287);
            Controls.Add(btnResetConfirm);
            Controls.Add(btnResetCancel);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtResetEmail);
            Controls.Add(lblConfirmPasswordCaption);
            Controls.Add(lblNewPasswordCaption);
            Controls.Add(lblResetEmailCaption);
            Controls.Add(pnlResetBottomDivider);
            Controls.Add(pnlResetTopDivider);
            Controls.Add(lblResetTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reset your password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlResetTopDivider;
        private Label lblResetTitle;
        private Label lblResetEmailCaption;
        private TextBox txtResetEmail;
        private Label lblNewPasswordCaption;
        private TextBox txtNewPassword;
        private Label lblConfirmPasswordCaption;
        private TextBox txtConfirmPassword;
        private Panel pnlResetBottomDivider;
        private Button btnResetConfirm;
        private Button btnResetCancel;
    }
}