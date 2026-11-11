namespace Haimen_Hospital_System
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            lblHospitalName = new Label();
            lblSignedAsCaption = new Label();
            lblusr = new Label();
            pnlDividerTop = new Panel();
            lblDashboardCaption = new Label();
            mnunav = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            checkDoctorAvailabilityToolStripMenuItem = new ToolStripMenuItem();
            reportBugToolStripMenuItem = new ToolStripMenuItem();
            appointmentsToolStripMenuItem = new ToolStripMenuItem();
            bookAppToolStripMenuItem = new ToolStripMenuItem();
            medicalRecordToolStripMenuItem = new ToolStripMenuItem();
            patientsToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            medRecordToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            sendWarningToolStripMenuItem = new ToolStripMenuItem();
            requestInfoUpdateToolStripMenuItem = new ToolStripMenuItem();
            lblrole = new Label();
            btnlogout = new Button();
            pnlDividerBot = new Panel();
            lblStatusCaption = new Label();
            lblstats = new Label();
            pnlContent = new Panel();
            homeViewPatient = new PatientHomeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlCrown = new Panel();
            mnunav.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblHospitalName
            // 
            lblHospitalName.AutoSize = true;
            lblHospitalName.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold);
            lblHospitalName.Location = new Point(111, 5);
            lblHospitalName.Margin = new Padding(4, 0, 4, 0);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(236, 37);
            lblHospitalName.TabIndex = 0;
            lblHospitalName.Text = "Haimen Hospital";
            // 
            // lblSignedAsCaption
            // 
            lblSignedAsCaption.AutoSize = true;
            lblSignedAsCaption.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignedAsCaption.Location = new Point(1149, 8);
            lblSignedAsCaption.Margin = new Padding(4, 0, 4, 0);
            lblSignedAsCaption.Name = "lblSignedAsCaption";
            lblSignedAsCaption.Size = new Size(182, 37);
            lblSignedAsCaption.TabIndex = 0;
            lblSignedAsCaption.Text = "Signed in as:";
            // 
            // lblusr
            // 
            lblusr.AutoSize = true;
            lblusr.Font = new Font("Segoe UI Variable Display Semib", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusr.Location = new Point(1308, 8);
            lblusr.Margin = new Padding(4, 0, 4, 0);
            lblusr.Name = "lblusr";
            lblusr.Size = new Size(0, 37);
            lblusr.TabIndex = 0;
            // 
            // pnlDividerTop
            // 
            pnlDividerTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDividerTop.BackColor = Color.FromArgb(200, 209, 218);
            pnlDividerTop.ForeColor = Color.White;
            pnlDividerTop.Location = new Point(111, 64);
            pnlDividerTop.Margin = new Padding(4);
            pnlDividerTop.MinimumSize = new Size(343, 1);
            pnlDividerTop.Name = "pnlDividerTop";
            pnlDividerTop.Size = new Size(1512, 9);
            pnlDividerTop.TabIndex = 1;
            // 
            // lblDashboardCaption
            // 
            lblDashboardCaption.AutoSize = true;
            lblDashboardCaption.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardCaption.ForeColor = Color.FromArgb(82, 96, 109);
            lblDashboardCaption.Location = new Point(120, 34);
            lblDashboardCaption.Margin = new Padding(4, 0, 4, 0);
            lblDashboardCaption.Name = "lblDashboardCaption";
            lblDashboardCaption.Size = new Size(84, 20);
            lblDashboardCaption.TabIndex = 0;
            lblDashboardCaption.Text = "Dashboard";
            // 
            // mnunav
            // 
            mnunav.Dock = DockStyle.Left;
            mnunav.GripStyle = ToolStripGripStyle.Visible;
            mnunav.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, checkDoctorAvailabilityToolStripMenuItem, reportBugToolStripMenuItem, appointmentsToolStripMenuItem, medicalRecordToolStripMenuItem, patientsToolStripMenuItem, adminToolStripMenuItem });
            mnunav.Location = new Point(0, 0);
            mnunav.Name = "mnunav";
            mnunav.Padding = new Padding(4, 3, 0, 3);
            mnunav.ShowItemToolTips = true;
            mnunav.Size = new Size(105, 902);
            mnunav.TabIndex = 2;
            mnunav.Text = "Navigation";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(96, 19);
            homeToolStripMenuItem.Text = "Home";
            // 
            // checkDoctorAvailabilityToolStripMenuItem
            // 
            checkDoctorAvailabilityToolStripMenuItem.Name = "checkDoctorAvailabilityToolStripMenuItem";
            checkDoctorAvailabilityToolStripMenuItem.Size = new Size(96, 19);
            checkDoctorAvailabilityToolStripMenuItem.Text = "Doctor Timings";
            // 
            // reportBugToolStripMenuItem
            // 
            reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            reportBugToolStripMenuItem.Size = new Size(96, 19);
            reportBugToolStripMenuItem.Text = "Report Bug";
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookAppToolStripMenuItem });
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Size = new Size(96, 19);
            appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // bookAppToolStripMenuItem
            // 
            bookAppToolStripMenuItem.Name = "bookAppToolStripMenuItem";
            bookAppToolStripMenuItem.Size = new Size(101, 22);
            bookAppToolStripMenuItem.Text = "Book";
            // 
            // medicalRecordToolStripMenuItem
            // 
            medicalRecordToolStripMenuItem.Name = "medicalRecordToolStripMenuItem";
            medicalRecordToolStripMenuItem.Size = new Size(96, 19);
            medicalRecordToolStripMenuItem.Text = "Medical Record";
            // 
            // patientsToolStripMenuItem
            // 
            patientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, registerToolStripMenuItem, medRecordToolStripMenuItem });
            patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            patientsToolStripMenuItem.Size = new Size(96, 19);
            patientsToolStripMenuItem.Text = "Patients";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(156, 22);
            searchToolStripMenuItem.Text = "Search";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(156, 22);
            registerToolStripMenuItem.Text = "Register";
            // 
            // medRecordToolStripMenuItem
            // 
            medRecordToolStripMenuItem.Name = "medRecordToolStripMenuItem";
            medRecordToolStripMenuItem.Size = new Size(156, 22);
            medRecordToolStripMenuItem.Text = "Medical Record";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(96, 19);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sendWarningToolStripMenuItem, requestInfoUpdateToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(102, 22);
            usersToolStripMenuItem.Text = "Users";
            // 
            // sendWarningToolStripMenuItem
            // 
            sendWarningToolStripMenuItem.Name = "sendWarningToolStripMenuItem";
            sendWarningToolStripMenuItem.Size = new Size(223, 22);
            sendWarningToolStripMenuItem.Text = "Send Warning";
            // 
            // requestInfoUpdateToolStripMenuItem
            // 
            requestInfoUpdateToolStripMenuItem.Name = "requestInfoUpdateToolStripMenuItem";
            requestInfoUpdateToolStripMenuItem.Size = new Size(223, 22);
            requestInfoUpdateToolStripMenuItem.Text = "Request Information Update";
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Font = new Font("Segoe UI Variable Display Semib", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblrole.Location = new Point(1308, 35);
            lblrole.Margin = new Padding(4, 0, 4, 0);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(0, 37);
            lblrole.TabIndex = 0;
            // 
            // btnlogout
            // 
            btnlogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnlogout.BackColor = Color.FromArgb(168, 35, 27);
            btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 135, 148);
            btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(120, 809);
            btnlogout.Margin = new Padding(4);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(93, 25);
            btnlogout.TabIndex = 3;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // pnlDividerBot
            // 
            pnlDividerBot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDividerBot.BackColor = Color.FromArgb(200, 209, 218);
            pnlDividerBot.ForeColor = Color.White;
            pnlDividerBot.Location = new Point(111, 796);
            pnlDividerBot.Margin = new Padding(4);
            pnlDividerBot.MinimumSize = new Size(343, 1);
            pnlDividerBot.Name = "pnlDividerBot";
            pnlDividerBot.Size = new Size(1512, 9);
            pnlDividerBot.TabIndex = 1;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblStatusCaption.Location = new Point(120, 852);
            lblStatusCaption.Margin = new Padding(4, 0, 4, 0);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(145, 25);
            lblStatusCaption.TabIndex = 4;
            lblStatusCaption.Text = "Status Message:";
            // 
            // lblstats
            // 
            lblstats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblstats.AutoSize = true;
            lblstats.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstats.Location = new Point(254, 856);
            lblstats.Margin = new Padding(4, 0, 4, 0);
            lblstats.Name = "lblstats";
            lblstats.Size = new Size(0, 20);
            lblstats.TabIndex = 4;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.Controls.Add(homeViewPatient);
            pnlContent.Location = new Point(111, 78);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1512, 712);
            pnlContent.TabIndex = 5;
            // 
            // homeViewPatient
            // 
            homeViewPatient.BackColor = Color.FromArgb(243, 246, 249);
            homeViewPatient.Dock = DockStyle.Fill;
            homeViewPatient.Location = new Point(0, 0);
            homeViewPatient.Name = "homeViewPatient";
            homeViewPatient.Size = new Size(1512, 712);
            homeViewPatient.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlCrown
            // 
            pnlCrown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCrown.BackColor = Color.FromArgb(200, 209, 218);
            pnlCrown.ForeColor = Color.White;
            pnlCrown.Location = new Point(111, 0);
            pnlCrown.Margin = new Padding(4);
            pnlCrown.MinimumSize = new Size(343, 1);
            pnlCrown.Name = "pnlCrown";
            pnlCrown.Size = new Size(1512, 9);
            pnlCrown.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            ClientSize = new Size(1632, 902);
            Controls.Add(pnlContent);
            Controls.Add(lblstats);
            Controls.Add(lblStatusCaption);
            Controls.Add(btnlogout);
            Controls.Add(pnlDividerBot);
            Controls.Add(pnlCrown);
            Controls.Add(pnlDividerTop);
            Controls.Add(lblrole);
            Controls.Add(lblusr);
            Controls.Add(lblSignedAsCaption);
            Controls.Add(lblDashboardCaption);
            Controls.Add(lblHospitalName);
            Controls.Add(mnunav);
            Font = new Font("Segoe UI Variable Display", 10.5F);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            mnunav.ResumeLayout(false);
            mnunav.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHospitalName;
        private Label lblSignedAsCaption;
        private Label lblusr;
        private Panel pnlDividerTop;
        private Label lblDashboardCaption;
        private MenuStrip mnunav;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Label lblrole;
        private Button btnlogout;
        private Panel pnlDividerBot;
        private Label lblStatusCaption;
        private Label lblstats;
        private Panel pnlContent;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem checkDoctorAvailabilityToolStripMenuItem;
        private ToolStripMenuItem reportBugToolStripMenuItem;
        private ToolStripMenuItem appointmentsToolStripMenuItem;
        private ToolStripMenuItem bookAppToolStripMenuItem;
        private ToolStripMenuItem medicalRecordToolStripMenuItem;
        private ToolStripMenuItem patientsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem sendWarningToolStripMenuItem;
        private ToolStripMenuItem medRecordToolStripMenuItem;
        private ToolStripMenuItem requestInfoUpdateToolStripMenuItem;
        private PatientHomeView homeViewPatient;
        private Panel pnlCrown;
    }
}