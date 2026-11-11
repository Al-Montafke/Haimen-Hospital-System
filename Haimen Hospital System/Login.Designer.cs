namespace Haimen_Hospital_System
{
    partial class Login
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
            lblHaiCaption = new Label();
            lblWelCaption = new Label();
            btnlogin = new Button();
            txtpasslog = new TextBox();
            txtemaillog = new TextBox();
            lblPassCaption = new Label();
            lblMailCaption = new Label();
            lnklblSign = new LinkLabel();
            lnklblforgot = new LinkLabel();
            lblNoAccountCaption = new Label();
            lblForgotPassCaption = new Label();
            SuspendLayout();
            // 
            // lblHaiCaption
            // 
            lblHaiCaption.AutoSize = true;
            lblHaiCaption.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold);
            lblHaiCaption.ForeColor = Color.FromArgb(31, 41, 51);
            lblHaiCaption.Location = new Point(137, 107);
            lblHaiCaption.Name = "lblHaiCaption";
            lblHaiCaption.Size = new Size(236, 37);
            lblHaiCaption.TabIndex = 0;
            lblHaiCaption.Text = "Haimen Hospital";
            // 
            // lblWelCaption
            // 
            lblWelCaption.AutoSize = true;
            lblWelCaption.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold);
            lblWelCaption.ForeColor = Color.FromArgb(31, 41, 51);
            lblWelCaption.Location = new Point(166, 76);
            lblWelCaption.Name = "lblWelCaption";
            lblWelCaption.Size = new Size(175, 37);
            lblWelCaption.TabIndex = 0;
            lblWelCaption.Text = "Welcome to";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(15, 108, 189);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(200, 257);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(104, 37);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtpasslog
            // 
            txtpasslog.BackColor = Color.White;
            txtpasslog.BorderStyle = BorderStyle.FixedSingle;
            txtpasslog.Font = new Font("Segoe UI", 10.5F);
            txtpasslog.ForeColor = Color.FromArgb(31, 41, 51);
            txtpasslog.Location = new Point(153, 217);
            txtpasslog.Name = "txtpasslog";
            txtpasslog.PasswordChar = '*';
            txtpasslog.Size = new Size(199, 26);
            txtpasslog.TabIndex = 1;
            // 
            // txtemaillog
            // 
            txtemaillog.BackColor = Color.White;
            txtemaillog.BorderStyle = BorderStyle.FixedSingle;
            txtemaillog.Font = new Font("Segoe UI", 10.5F);
            txtemaillog.ForeColor = Color.FromArgb(31, 41, 51);
            txtemaillog.Location = new Point(153, 169);
            txtemaillog.Name = "txtemaillog";
            txtemaillog.Size = new Size(199, 26);
            txtemaillog.TabIndex = 0;
            // 
            // lblPassCaption
            // 
            lblPassCaption.AutoSize = true;
            lblPassCaption.Font = new Font("Segoe UI", 10.5F);
            lblPassCaption.ForeColor = Color.FromArgb(82, 96, 109);
            lblPassCaption.Location = new Point(66, 217);
            lblPassCaption.Name = "lblPassCaption";
            lblPassCaption.Size = new Size(70, 19);
            lblPassCaption.TabIndex = 1;
            lblPassCaption.Text = "Password:";
            // 
            // lblMailCaption
            // 
            lblMailCaption.AutoSize = true;
            lblMailCaption.Font = new Font("Segoe UI", 10.5F);
            lblMailCaption.ForeColor = Color.FromArgb(82, 96, 109);
            lblMailCaption.Location = new Point(66, 169);
            lblMailCaption.Name = "lblMailCaption";
            lblMailCaption.Size = new Size(44, 19);
            lblMailCaption.TabIndex = 1;
            lblMailCaption.Text = "Email:";
            // 
            // lnklblSign
            // 
            lnklblSign.ActiveLinkColor = Color.FromArgb(9, 68, 120);
            lnklblSign.AutoSize = true;
            lnklblSign.LinkColor = Color.FromArgb(15, 108, 109);
            lnklblSign.Location = new Point(227, 363);
            lnklblSign.Name = "lnklblSign";
            lnklblSign.Size = new Size(47, 15);
            lnklblSign.TabIndex = 3;
            lnklblSign.TabStop = true;
            lnklblSign.Text = "Sign up";
            lnklblSign.VisitedLinkColor = Color.FromArgb(11, 83, 148);
            // 
            // lnklblforgot
            // 
            lnklblforgot.ActiveLinkColor = Color.FromArgb(9, 68, 120);
            lnklblforgot.AutoSize = true;
            lnklblforgot.LinkColor = Color.FromArgb(15, 108, 109);
            lnklblforgot.Location = new Point(222, 328);
            lnklblforgot.Name = "lnklblforgot";
            lnklblforgot.Size = new Size(59, 15);
            lnklblforgot.TabIndex = 2;
            lnklblforgot.TabStop = true;
            lnklblforgot.Text = "Click here";
            lnklblforgot.VisitedLinkColor = Color.FromArgb(11, 83, 148);
            // 
            // lblNoAccountCaption
            // 
            lblNoAccountCaption.AutoSize = true;
            lblNoAccountCaption.Font = new Font("Segoe UI Variable Display Semib", 10.5F, FontStyle.Bold);
            lblNoAccountCaption.Location = new Point(209, 344);
            lblNoAccountCaption.Name = "lblNoAccountCaption";
            lblNoAccountCaption.Size = new Size(88, 19);
            lblNoAccountCaption.TabIndex = 0;
            lblNoAccountCaption.Text = "No account?";
            // 
            // lblForgotPassCaption
            // 
            lblForgotPassCaption.AutoSize = true;
            lblForgotPassCaption.Font = new Font("Segoe UI Variable Display Semib", 10.5F, FontStyle.Bold);
            lblForgotPassCaption.Location = new Point(181, 309);
            lblForgotPassCaption.Name = "lblForgotPassCaption";
            lblForgotPassCaption.Size = new Size(150, 19);
            lblForgotPassCaption.TabIndex = 0;
            lblForgotPassCaption.Text = "Forgot your password?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            ClientSize = new Size(488, 450);
            Controls.Add(btnlogin);
            Controls.Add(lnklblSign);
            Controls.Add(lnklblforgot);
            Controls.Add(txtpasslog);
            Controls.Add(txtemaillog);
            Controls.Add(lblPassCaption);
            Controls.Add(lblMailCaption);
            Controls.Add(lblWelCaption);
            Controls.Add(lblNoAccountCaption);
            Controls.Add(lblForgotPassCaption);
            Controls.Add(lblHaiCaption);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHaiCaption;
        private Label lblWelCaption;
        private Button btnlogin;
        private TextBox txtpasslog;
        private TextBox txtemaillog;
        private Label lblPassCaption;
        private Label lblMailCaption;
        private LinkLabel lnklblSign;
        private LinkLabel lnklblforgot;
        private Label lblNoAccountCaption;
        private Label lblForgotPassCaption;
    }
}
