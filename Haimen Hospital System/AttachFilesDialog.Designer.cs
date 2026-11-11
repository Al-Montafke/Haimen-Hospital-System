namespace Haimen_Hospital_System
{
    partial class AttachFilesDialog
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
            lblAttachTitle = new Label();
            pnlAttachBottomDivider = new Panel();
            pnlAttachTopDivider = new Panel();
            lblFileCaption = new Label();
            txtFilePath = new TextBox();
            lblNameCaption = new Label();
            txtFileName = new TextBox();
            lblFormatCaption = new Label();
            txtFileFormat = new TextBox();
            lblSizeCaption = new Label();
            txtFileSize = new TextBox();
            lblFileDescCaption = new Label();
            txtFileDescription = new TextBox();
            btnAttachConfirm = new Button();
            btnAttachCancel = new Button();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // lblAttachTitle
            // 
            lblAttachTitle.AutoSize = true;
            lblAttachTitle.BackColor = Color.FromArgb(243, 246, 249);
            lblAttachTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttachTitle.ForeColor = Color.FromArgb(31, 41, 51);
            lblAttachTitle.Location = new Point(24, 16);
            lblAttachTitle.Name = "lblAttachTitle";
            lblAttachTitle.Size = new Size(180, 38);
            lblAttachTitle.TabIndex = 0;
            lblAttachTitle.Text = "Attach a File";
            // 
            // pnlAttachBottomDivider
            // 
            pnlAttachBottomDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlAttachBottomDivider.ForeColor = Color.White;
            pnlAttachBottomDivider.Location = new Point(24, 326);
            pnlAttachBottomDivider.Name = "pnlAttachBottomDivider";
            pnlAttachBottomDivider.Size = new Size(512, 4);
            pnlAttachBottomDivider.TabIndex = 19;
            // 
            // pnlAttachTopDivider
            // 
            pnlAttachTopDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlAttachTopDivider.ForeColor = Color.White;
            pnlAttachTopDivider.Location = new Point(24, 60);
            pnlAttachTopDivider.Name = "pnlAttachTopDivider";
            pnlAttachTopDivider.Size = new Size(512, 10);
            pnlAttachTopDivider.TabIndex = 20;
            // 
            // lblFileCaption
            // 
            lblFileCaption.AutoSize = true;
            lblFileCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblFileCaption.Location = new Point(24, 84);
            lblFileCaption.Name = "lblFileCaption";
            lblFileCaption.Size = new Size(34, 19);
            lblFileCaption.TabIndex = 21;
            lblFileCaption.Text = "File:";
            // 
            // txtFilePath
            // 
            txtFilePath.BorderStyle = BorderStyle.FixedSingle;
            txtFilePath.Font = new Font("Segoe UI", 10.5F);
            txtFilePath.Location = new Point(100, 80);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(332, 26);
            txtFilePath.TabIndex = 0;
            // 
            // lblNameCaption
            // 
            lblNameCaption.AutoSize = true;
            lblNameCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblNameCaption.Location = new Point(24, 124);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(49, 19);
            lblNameCaption.TabIndex = 24;
            lblNameCaption.Text = "Name:";
            // 
            // txtFileName
            // 
            txtFileName.BorderStyle = BorderStyle.FixedSingle;
            txtFileName.Font = new Font("Segoe UI", 10.5F);
            txtFileName.Location = new Point(100, 120);
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "P3423-26-0231.png";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(436, 26);
            txtFileName.TabIndex = 22;
            txtFileName.TabStop = false;
            // 
            // lblFormatCaption
            // 
            lblFormatCaption.AutoSize = true;
            lblFormatCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblFormatCaption.Location = new Point(24, 160);
            lblFormatCaption.Name = "lblFormatCaption";
            lblFormatCaption.Size = new Size(56, 19);
            lblFormatCaption.TabIndex = 24;
            lblFormatCaption.Text = "Format:";
            // 
            // txtFileFormat
            // 
            txtFileFormat.BorderStyle = BorderStyle.FixedSingle;
            txtFileFormat.Font = new Font("Segoe UI", 10.5F);
            txtFileFormat.Location = new Point(100, 156);
            txtFileFormat.Name = "txtFileFormat";
            txtFileFormat.PlaceholderText = "PNG";
            txtFileFormat.ReadOnly = true;
            txtFileFormat.Size = new Size(150, 26);
            txtFileFormat.TabIndex = 22;
            txtFileFormat.TabStop = false;
            // 
            // lblSizeCaption
            // 
            lblSizeCaption.AutoSize = true;
            lblSizeCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSizeCaption.Location = new Point(270, 160);
            lblSizeCaption.Name = "lblSizeCaption";
            lblSizeCaption.Size = new Size(38, 19);
            lblSizeCaption.TabIndex = 24;
            lblSizeCaption.Text = "Size:";
            // 
            // txtFileSize
            // 
            txtFileSize.BorderStyle = BorderStyle.FixedSingle;
            txtFileSize.Font = new Font("Segoe UI", 10.5F);
            txtFileSize.Location = new Point(320, 156);
            txtFileSize.Name = "txtFileSize";
            txtFileSize.PlaceholderText = "24.1KB";
            txtFileSize.ReadOnly = true;
            txtFileSize.Size = new Size(120, 26);
            txtFileSize.TabIndex = 22;
            txtFileSize.TabStop = false;
            // 
            // lblFileDescCaption
            // 
            lblFileDescCaption.AutoSize = true;
            lblFileDescCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblFileDescCaption.Location = new Point(24, 196);
            lblFileDescCaption.Name = "lblFileDescCaption";
            lblFileDescCaption.Size = new Size(84, 19);
            lblFileDescCaption.TabIndex = 24;
            lblFileDescCaption.Text = "Description:";
            // 
            // txtFileDescription
            // 
            txtFileDescription.BorderStyle = BorderStyle.FixedSingle;
            txtFileDescription.Font = new Font("Segoe UI", 10.5F);
            txtFileDescription.Location = new Point(24, 220);
            txtFileDescription.Multiline = true;
            txtFileDescription.Name = "txtFileDescription";
            txtFileDescription.Size = new Size(512, 90);
            txtFileDescription.TabIndex = 2;
            // 
            // btnAttachConfirm
            // 
            btnAttachConfirm.BackColor = Color.FromArgb(15, 108, 189);
            btnAttachConfirm.FlatAppearance.BorderSize = 0;
            btnAttachConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnAttachConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnAttachConfirm.FlatStyle = FlatStyle.Flat;
            btnAttachConfirm.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnAttachConfirm.ForeColor = Color.White;
            btnAttachConfirm.Location = new Point(416, 338);
            btnAttachConfirm.Name = "btnAttachConfirm";
            btnAttachConfirm.Size = new Size(120, 37);
            btnAttachConfirm.TabIndex = 3;
            btnAttachConfirm.Text = "Attach File";
            btnAttachConfirm.UseVisualStyleBackColor = false;
            // 
            // btnAttachCancel
            // 
            btnAttachCancel.BackColor = Color.White;
            btnAttachCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnAttachCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnAttachCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnAttachCancel.FlatStyle = FlatStyle.Flat;
            btnAttachCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnAttachCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnAttachCancel.Location = new Point(300, 338);
            btnAttachCancel.Name = "btnAttachCancel";
            btnAttachCancel.Size = new Size(104, 37);
            btnAttachCancel.TabIndex = 4;
            btnAttachCancel.Text = "Cancel";
            btnAttachCancel.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.White;
            btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.FromArgb(31, 41, 51);
            btnBrowse.Location = new Point(440, 78);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(96, 30);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // AttachFilesDialog
            // 
            AcceptButton = btnAttachConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            CancelButton = btnAttachCancel;
            ClientSize = new Size(560, 399);
            Controls.Add(btnBrowse);
            Controls.Add(btnAttachConfirm);
            Controls.Add(btnAttachCancel);
            Controls.Add(lblSizeCaption);
            Controls.Add(lblFileDescCaption);
            Controls.Add(lblFormatCaption);
            Controls.Add(lblNameCaption);
            Controls.Add(txtFileDescription);
            Controls.Add(txtFileSize);
            Controls.Add(txtFileFormat);
            Controls.Add(txtFileName);
            Controls.Add(txtFilePath);
            Controls.Add(lblFileCaption);
            Controls.Add(pnlAttachBottomDivider);
            Controls.Add(pnlAttachTopDivider);
            Controls.Add(lblAttachTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AttachFilesDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Attach Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAttachTitle;
        private Panel pnlAttachBottomDivider;
        private Panel pnlAttachTopDivider;
        private Label lblFileCaption;
        private TextBox txtFilePath;
        private Label lblNameCaption;
        private TextBox txtFileName;
        private Label lblFormatCaption;
        private TextBox txtFileFormat;
        private Label lblSizeCaption;
        private TextBox txtFileSize;
        private Label lblFileDescCaption;
        private TextBox txtFileDescription;
        private Button btnAttachConfirm;
        private Button btnAttachCancel;
        private Button btnBrowse;
    }
}