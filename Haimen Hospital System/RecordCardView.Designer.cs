namespace Haimen_Hospital_System
{
    partial class RecordCardView
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
            lblRecordNo = new Label();
            lblDateCaption = new Label();
            lblPresCaption = new Label();
            lbldate = new Label();
            lblpers = new Label();
            lblDiagCaption = new Label();
            lbldiagnoses = new Label();
            lblrecId = new Label();
            picFolderIcon = new PictureBox();
            lblDoctorIdCaption = new Label();
            lblDoctorId = new Label();
            btnChooseRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)picFolderIcon).BeginInit();
            SuspendLayout();
            // 
            // lblRecordNo
            // 
            lblRecordNo.AutoSize = true;
            lblRecordNo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblRecordNo.Location = new Point(16, 12);
            lblRecordNo.Name = "lblRecordNo";
            lblRecordNo.Size = new Size(79, 19);
            lblRecordNo.TabIndex = 0;
            lblRecordNo.Text = "Record ID:";
            // 
            // lblDateCaption
            // 
            lblDateCaption.AutoSize = true;
            lblDateCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDateCaption.Location = new Point(16, 44);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(44, 19);
            lblDateCaption.TabIndex = 0;
            lblDateCaption.Text = "Date:";
            // 
            // lblPresCaption
            // 
            lblPresCaption.AutoSize = true;
            lblPresCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPresCaption.Location = new Point(16, 96);
            lblPresCaption.Name = "lblPresCaption";
            lblPresCaption.Size = new Size(94, 19);
            lblPresCaption.TabIndex = 0;
            lblPresCaption.Text = "Prescription:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 10.5F);
            lbldate.Location = new Point(66, 44);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(0, 19);
            lbldate.TabIndex = 2;
            // 
            // lblpers
            // 
            lblpers.AutoSize = true;
            lblpers.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblpers.Location = new Point(114, 96);
            lblpers.Name = "lblpers";
            lblpers.Size = new Size(0, 19);
            lblpers.TabIndex = 3;
            // 
            // lblDiagCaption
            // 
            lblDiagCaption.AutoSize = true;
            lblDiagCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDiagCaption.Location = new Point(16, 70);
            lblDiagCaption.Name = "lblDiagCaption";
            lblDiagCaption.Size = new Size(81, 19);
            lblDiagCaption.TabIndex = 0;
            lblDiagCaption.Text = "Diagnoses:";
            // 
            // lbldiagnoses
            // 
            lbldiagnoses.AutoSize = true;
            lbldiagnoses.Font = new Font("Segoe UI", 10.5F);
            lbldiagnoses.Location = new Point(106, 70);
            lbldiagnoses.Name = "lbldiagnoses";
            lbldiagnoses.Size = new Size(0, 19);
            lbldiagnoses.TabIndex = 2;
            // 
            // lblrecId
            // 
            lblrecId.AutoSize = true;
            lblrecId.Font = new Font("Segoe UI", 10.5F);
            lblrecId.Location = new Point(97, 12);
            lblrecId.Name = "lblrecId";
            lblrecId.Size = new Size(0, 19);
            lblrecId.TabIndex = 2;
            // 
            // picFolderIcon
            // 
            picFolderIcon.Image = Properties.Resources.Folder_icon;
            picFolderIcon.Location = new Point(473, 3);
            picFolderIcon.Name = "picFolderIcon";
            picFolderIcon.Size = new Size(50, 50);
            picFolderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picFolderIcon.TabIndex = 4;
            picFolderIcon.TabStop = false;
            // 
            // lblDoctorIdCaption
            // 
            lblDoctorIdCaption.AutoSize = true;
            lblDoctorIdCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblDoctorIdCaption.Location = new Point(202, 12);
            lblDoctorIdCaption.Name = "lblDoctorIdCaption";
            lblDoctorIdCaption.Size = new Size(77, 19);
            lblDoctorIdCaption.TabIndex = 0;
            lblDoctorIdCaption.Text = "Doctor ID:";
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Font = new Font("Segoe UI", 10.5F);
            lblDoctorId.Location = new Point(287, 12);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(0, 19);
            lblDoctorId.TabIndex = 2;
            // 
            // btnChooseRecord
            // 
            btnChooseRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseRecord.Location = new Point(427, 89);
            btnChooseRecord.Name = "btnChooseRecord";
            btnChooseRecord.Size = new Size(96, 34);
            btnChooseRecord.TabIndex = 5;
            btnChooseRecord.Text = "Select";
            btnChooseRecord.UseVisualStyleBackColor = true;
            // 
            // RecordCardView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(btnChooseRecord);
            Controls.Add(picFolderIcon);
            Controls.Add(lblpers);
            Controls.Add(lblDoctorId);
            Controls.Add(lblrecId);
            Controls.Add(lbldate);
            Controls.Add(lblDoctorIdCaption);
            Controls.Add(lblRecordNo);
            Controls.Add(lbldiagnoses);
            Controls.Add(lblDateCaption);
            Controls.Add(lblPresCaption);
            Controls.Add(lblDiagCaption);
            Name = "RecordCardView";
            Size = new Size(526, 130);
            ((System.ComponentModel.ISupportInitialize)picFolderIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordNo;
        private Label lblDateCaption;
        private Label lblPresCaption;
        private Label lbldate;
        private Label lblpers;
        private Label lblDiagCaption;
        private Label lbldiagnoses;
        private Label lblrecId;
        private PictureBox picFolderIcon;
        private Label lblDoctorIdCaption;
        private Label lblDoctorId;
        private Button btnChooseRecord;
    }
}
