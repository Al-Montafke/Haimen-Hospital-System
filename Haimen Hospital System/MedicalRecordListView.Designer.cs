namespace Haimen_Hospital_System
{
    partial class MedicalRecordListView
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Images.pdf", "PDF", "27.5KB", "..." }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Xray-result.pdf", "PDF", "21.76KB", "..." }, -1);
            lblPageTitle = new Label();
            pnldivider = new Panel();
            flowRecords = new FlowLayoutPanel();
            recordCardView1 = new RecordCardView();
            recordCardView2 = new RecordCardView();
            recordCardView3 = new RecordCardView();
            recordCardView4 = new RecordCardView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchCaption = new Label();
            pnlDetails = new Panel();
            lblDetailsCaption = new Label();
            picDetailDoctor = new PictureBox();
            lblDetailNameCaption = new Label();
            lblDetailProfessionCaption = new Label();
            lblDetailRoomCaption = new Label();
            lblDetailName = new Label();
            lblDetailProfession = new Label();
            lblDetailRoom = new Label();
            pnlDetailsDivider = new Panel();
            lblrecId = new Label();
            lblRecordNo = new Label();
            lbldate = new Label();
            lblDateCaption = new Label();
            lblDetailPresCaption = new Label();
            lblDiagCaption = new Label();
            txtDetailDiagnoses = new TextBox();
            txtDetailPrescription = new TextBox();
            lblDetailNotesCaption = new Label();
            lblDetailAttachmentsCaption = new Label();
            txtDetailNotes = new TextBox();
            lvDetailAttachments = new ListView();
            colAttachName = new ColumnHeader();
            colAttachFormat = new ColumnHeader();
            colAttachSize = new ColumnHeader();
            colAttachDescription = new ColumnHeader();
            flowRecords.SuspendLayout();
            pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDetailDoctor).BeginInit();
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
            lblPageTitle.Size = new Size(218, 38);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Medical Record";
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
            pnldivider.TabIndex = 4;
            // 
            // flowRecords
            // 
            flowRecords.AutoScroll = true;
            flowRecords.Controls.Add(recordCardView1);
            flowRecords.Controls.Add(recordCardView2);
            flowRecords.Controls.Add(recordCardView3);
            flowRecords.Controls.Add(recordCardView4);
            flowRecords.FlowDirection = FlowDirection.TopDown;
            flowRecords.Location = new Point(24, 144);
            flowRecords.Name = "flowRecords";
            flowRecords.Size = new Size(560, 544);
            flowRecords.TabIndex = 1;
            flowRecords.WrapContents = false;
            // 
            // recordCardView1
            // 
            recordCardView1.Diagnoses = "-";
            recordCardView1.DoctorId = new Guid("2db4f6cc-3f94-4b7b-af56-7ffcf2cf6e76");
            recordCardView1.Location = new Point(0, 0);
            recordCardView1.Margin = new Padding(0, 0, 0, 6);
            recordCardView1.Name = "recordCardView1";
            recordCardView1.Prescription = "-";
            recordCardView1.RecordDate = "07/12/2026";
            recordCardView1.RecordId = new Guid("ed089bd6-7193-4646-a81e-9019e1b2033b");
            recordCardView1.Size = new Size(526, 130);
            recordCardView1.TabIndex = 0;
            // 
            // recordCardView2
            // 
            recordCardView2.Diagnoses = "Lung Cancer - stage 4";
            recordCardView2.DoctorId = new Guid("8a353ceb-9e75-44c9-8a77-7b83bd35d09b");
            recordCardView2.Location = new Point(0, 136);
            recordCardView2.Margin = new Padding(0, 0, 0, 6);
            recordCardView2.Name = "recordCardView2";
            recordCardView2.Prescription = "Advanced Chemical Operations";
            recordCardView2.RecordDate = "05/12/2024";
            recordCardView2.RecordId = new Guid("ad9f4b2d-c4fe-4d0c-bd30-cc260ec647d0");
            recordCardView2.Size = new Size(526, 130);
            recordCardView2.TabIndex = 1;
            // 
            // recordCardView3
            // 
            recordCardView3.Diagnoses = "Cold";
            recordCardView3.DoctorId = new Guid("c309ad5f-3bdf-4521-8fcb-58da50841f11");
            recordCardView3.Location = new Point(0, 272);
            recordCardView3.Margin = new Padding(0, 0, 0, 6);
            recordCardView3.Name = "recordCardView3";
            recordCardView3.Prescription = "Medicine";
            recordCardView3.RecordDate = "07/04/2021";
            recordCardView3.RecordId = new Guid("1f3b2b44-5077-4041-a9bb-447779df2362");
            recordCardView3.Size = new Size(526, 130);
            recordCardView3.TabIndex = 2;
            // 
            // recordCardView4
            // 
            recordCardView4.Diagnoses = "Iron deficiency";
            recordCardView4.DoctorId = new Guid("a1ed908c-3071-47b8-8f7c-8076c1ac7792");
            recordCardView4.Location = new Point(0, 408);
            recordCardView4.Margin = new Padding(0, 0, 0, 6);
            recordCardView4.Name = "recordCardView4";
            recordCardView4.Prescription = "Iron-rich pills";
            recordCardView4.RecordDate = "24/01/2016";
            recordCardView4.RecordId = new Guid("53d1ced0-5412-4712-8e27-f9d31dd973b1");
            recordCardView4.Size = new Size(526, 130);
            recordCardView4.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            txtSearch.ForeColor = Color.FromArgb(31, 41, 51);
            txtSearch.Location = new Point(80, 108);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ex: 12-040-2144...";
            txtSearch.Size = new Size(199, 26);
            txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblSearch.Location = new Point(24, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 19);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // lblSearchCaption
            // 
            lblSearchCaption.AutoSize = true;
            lblSearchCaption.Font = new Font("Segoe UI Variable Text Semibold", 13.5F, FontStyle.Bold);
            lblSearchCaption.Location = new Point(24, 76);
            lblSearchCaption.Name = "lblSearchCaption";
            lblSearchCaption.Size = new Size(169, 24);
            lblSearchCaption.TabIndex = 5;
            lblSearchCaption.Text = "Record Lookup (ID)";
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.White;
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(txtDetailNotes);
            pnlDetails.Controls.Add(txtDetailPrescription);
            pnlDetails.Controls.Add(txtDetailDiagnoses);
            pnlDetails.Controls.Add(lblDetailAttachmentsCaption);
            pnlDetails.Controls.Add(lblDetailNotesCaption);
            pnlDetails.Controls.Add(lblDetailPresCaption);
            pnlDetails.Controls.Add(lblDiagCaption);
            pnlDetails.Controls.Add(lbldate);
            pnlDetails.Controls.Add(lblDateCaption);
            pnlDetails.Controls.Add(lblrecId);
            pnlDetails.Controls.Add(lblRecordNo);
            pnlDetails.Controls.Add(lblDetailRoomCaption);
            pnlDetails.Controls.Add(lblDetailProfessionCaption);
            pnlDetails.Controls.Add(lblDetailRoom);
            pnlDetails.Controls.Add(lblDetailProfession);
            pnlDetails.Controls.Add(lblDetailName);
            pnlDetails.Controls.Add(lblDetailNameCaption);
            pnlDetails.Controls.Add(pnlDetailsDivider);
            pnlDetails.Controls.Add(picDetailDoctor);
            pnlDetails.Controls.Add(lvDetailAttachments);
            pnlDetails.Location = new Point(596, 144);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(892, 544);
            pnlDetails.TabIndex = 2;
            // 
            // lblDetailsCaption
            // 
            lblDetailsCaption.AutoSize = true;
            lblDetailsCaption.Font = new Font("Segoe UI Variable Text Semibold", 13.5F, FontStyle.Bold);
            lblDetailsCaption.Location = new Point(596, 76);
            lblDetailsCaption.Name = "lblDetailsCaption";
            lblDetailsCaption.Size = new Size(129, 24);
            lblDetailsCaption.TabIndex = 5;
            lblDetailsCaption.Text = "Record Details";
            // 
            // picDetailDoctor
            // 
            picDetailDoctor.Location = new Point(12, 12);
            picDetailDoctor.Name = "picDetailDoctor";
            picDetailDoctor.Size = new Size(64, 78);
            picDetailDoctor.SizeMode = PictureBoxSizeMode.Zoom;
            picDetailDoctor.TabIndex = 0;
            picDetailDoctor.TabStop = false;
            // 
            // lblDetailNameCaption
            // 
            lblDetailNameCaption.AutoSize = true;
            lblDetailNameCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailNameCaption.Location = new Point(92, 12);
            lblDetailNameCaption.Name = "lblDetailNameCaption";
            lblDetailNameCaption.Size = new Size(49, 19);
            lblDetailNameCaption.TabIndex = 1;
            lblDetailNameCaption.Text = "Name:";
            // 
            // lblDetailProfessionCaption
            // 
            lblDetailProfessionCaption.AutoSize = true;
            lblDetailProfessionCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailProfessionCaption.Location = new Point(92, 38);
            lblDetailProfessionCaption.Name = "lblDetailProfessionCaption";
            lblDetailProfessionCaption.Size = new Size(77, 19);
            lblDetailProfessionCaption.TabIndex = 1;
            lblDetailProfessionCaption.Text = "Profession:";
            // 
            // lblDetailRoomCaption
            // 
            lblDetailRoomCaption.AutoSize = true;
            lblDetailRoomCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailRoomCaption.Location = new Point(92, 64);
            lblDetailRoomCaption.Name = "lblDetailRoomCaption";
            lblDetailRoomCaption.Size = new Size(49, 19);
            lblDetailRoomCaption.TabIndex = 1;
            lblDetailRoomCaption.Text = "Room:";
            // 
            // lblDetailName
            // 
            lblDetailName.AutoSize = true;
            lblDetailName.Font = new Font("Segoe UI", 10.5F);
            lblDetailName.Location = new Point(200, 12);
            lblDetailName.Name = "lblDetailName";
            lblDetailName.Size = new Size(0, 19);
            lblDetailName.TabIndex = 1;
            // 
            // lblDetailProfession
            // 
            lblDetailProfession.AutoSize = true;
            lblDetailProfession.Font = new Font("Segoe UI", 10.5F);
            lblDetailProfession.Location = new Point(200, 38);
            lblDetailProfession.Name = "lblDetailProfession";
            lblDetailProfession.Size = new Size(0, 19);
            lblDetailProfession.TabIndex = 1;
            // 
            // lblDetailRoom
            // 
            lblDetailRoom.AutoSize = true;
            lblDetailRoom.Font = new Font("Segoe UI", 10.5F);
            lblDetailRoom.Location = new Point(200, 64);
            lblDetailRoom.Name = "lblDetailRoom";
            lblDetailRoom.Size = new Size(0, 19);
            lblDetailRoom.TabIndex = 1;
            // 
            // pnlDetailsDivider
            // 
            pnlDetailsDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlDetailsDivider.ForeColor = Color.White;
            pnlDetailsDivider.Location = new Point(12, 100);
            pnlDetailsDivider.Margin = new Padding(4);
            pnlDetailsDivider.MinimumSize = new Size(343, 1);
            pnlDetailsDivider.Name = "pnlDetailsDivider";
            pnlDetailsDivider.Size = new Size(866, 4);
            pnlDetailsDivider.TabIndex = 11;
            // 
            // lblrecId
            // 
            lblrecId.AutoSize = true;
            lblrecId.Font = new Font("Segoe UI", 10.5F);
            lblrecId.Location = new Point(100, 112);
            lblrecId.Name = "lblrecId";
            lblrecId.Size = new Size(0, 19);
            lblrecId.TabIndex = 13;
            // 
            // lblRecordNo
            // 
            lblRecordNo.AutoSize = true;
            lblRecordNo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblRecordNo.Location = new Point(12, 112);
            lblRecordNo.Name = "lblRecordNo";
            lblRecordNo.Size = new Size(74, 19);
            lblRecordNo.TabIndex = 12;
            lblRecordNo.Text = "Record ID:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 10.5F);
            lbldate.Location = new Point(570, 112);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(0, 19);
            lbldate.TabIndex = 15;
            // 
            // lblDateCaption
            // 
            lblDateCaption.AutoSize = true;
            lblDateCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDateCaption.Location = new Point(520, 112);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(41, 19);
            lblDateCaption.TabIndex = 14;
            lblDateCaption.Text = "Date:";
            // 
            // lblDetailPresCaption
            // 
            lblDetailPresCaption.AutoSize = true;
            lblDetailPresCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailPresCaption.Location = new Point(12, 234);
            lblDetailPresCaption.Name = "lblDetailPresCaption";
            lblDetailPresCaption.Size = new Size(87, 19);
            lblDetailPresCaption.TabIndex = 16;
            lblDetailPresCaption.Text = "Prescription:";
            // 
            // lblDiagCaption
            // 
            lblDiagCaption.AutoSize = true;
            lblDiagCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDiagCaption.Location = new Point(12, 140);
            lblDiagCaption.Name = "lblDiagCaption";
            lblDiagCaption.Size = new Size(132, 19);
            lblDiagCaption.TabIndex = 2;
            lblDiagCaption.Text = "Detailed Diagnoses:";
            // 
            // txtDetailDiagnoses
            // 
            txtDetailDiagnoses.BackColor = Color.White;
            txtDetailDiagnoses.BorderStyle = BorderStyle.FixedSingle;
            txtDetailDiagnoses.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            txtDetailDiagnoses.Location = new Point(12, 162);
            txtDetailDiagnoses.Multiline = true;
            txtDetailDiagnoses.Name = "txtDetailDiagnoses";
            txtDetailDiagnoses.ReadOnly = true;
            txtDetailDiagnoses.Size = new Size(866, 64);
            txtDetailDiagnoses.TabIndex = 3;
            // 
            // txtDetailPrescription
            // 
            txtDetailPrescription.BackColor = Color.White;
            txtDetailPrescription.BorderStyle = BorderStyle.FixedSingle;
            txtDetailPrescription.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            txtDetailPrescription.Location = new Point(12, 256);
            txtDetailPrescription.Multiline = true;
            txtDetailPrescription.Name = "txtDetailPrescription";
            txtDetailPrescription.ReadOnly = true;
            txtDetailPrescription.Size = new Size(866, 64);
            txtDetailPrescription.TabIndex = 4;
            // 
            // lblDetailNotesCaption
            // 
            lblDetailNotesCaption.AutoSize = true;
            lblDetailNotesCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailNotesCaption.Location = new Point(12, 328);
            lblDetailNotesCaption.Name = "lblDetailNotesCaption";
            lblDetailNotesCaption.Size = new Size(105, 19);
            lblDetailNotesCaption.TabIndex = 16;
            lblDetailNotesCaption.Text = "Detailed Notes:";
            // 
            // lblDetailAttachmentsCaption
            // 
            lblDetailAttachmentsCaption.AutoSize = true;
            lblDetailAttachmentsCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailAttachmentsCaption.Location = new Point(12, 422);
            lblDetailAttachmentsCaption.Name = "lblDetailAttachmentsCaption";
            lblDetailAttachmentsCaption.Size = new Size(91, 19);
            lblDetailAttachmentsCaption.TabIndex = 16;
            lblDetailAttachmentsCaption.Text = "Attachments:";
            // 
            // txtDetailNotes
            // 
            txtDetailNotes.BackColor = Color.White;
            txtDetailNotes.BorderStyle = BorderStyle.FixedSingle;
            txtDetailNotes.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            txtDetailNotes.Location = new Point(12, 350);
            txtDetailNotes.Multiline = true;
            txtDetailNotes.Name = "txtDetailNotes";
            txtDetailNotes.ReadOnly = true;
            txtDetailNotes.Size = new Size(866, 64);
            txtDetailNotes.TabIndex = 5;
            // 
            // lvDetailAttachments
            // 
            lvDetailAttachments.Columns.AddRange(new ColumnHeader[] { colAttachName, colAttachFormat, colAttachSize, colAttachDescription });
            lvDetailAttachments.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvDetailAttachments.Location = new Point(12, 444);
            lvDetailAttachments.Name = "lvDetailAttachments";
            lvDetailAttachments.Size = new Size(866, 88);
            lvDetailAttachments.TabIndex = 6;
            lvDetailAttachments.UseCompatibleStateImageBehavior = false;
            lvDetailAttachments.View = View.Details;
            // 
            // colAttachName
            // 
            colAttachName.Text = "Name";
            colAttachName.Width = 300;
            // 
            // colAttachFormat
            // 
            colAttachFormat.Text = "Format";
            colAttachFormat.Width = 100;
            // 
            // colAttachSize
            // 
            colAttachSize.Text = "Size";
            colAttachSize.Width = 100;
            // 
            // colAttachDescription
            // 
            colAttachDescription.Text = "Description";
            colAttachDescription.Width = 346;
            // 
            // MedicalRecordListView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(pnlDetails);
            Controls.Add(flowRecords);
            Controls.Add(pnldivider);
            Controls.Add(lblPageTitle);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblDetailsCaption);
            Controls.Add(lblSearchCaption);
            Name = "MedicalRecordListView";
            Size = new Size(1512, 712);
            flowRecords.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDetailDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private FlowLayoutPanel flowRecords;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchCaption;
        private Panel pnlDetails;
        private Label lblDetailsCaption;
        private RecordCardView recordCardView1;
        private RecordCardView recordCardView2;
        private RecordCardView recordCardView3;
        private RecordCardView recordCardView4;
        private PictureBox picDetailDoctor;
        private Label lblDetailNameCaption;
        private Label lblDetailRoomCaption;
        private Label lblDetailProfessionCaption;
        private Label lblDetailRoom;
        private Label lblDetailProfession;
        private Label lblDetailName;
        private Panel pnlDetailsDivider;
        private Label lblrecId;
        private Label lblRecordNo;
        private Label lbldate;
        private Label lblDateCaption;
        private Label lblDetailPresCaption;
        private Label lblDiagCaption;
        private TextBox txtDetailPrescription;
        private TextBox txtDetailDiagnoses;
        private Label lblDetailAttachmentsCaption;
        private Label lblDetailNotesCaption;
        private TextBox txtDetailNotes;
        private ListView lvDetailAttachments;
        private ColumnHeader colAttachName;
        private ColumnHeader colAttachFormat;
        private ColumnHeader colAttachSize;
        private ColumnHeader colAttachDescription;
    }
}
