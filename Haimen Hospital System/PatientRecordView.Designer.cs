namespace Haimen_Hospital_System
{
    partial class PatientRecordView
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
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Rip", "PNG", "30KB", "Last modified: Yesterda" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Broken bone (left arm)", "JPG", "21.80KB", "..." }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRecordView));
            lblPageTitle = new Label();
            pnldivider = new Panel();
            identityBlockPatient = new IdentityBlockView();
            lblEditCaption = new Label();
            flowRecords = new FlowLayoutPanel();
            pnlRecordEdit = new Panel();
            recordCardSample1 = new RecordCardView();
            recordCardSample2 = new RecordCardView();
            txtEditDiagnoses = new TextBox();
            txtEditPrescription = new TextBox();
            txtEditNotes = new TextBox();
            lvEditAttachments = new ListView();
            btnRemoveAttachment = new Button();
            btnAttachFiles = new Button();
            btnSaveRecord = new Button();
            colEditName = new ColumnHeader();
            colEditFormat = new ColumnHeader();
            colEditSize = new ColumnHeader();
            colEditDescription = new ColumnHeader();
            lblEditDiagnosesCaption = new Label();
            lblEditNotesCaption = new Label();
            lblEditPrescriptionCaption = new Label();
            lblEditAttachmentsCaption = new Label();
            lblRecordsCaption = new Label();
            recordCardSample3 = new RecordCardView();
            flowRecords.SuspendLayout();
            pnlRecordEdit.SuspendLayout();
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
            lblPageTitle.Size = new Size(319, 38);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Patient Medical Record";
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
            // identityBlockPatient
            // 
            identityBlockPatient.Age = "26";
            identityBlockPatient.Birthday = "14/04/1999";
            identityBlockPatient.Email = "example@gmail.com";
            identityBlockPatient.Ethnicity = "European";
            identityBlockPatient.Gender = "Male";
            identityBlockPatient.Location = new Point(24, 76);
            identityBlockPatient.Name = "identityBlockPatient";
            identityBlockPatient.NationalID = "241-21443553423-11212-44";
            identityBlockPatient.Size = new Size(1464, 266);
            identityBlockPatient.TabIndex = 8;
            identityBlockPatient.UserId = new Guid("661736b1-3d79-4664-9601-fa05e3871d54");
            identityBlockPatient.UserImage = Properties.Resources.Gemini_Generated_Image_5o38gp5o38gp5o38;
            identityBlockPatient.UserName = "Jacob";
            // 
            // lblEditCaption
            // 
            lblEditCaption.AutoSize = true;
            lblEditCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblEditCaption.Location = new Point(596, 354);
            lblEditCaption.Name = "lblEditCaption";
            lblEditCaption.Size = new Size(132, 25);
            lblEditCaption.TabIndex = 9;
            lblEditCaption.Text = "Update record";
            // 
            // flowRecords
            // 
            flowRecords.AutoScroll = true;
            flowRecords.Controls.Add(recordCardSample1);
            flowRecords.Controls.Add(recordCardSample3);
            flowRecords.Controls.Add(recordCardSample2);
            flowRecords.FlowDirection = FlowDirection.TopDown;
            flowRecords.Location = new Point(24, 386);
            flowRecords.Name = "flowRecords";
            flowRecords.Size = new Size(560, 302);
            flowRecords.TabIndex = 0;
            flowRecords.WrapContents = false;
            // 
            // pnlRecordEdit
            // 
            pnlRecordEdit.BackColor = Color.White;
            pnlRecordEdit.BorderStyle = BorderStyle.FixedSingle;
            pnlRecordEdit.Controls.Add(btnSaveRecord);
            pnlRecordEdit.Controls.Add(btnAttachFiles);
            pnlRecordEdit.Controls.Add(lblEditNotesCaption);
            pnlRecordEdit.Controls.Add(lblEditAttachmentsCaption);
            pnlRecordEdit.Controls.Add(lblEditPrescriptionCaption);
            pnlRecordEdit.Controls.Add(lblEditDiagnosesCaption);
            pnlRecordEdit.Controls.Add(btnRemoveAttachment);
            pnlRecordEdit.Controls.Add(lvEditAttachments);
            pnlRecordEdit.Controls.Add(txtEditNotes);
            pnlRecordEdit.Controls.Add(txtEditPrescription);
            pnlRecordEdit.Controls.Add(txtEditDiagnoses);
            pnlRecordEdit.Location = new Point(596, 386);
            pnlRecordEdit.Name = "pnlRecordEdit";
            pnlRecordEdit.Size = new Size(892, 302);
            pnlRecordEdit.TabIndex = 11;
            // 
            // recordCardSample1
            // 
            recordCardSample1.Diagnoses = "Lung Cancer - stage 4";
            recordCardSample1.DoctorId = new Guid("a1884e71-34f1-4cd6-90bb-6120d95cc806");
            recordCardSample1.Location = new Point(0, 0);
            recordCardSample1.Margin = new Padding(0, 0, 0, 6);
            recordCardSample1.Name = "recordCardSample1";
            recordCardSample1.Prescription = "Advanced Chemical Operation";
            recordCardSample1.RecordDate = "07/12/2026";
            recordCardSample1.RecordId = new Guid("d087f092-955e-485d-96a7-6a92312eb043");
            recordCardSample1.Size = new Size(526, 130);
            recordCardSample1.TabIndex = 0;
            // 
            // recordCardSample2
            // 
            recordCardSample2.Diagnoses = "Acute Strep Pharyngitis";
            recordCardSample2.DoctorId = new Guid("820a8781-4c6a-4366-8c2a-aea12ce2d247");
            recordCardSample2.Location = new Point(0, 272);
            recordCardSample2.Margin = new Padding(0, 0, 0, 6);
            recordCardSample2.Name = "recordCardSample2";
            recordCardSample2.Prescription = "• Amoxicillin 500mg\n• Sig: Take 1 tablet by mouth every 12 hours for 10 days.\n• Dispense: 20 tablets\n• Refills: 0";
            recordCardSample2.RecordDate = "07/12/2026";
            recordCardSample2.RecordId = new Guid("cd2572da-9702-4f64-9d09-51e8bcb26174");
            recordCardSample2.Size = new Size(526, 130);
            recordCardSample2.TabIndex = 1;
            // 
            // txtEditDiagnoses
            // 
            txtEditDiagnoses.Font = new Font("Segoe UI", 10.5F);
            txtEditDiagnoses.Location = new Point(12, 32);
            txtEditDiagnoses.Multiline = true;
            txtEditDiagnoses.Name = "txtEditDiagnoses";
            txtEditDiagnoses.Size = new Size(424, 72);
            txtEditDiagnoses.TabIndex = 0;
            // 
            // txtEditPrescription
            // 
            txtEditPrescription.Font = new Font("Segoe UI", 10.5F);
            txtEditPrescription.Location = new Point(12, 134);
            txtEditPrescription.Multiline = true;
            txtEditPrescription.Name = "txtEditPrescription";
            txtEditPrescription.Size = new Size(424, 72);
            txtEditPrescription.TabIndex = 2;
            // 
            // txtEditNotes
            // 
            txtEditNotes.Font = new Font("Segoe UI", 10.5F);
            txtEditNotes.Location = new Point(448, 32);
            txtEditNotes.Multiline = true;
            txtEditNotes.Name = "txtEditNotes";
            txtEditNotes.Size = new Size(430, 72);
            txtEditNotes.TabIndex = 1;
            // 
            // lvEditAttachments
            // 
            lvEditAttachments.Columns.AddRange(new ColumnHeader[] { colEditName, colEditFormat, colEditSize, colEditDescription });
            lvEditAttachments.Font = new Font("Segoe UI", 10.5F);
            lvEditAttachments.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8 });
            lvEditAttachments.Location = new Point(448, 134);
            lvEditAttachments.Name = "lvEditAttachments";
            lvEditAttachments.Size = new Size(430, 112);
            lvEditAttachments.TabIndex = 3;
            lvEditAttachments.UseCompatibleStateImageBehavior = false;
            lvEditAttachments.View = View.Details;
            // 
            // btnRemoveAttachment
            // 
            btnRemoveAttachment.BackColor = Color.White;
            btnRemoveAttachment.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnRemoveAttachment.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRemoveAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnRemoveAttachment.FlatStyle = FlatStyle.Flat;
            btnRemoveAttachment.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnRemoveAttachment.ForeColor = Color.FromArgb(31, 41, 51);
            btnRemoveAttachment.Location = new Point(526, 254);
            btnRemoveAttachment.Name = "btnRemoveAttachment";
            btnRemoveAttachment.Size = new Size(104, 37);
            btnRemoveAttachment.TabIndex = 4;
            btnRemoveAttachment.Text = "Remove";
            btnRemoveAttachment.UseVisualStyleBackColor = false;
            // 
            // btnAttachFiles
            // 
            btnAttachFiles.BackColor = Color.FromArgb(15, 108, 189);
            btnAttachFiles.FlatAppearance.BorderSize = 0;
            btnAttachFiles.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnAttachFiles.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnAttachFiles.FlatStyle = FlatStyle.Flat;
            btnAttachFiles.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnAttachFiles.ForeColor = Color.White;
            btnAttachFiles.Location = new Point(642, 254);
            btnAttachFiles.Name = "btnAttachFiles";
            btnAttachFiles.Size = new Size(120, 37);
            btnAttachFiles.TabIndex = 5;
            btnAttachFiles.Text = "Attach";
            btnAttachFiles.UseVisualStyleBackColor = false;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = Color.FromArgb(15, 108, 189);
            btnSaveRecord.FlatAppearance.BorderSize = 0;
            btnSaveRecord.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnSaveRecord.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnSaveRecord.FlatStyle = FlatStyle.Flat;
            btnSaveRecord.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnSaveRecord.ForeColor = Color.White;
            btnSaveRecord.Location = new Point(774, 254);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(104, 37);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "Save";
            btnSaveRecord.UseVisualStyleBackColor = false;
            // 
            // colEditName
            // 
            colEditName.Text = "Name";
            colEditName.Width = 150;
            // 
            // colEditFormat
            // 
            colEditFormat.Text = "Format";
            colEditFormat.Width = 70;
            // 
            // colEditSize
            // 
            colEditSize.Text = "Size";
            colEditSize.Width = 70;
            // 
            // colEditDescription
            // 
            colEditDescription.Text = "Description";
            colEditDescription.Width = 120;
            // 
            // lblEditDiagnosesCaption
            // 
            lblEditDiagnosesCaption.AutoSize = true;
            lblEditDiagnosesCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblEditDiagnosesCaption.Location = new Point(12, 10);
            lblEditDiagnosesCaption.Name = "lblEditDiagnosesCaption";
            lblEditDiagnosesCaption.Size = new Size(104, 19);
            lblEditDiagnosesCaption.TabIndex = 9;
            lblEditDiagnosesCaption.Text = "Edit Diagnoses:";
            // 
            // lblEditNotesCaption
            // 
            lblEditNotesCaption.AutoSize = true;
            lblEditNotesCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblEditNotesCaption.Location = new Point(448, 10);
            lblEditNotesCaption.Name = "lblEditNotesCaption";
            lblEditNotesCaption.Size = new Size(77, 19);
            lblEditNotesCaption.TabIndex = 9;
            lblEditNotesCaption.Text = "Edit Notes:";
            // 
            // lblEditPrescriptionCaption
            // 
            lblEditPrescriptionCaption.AutoSize = true;
            lblEditPrescriptionCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblEditPrescriptionCaption.Location = new Point(12, 112);
            lblEditPrescriptionCaption.Name = "lblEditPrescriptionCaption";
            lblEditPrescriptionCaption.Size = new Size(115, 19);
            lblEditPrescriptionCaption.TabIndex = 9;
            lblEditPrescriptionCaption.Text = "Edit Prescription:";
            // 
            // lblEditAttachmentsCaption
            // 
            lblEditAttachmentsCaption.AutoSize = true;
            lblEditAttachmentsCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblEditAttachmentsCaption.Location = new Point(448, 112);
            lblEditAttachmentsCaption.Name = "lblEditAttachmentsCaption";
            lblEditAttachmentsCaption.Size = new Size(119, 19);
            lblEditAttachmentsCaption.TabIndex = 9;
            lblEditAttachmentsCaption.Text = "Edit Attachments:";
            // 
            // lblRecordsCaption
            // 
            lblRecordsCaption.AutoSize = true;
            lblRecordsCaption.BackColor = Color.Transparent;
            lblRecordsCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblRecordsCaption.Location = new Point(24, 354);
            lblRecordsCaption.Name = "lblRecordsCaption";
            lblRecordsCaption.Size = new Size(78, 25);
            lblRecordsCaption.TabIndex = 9;
            lblRecordsCaption.Text = "Records";
            // 
            // recordCardSample3
            // 
            recordCardSample3.Diagnoses = "Acute Uncomplicated Urinary Tract Infection";
            recordCardSample3.DoctorId = new Guid("4b745d57-9cdd-4b45-b760-cfba5a487e35");
            recordCardSample3.Location = new Point(0, 136);
            recordCardSample3.Margin = new Padding(0, 0, 0, 6);
            recordCardSample3.Name = "recordCardSample3";
            recordCardSample3.Prescription = resources.GetString("recordCardSample3.Prescription");
            recordCardSample3.RecordDate = "March 14, 2025";
            recordCardSample3.RecordId = new Guid("de120df3-3ac9-4bbb-a2a0-6672b250a28f");
            recordCardSample3.Size = new Size(526, 130);
            recordCardSample3.TabIndex = 2;
            // 
            // PatientRecordView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(pnlRecordEdit);
            Controls.Add(flowRecords);
            Controls.Add(lblRecordsCaption);
            Controls.Add(lblEditCaption);
            Controls.Add(identityBlockPatient);
            Controls.Add(pnldivider);
            Controls.Add(lblPageTitle);
            Name = "PatientRecordView";
            Size = new Size(1512, 712);
            flowRecords.ResumeLayout(false);
            pnlRecordEdit.ResumeLayout(false);
            pnlRecordEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private IdentityBlockView identityBlockPatient;
        private Label lblEditCaption;
        private FlowLayoutPanel flowRecords;
        private Panel pnlRecordEdit;
        private RecordCardView recordCardSample1;
        private RecordCardView recordCardSample2;
        private ListView lvEditAttachments;
        private TextBox txtEditNotes;
        private TextBox txtEditPrescription;
        private TextBox txtEditDiagnoses;
        private Button btnRemoveAttachment;
        private Button btnSaveRecord;
        private Button btnAttachFiles;
        private ColumnHeader colEditName;
        private ColumnHeader colEditFormat;
        private ColumnHeader colEditSize;
        private ColumnHeader colEditDescription;
        private Label lblEditNotesCaption;
        private Label lblEditAttachmentsCaption;
        private Label lblEditPrescriptionCaption;
        private Label lblEditDiagnosesCaption;
        private Label lblRecordsCaption;
        private RecordCardView recordCardSample3;
    }
}
