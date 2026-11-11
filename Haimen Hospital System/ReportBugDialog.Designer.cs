namespace Haimen_Hospital_System
{
    partial class ReportBugDialog
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
            lblReportTitle = new Label();
            pnlReportTopDivider = new Panel();
            lblDescCaption = new Label();
            txtBugDescription = new TextBox();
            pnlReportBottomDivider = new Panel();
            btnSendReport = new Button();
            btnReportCancel = new Button();
            SuspendLayout();
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblReportTitle.Location = new Point(24, 16);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(189, 38);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Report a Bug";
            // 
            // pnlReportTopDivider
            // 
            pnlReportTopDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlReportTopDivider.ForeColor = Color.White;
            pnlReportTopDivider.Location = new Point(24, 60);
            pnlReportTopDivider.Name = "pnlReportTopDivider";
            pnlReportTopDivider.Size = new Size(432, 10);
            pnlReportTopDivider.TabIndex = 18;
            // 
            // lblDescCaption
            // 
            lblDescCaption.AutoSize = true;
            lblDescCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblDescCaption.Location = new Point(24, 76);
            lblDescCaption.Name = "lblDescCaption";
            lblDescCaption.Size = new Size(196, 25);
            lblDescCaption.TabIndex = 0;
            lblDescCaption.Text = "Describe the problem:";
            // 
            // txtBugDescription
            // 
            txtBugDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBugDescription.Cursor = Cursors.IBeam;
            txtBugDescription.Font = new Font("Segoe UI", 10.5F);
            txtBugDescription.Location = new Point(24, 100);
            txtBugDescription.Multiline = true;
            txtBugDescription.Name = "txtBugDescription";
            txtBugDescription.Size = new Size(432, 160);
            txtBugDescription.TabIndex = 0;
            // 
            // pnlReportBottomDivider
            // 
            pnlReportBottomDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlReportBottomDivider.ForeColor = Color.White;
            pnlReportBottomDivider.Location = new Point(24, 272);
            pnlReportBottomDivider.Name = "pnlReportBottomDivider";
            pnlReportBottomDivider.Size = new Size(432, 4);
            pnlReportBottomDivider.TabIndex = 18;
            // 
            // btnSendReport
            // 
            btnSendReport.BackColor = Color.FromArgb(15, 108, 189);
            btnSendReport.FlatAppearance.BorderSize = 0;
            btnSendReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnSendReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnSendReport.FlatStyle = FlatStyle.Flat;
            btnSendReport.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSendReport.ForeColor = Color.White;
            btnSendReport.Location = new Point(326, 284);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(130, 37);
            btnSendReport.TabIndex = 1;
            btnSendReport.Text = "Send Report";
            btnSendReport.UseVisualStyleBackColor = false;
            // 
            // btnReportCancel
            // 
            btnReportCancel.BackColor = Color.White;
            btnReportCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnReportCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnReportCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnReportCancel.FlatStyle = FlatStyle.Flat;
            btnReportCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnReportCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnReportCancel.Location = new Point(210, 284);
            btnReportCancel.Name = "btnReportCancel";
            btnReportCancel.Size = new Size(104, 37);
            btnReportCancel.TabIndex = 2;
            btnReportCancel.Text = "Cancel";
            btnReportCancel.UseVisualStyleBackColor = false;
            // 
            // ReportBugDialog
            // 
            AcceptButton = btnSendReport;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            CancelButton = btnReportCancel;
            ClientSize = new Size(480, 345);
            Controls.Add(btnSendReport);
            Controls.Add(btnReportCancel);
            Controls.Add(txtBugDescription);
            Controls.Add(pnlReportBottomDivider);
            Controls.Add(pnlReportTopDivider);
            Controls.Add(lblDescCaption);
            Controls.Add(lblReportTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportBugDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Report a bug";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportTitle;
        private Panel pnlReportTopDivider;
        private Label lblDescCaption;
        private TextBox txtBugDescription;
        private Panel pnlReportBottomDivider;
        private Button btnSendReport;
        private Button btnReportCancel;
    }
}