namespace Haimen_Hospital_System
{
    partial class AdminHomeView
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
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Out-Of-Date Document", "02/11/2026", "Please upload a current insurance card." }, -1);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Wrong data provided", "04/11/2026", "Date of birth does not match your ID." }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "Missing information required", "06/11/2026", "Please add an emergency contact." }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "Updated insurance details", "12/11/2026", "Pending" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "Proof of address", "15/11/2026", "Received" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "Vaccination history", "05/11/2026", "Overdue" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "Calendar does not load when booking", "03/11/2026", "Open" }, -1);
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "Uploaded file name appears blank", "05/11/2026", "In progress" }, -1);
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "Password reset button does nothing", "07/11/2026", "Resolved" }, -1);
            pnlHomeHeader = new Panel();
            lblHomeHeader = new Label();
            lvWarnings = new ListView();
            colWarningReason = new ColumnHeader();
            colWarningSent = new ColumnHeader();
            colWarningMessage = new ColumnHeader();
            lvRequests = new ListView();
            colRequestSubject = new ColumnHeader();
            colRequestDue = new ColumnHeader();
            colRequestStatus = new ColumnHeader();
            lvBugReports = new ListView();
            colBugDescription = new ColumnHeader();
            colBugReported = new ColumnHeader();
            colBugStatus = new ColumnHeader();
            lblWarningsCaption = new Label();
            lblRequestsCaption = new Label();
            lblReportsCaption = new Label();
            identityBlockHome = new IdentityBlockView();
            pnlHomeHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHomeHeader
            // 
            pnlHomeHeader.BackColor = Color.White;
            pnlHomeHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHomeHeader.Controls.Add(lblHomeHeader);
            pnlHomeHeader.ForeColor = SystemColors.ButtonFace;
            pnlHomeHeader.Location = new Point(24, 24);
            pnlHomeHeader.Name = "pnlHomeHeader";
            pnlHomeHeader.Size = new Size(1464, 49);
            pnlHomeHeader.TabIndex = 1;
            // 
            // lblHomeHeader
            // 
            lblHomeHeader.AutoSize = true;
            lblHomeHeader.BackColor = Color.White;
            lblHomeHeader.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold);
            lblHomeHeader.ForeColor = Color.FromArgb(31, 41, 51);
            lblHomeHeader.Location = new Point(4, 4);
            lblHomeHeader.Name = "lblHomeHeader";
            lblHomeHeader.Size = new Size(243, 37);
            lblHomeHeader.TabIndex = 0;
            lblHomeHeader.Text = "User information";
            // 
            // lvWarnings
            // 
            lvWarnings.Columns.AddRange(new ColumnHeader[] { colWarningReason, colWarningSent, colWarningMessage });
            lvWarnings.Font = new Font("Segoe UI", 10.5F);
            lvWarnings.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12 });
            lvWarnings.Location = new Point(24, 398);
            lvWarnings.Name = "lvWarnings";
            lvWarnings.Size = new Size(480, 290);
            lvWarnings.TabIndex = 0;
            lvWarnings.UseCompatibleStateImageBehavior = false;
            lvWarnings.View = View.Details;
            // 
            // colWarningReason
            // 
            colWarningReason.Text = "Reason";
            colWarningReason.Width = 140;
            // 
            // colWarningSent
            // 
            colWarningSent.Text = "Sent";
            colWarningSent.Width = 90;
            // 
            // colWarningMessage
            // 
            colWarningMessage.Text = "Message";
            colWarningMessage.Width = 231;
            // 
            // lvRequests
            // 
            lvRequests.Columns.AddRange(new ColumnHeader[] { colRequestSubject, colRequestDue, colRequestStatus });
            lvRequests.Font = new Font("Segoe UI", 10.5F);
            lvRequests.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15 });
            lvRequests.Location = new Point(516, 398);
            lvRequests.Name = "lvRequests";
            lvRequests.Size = new Size(480, 290);
            lvRequests.TabIndex = 1;
            lvRequests.UseCompatibleStateImageBehavior = false;
            lvRequests.View = View.Details;
            // 
            // colRequestSubject
            // 
            colRequestSubject.Text = "Subject";
            colRequestSubject.Width = 200;
            // 
            // colRequestDue
            // 
            colRequestDue.Text = "Due";
            colRequestDue.Width = 100;
            // 
            // colRequestStatus
            // 
            colRequestStatus.Text = "Status";
            colRequestStatus.Width = 161;
            // 
            // lvBugReports
            // 
            lvBugReports.Columns.AddRange(new ColumnHeader[] { colBugDescription, colBugReported, colBugStatus });
            lvBugReports.Font = new Font("Segoe UI", 10.5F);
            lvBugReports.Items.AddRange(new ListViewItem[] { listViewItem16, listViewItem17, listViewItem18 });
            lvBugReports.Location = new Point(1008, 398);
            lvBugReports.Name = "lvBugReports";
            lvBugReports.Size = new Size(480, 290);
            lvBugReports.TabIndex = 2;
            lvBugReports.UseCompatibleStateImageBehavior = false;
            lvBugReports.View = View.Details;
            // 
            // colBugDescription
            // 
            colBugDescription.Text = "Description";
            colBugDescription.Width = 230;
            // 
            // colBugReported
            // 
            colBugReported.Text = "Reported";
            colBugReported.Width = 100;
            // 
            // colBugStatus
            // 
            colBugStatus.Text = "Status";
            colBugStatus.Width = 131;
            // 
            // lblWarningsCaption
            // 
            lblWarningsCaption.AutoSize = true;
            lblWarningsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblWarningsCaption.Location = new Point(24, 366);
            lblWarningsCaption.Name = "lblWarningsCaption";
            lblWarningsCaption.Size = new Size(131, 24);
            lblWarningsCaption.TabIndex = 29;
            lblWarningsCaption.Text = "Warnings sent";
            // 
            // lblRequestsCaption
            // 
            lblRequestsCaption.AutoSize = true;
            lblRequestsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblRequestsCaption.Location = new Point(516, 366);
            lblRequestsCaption.Name = "lblRequestsCaption";
            lblRequestsCaption.Size = new Size(189, 24);
            lblRequestsCaption.TabIndex = 29;
            lblRequestsCaption.Text = "Information requests";
            // 
            // lblReportsCaption
            // 
            lblReportsCaption.AutoSize = true;
            lblReportsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblReportsCaption.Location = new Point(1008, 366);
            lblReportsCaption.Name = "lblReportsCaption";
            lblReportsCaption.Size = new Size(110, 24);
            lblReportsCaption.TabIndex = 29;
            lblReportsCaption.Text = "Bug reports";
            // 
            // identityBlockHome
            // 
            identityBlockHome.Age = "26";
            identityBlockHome.Birthday = "14/04/1999";
            identityBlockHome.Email = "example@gmail.com";
            identityBlockHome.Ethnicity = "European";
            identityBlockHome.Gender = "Male";
            identityBlockHome.Location = new Point(24, 88);
            identityBlockHome.Name = "identityBlockHome";
            identityBlockHome.NationalID = "241-21443553423-11212-42";
            identityBlockHome.Size = new Size(1464, 266);
            identityBlockHome.TabIndex = 30;
            identityBlockHome.UserId = new Guid("cb5bc404-7f64-43c0-babc-c761b3ec1a98");
            identityBlockHome.UserImage = null;
            identityBlockHome.UserName = "Jacob";
            // 
            // AdminHomeView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(identityBlockHome);
            Controls.Add(lblReportsCaption);
            Controls.Add(lblRequestsCaption);
            Controls.Add(lblWarningsCaption);
            Controls.Add(lvBugReports);
            Controls.Add(lvRequests);
            Controls.Add(lvWarnings);
            Controls.Add(pnlHomeHeader);
            Name = "AdminHomeView";
            Size = new Size(1512, 712);
            pnlHomeHeader.ResumeLayout(false);
            pnlHomeHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHomeHeader;
        private Label lblHomeHeader;
        private ListView lvWarnings;
        private ListView lvRequests;
        private ListView lvBugReports;
        private ColumnHeader colWarningReason;
        private ColumnHeader colWarningSent;
        private ColumnHeader colWarningMessage;
        private ColumnHeader colRequestSubject;
        private ColumnHeader colRequestDue;
        private ColumnHeader colRequestStatus;
        private ColumnHeader colBugDescription;
        private ColumnHeader colBugReported;
        private ColumnHeader colBugStatus;
        private Label lblWarningsCaption;
        private Label lblRequestsCaption;
        private Label lblReportsCaption;
        private IdentityBlockView identityBlockHome;
    }
}
