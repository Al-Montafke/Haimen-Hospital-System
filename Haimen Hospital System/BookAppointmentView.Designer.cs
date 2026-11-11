namespace Haimen_Hospital_System
{
    partial class BookAppointmentView
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
            flowDoctors = new FlowLayoutPanel();
            doctorCardSample1 = new DoctorCardView();
            doctorCardSample2 = new DoctorCardView();
            doctorCardSample3 = new DoctorCardView();
            doctorCardSample4 = new DoctorCardView();
            doctorCardSample5 = new DoctorCardView();
            lblChooseCaption = new Label();
            lblHookCaption = new Label();
            lblFilterBy = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            pnlBookDivider = new Panel();
            lblReasonCaption = new Label();
            txtReason = new TextBox();
            pnlSummary = new Panel();
            lblSummaryTimeCaption = new Label();
            lblSummaryDateCaption = new Label();
            lblSummaryTime = new Label();
            lblSummaryDate = new Label();
            lblSummaryDoctor = new Label();
            lblSummaryDoctorCaption = new Label();
            lblSummaryTitle = new Label();
            btnBookCancel = new Button();
            btnBookConfirm = new Button();
            availabilityPicker = new AvailabilityPickerView();
            flowDoctors.SuspendLayout();
            pnlSummary.SuspendLayout();
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
            lblPageTitle.Size = new Size(309, 38);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Book an Appointment";
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
            pnldivider.TabIndex = 3;
            // 
            // flowDoctors
            // 
            flowDoctors.AutoScroll = true;
            flowDoctors.Controls.Add(doctorCardSample1);
            flowDoctors.Controls.Add(doctorCardSample2);
            flowDoctors.Controls.Add(doctorCardSample3);
            flowDoctors.Controls.Add(doctorCardSample4);
            flowDoctors.Controls.Add(doctorCardSample5);
            flowDoctors.FlowDirection = FlowDirection.TopDown;
            flowDoctors.Location = new Point(24, 144);
            flowDoctors.Name = "flowDoctors";
            flowDoctors.Size = new Size(520, 544);
            flowDoctors.TabIndex = 2;
            flowDoctors.WrapContents = false;
            // 
            // doctorCardSample1
            // 
            doctorCardSample1.BackColor = Color.White;
            doctorCardSample1.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample1.DoctorImage = Properties.Resources.Drake_Remoray;
            doctorCardSample1.DoctorName = "Drake Remoray";
            doctorCardSample1.DoctorProfession = "Surgeon";
            doctorCardSample1.DoctorRoom = "R301";
            doctorCardSample1.Location = new Point(0, 0);
            doctorCardSample1.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample1.Name = "doctorCardSample1";
            doctorCardSample1.Size = new Size(494, 94);
            doctorCardSample1.TabIndex = 0;
            // 
            // doctorCardSample2
            // 
            doctorCardSample2.BackColor = Color.White;
            doctorCardSample2.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample2.DoctorImage = Properties.Resources.Elena_Rostova;
            doctorCardSample2.DoctorName = "Elena Rostova";
            doctorCardSample2.DoctorProfession = "Cardiologist";
            doctorCardSample2.DoctorRoom = "R302";
            doctorCardSample2.Location = new Point(0, 102);
            doctorCardSample2.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample2.Name = "doctorCardSample2";
            doctorCardSample2.Size = new Size(494, 94);
            doctorCardSample2.TabIndex = 0;
            // 
            // doctorCardSample3
            // 
            doctorCardSample3.BackColor = Color.White;
            doctorCardSample3.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample3.DoctorImage = Properties.Resources.Marcus_Vence;
            doctorCardSample3.DoctorName = "Marcus Vance";
            doctorCardSample3.DoctorProfession = "Neurologist";
            doctorCardSample3.DoctorRoom = "R415";
            doctorCardSample3.Location = new Point(0, 204);
            doctorCardSample3.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample3.Name = "doctorCardSample3";
            doctorCardSample3.Size = new Size(494, 94);
            doctorCardSample3.TabIndex = 0;
            // 
            // doctorCardSample4
            // 
            doctorCardSample4.BackColor = Color.White;
            doctorCardSample4.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample4.DoctorImage = Properties.Resources.Aisha_Rahman;
            doctorCardSample4.DoctorName = "Aisha Rahman";
            doctorCardSample4.DoctorProfession = "Pediatrician";
            doctorCardSample4.DoctorRoom = "R112";
            doctorCardSample4.Location = new Point(0, 306);
            doctorCardSample4.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample4.Name = "doctorCardSample4";
            doctorCardSample4.Size = new Size(494, 94);
            doctorCardSample4.TabIndex = 0;
            // 
            // doctorCardSample5
            // 
            doctorCardSample5.BackColor = Color.White;
            doctorCardSample5.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample5.DoctorImage = Properties.Resources.Julian_Mercer;
            doctorCardSample5.DoctorName = "Julian Mercer";
            doctorCardSample5.DoctorProfession = "Dermatologist";
            doctorCardSample5.DoctorRoom = "R224";
            doctorCardSample5.Location = new Point(0, 408);
            doctorCardSample5.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample5.Name = "doctorCardSample5";
            doctorCardSample5.Size = new Size(494, 94);
            doctorCardSample5.TabIndex = 0;
            // 
            // lblChooseCaption
            // 
            lblChooseCaption.AutoSize = true;
            lblChooseCaption.Font = new Font("Segoe UI Variable Text Semibold", 13.5F, FontStyle.Bold);
            lblChooseCaption.Location = new Point(24, 76);
            lblChooseCaption.Name = "lblChooseCaption";
            lblChooseCaption.Size = new Size(176, 24);
            lblChooseCaption.TabIndex = 5;
            lblChooseCaption.Text = "Choose your Doctor";
            // 
            // lblHookCaption
            // 
            lblHookCaption.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHookCaption.AutoSize = true;
            lblHookCaption.BackColor = Color.Transparent;
            lblHookCaption.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            lblHookCaption.Location = new Point(1134, 18);
            lblHookCaption.Name = "lblHookCaption";
            lblHookCaption.Size = new Size(354, 36);
            lblHookCaption.TabIndex = 6;
            lblHookCaption.Text = "Always the best treatment";
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblFilterBy.Location = new Point(291, 112);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(63, 19);
            lblFilterBy.TabIndex = 7;
            lblFilterBy.Text = "Filter by:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblSearch.Location = new Point(24, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 19);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search:";
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
            txtSearch.PlaceholderText = "Drake Remoray";
            txtSearch.Size = new Size(199, 26);
            txtSearch.TabIndex = 0;
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            cmbFilter.ForeColor = SystemColors.WindowFrame;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Alphabetical", "Profession", "Rating", "Years of experties", "Availability" });
            cmbFilter.Location = new Point(360, 108);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(160, 27);
            cmbFilter.TabIndex = 1;
            cmbFilter.Text = "Filter...";
            // 
            // pnlBookDivider
            // 
            pnlBookDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlBookDivider.ForeColor = Color.White;
            pnlBookDivider.Location = new Point(1048, 639);
            pnlBookDivider.Margin = new Padding(4);
            pnlBookDivider.MinimumSize = new Size(343, 1);
            pnlBookDivider.Name = "pnlBookDivider";
            pnlBookDivider.Size = new Size(440, 4);
            pnlBookDivider.TabIndex = 11;
            // 
            // lblReasonCaption
            // 
            lblReasonCaption.AutoSize = true;
            lblReasonCaption.Font = new Font("Segoe UI", 10.5F);
            lblReasonCaption.Location = new Point(1048, 76);
            lblReasonCaption.Name = "lblReasonCaption";
            lblReasonCaption.Size = new Size(105, 19);
            lblReasonCaption.TabIndex = 12;
            lblReasonCaption.Text = "Reason for visit:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(1048, 100);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(440, 140);
            txtReason.TabIndex = 4;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblSummaryTimeCaption);
            pnlSummary.Controls.Add(lblSummaryDateCaption);
            pnlSummary.Controls.Add(lblSummaryTime);
            pnlSummary.Controls.Add(lblSummaryDate);
            pnlSummary.Controls.Add(lblSummaryDoctor);
            pnlSummary.Controls.Add(lblSummaryDoctorCaption);
            pnlSummary.Controls.Add(lblSummaryTitle);
            pnlSummary.Location = new Point(1048, 256);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(440, 374);
            pnlSummary.TabIndex = 14;
            // 
            // lblSummaryTimeCaption
            // 
            lblSummaryTimeCaption.AutoSize = true;
            lblSummaryTimeCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSummaryTimeCaption.Location = new Point(12, 128);
            lblSummaryTimeCaption.Name = "lblSummaryTimeCaption";
            lblSummaryTimeCaption.Size = new Size(43, 19);
            lblSummaryTimeCaption.TabIndex = 0;
            lblSummaryTimeCaption.Text = "Time:";
            // 
            // lblSummaryDateCaption
            // 
            lblSummaryDateCaption.AutoSize = true;
            lblSummaryDateCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSummaryDateCaption.Location = new Point(12, 88);
            lblSummaryDateCaption.Name = "lblSummaryDateCaption";
            lblSummaryDateCaption.Size = new Size(41, 19);
            lblSummaryDateCaption.TabIndex = 0;
            lblSummaryDateCaption.Text = "Date:";
            // 
            // lblSummaryTime
            // 
            lblSummaryTime.AutoSize = true;
            lblSummaryTime.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSummaryTime.Location = new Point(112, 128);
            lblSummaryTime.Name = "lblSummaryTime";
            lblSummaryTime.Size = new Size(0, 19);
            lblSummaryTime.TabIndex = 0;
            // 
            // lblSummaryDate
            // 
            lblSummaryDate.AutoSize = true;
            lblSummaryDate.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSummaryDate.Location = new Point(112, 88);
            lblSummaryDate.Name = "lblSummaryDate";
            lblSummaryDate.Size = new Size(0, 19);
            lblSummaryDate.TabIndex = 0;
            // 
            // lblSummaryDoctor
            // 
            lblSummaryDoctor.AutoSize = true;
            lblSummaryDoctor.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSummaryDoctor.Location = new Point(112, 48);
            lblSummaryDoctor.Name = "lblSummaryDoctor";
            lblSummaryDoctor.Size = new Size(0, 19);
            lblSummaryDoctor.TabIndex = 0;
            // 
            // lblSummaryDoctorCaption
            // 
            lblSummaryDoctorCaption.AutoSize = true;
            lblSummaryDoctorCaption.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSummaryDoctorCaption.Location = new Point(12, 48);
            lblSummaryDoctorCaption.Name = "lblSummaryDoctorCaption";
            lblSummaryDoctorCaption.Size = new Size(56, 19);
            lblSummaryDoctorCaption.TabIndex = 0;
            lblSummaryDoctorCaption.Text = "Doctor:";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSummaryTitle.Location = new Point(12, 12);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(83, 21);
            lblSummaryTitle.TabIndex = 0;
            lblSummaryTitle.Text = "Summary:";
            // 
            // btnBookCancel
            // 
            btnBookCancel.BackColor = Color.White;
            btnBookCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnBookCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnBookCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnBookCancel.FlatStyle = FlatStyle.Flat;
            btnBookCancel.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnBookCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnBookCancel.Location = new Point(1268, 651);
            btnBookCancel.Name = "btnBookCancel";
            btnBookCancel.Size = new Size(104, 37);
            btnBookCancel.TabIndex = 6;
            btnBookCancel.Text = "Cancel";
            btnBookCancel.UseVisualStyleBackColor = false;
            // 
            // btnBookConfirm
            // 
            btnBookConfirm.BackColor = Color.FromArgb(15, 108, 189);
            btnBookConfirm.FlatAppearance.BorderSize = 0;
            btnBookConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnBookConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnBookConfirm.FlatStyle = FlatStyle.Flat;
            btnBookConfirm.Font = new Font("Segoe UI Variable Display", 10.5F, FontStyle.Bold);
            btnBookConfirm.ForeColor = Color.White;
            btnBookConfirm.Location = new Point(1384, 651);
            btnBookConfirm.Name = "btnBookConfirm";
            btnBookConfirm.Size = new Size(104, 37);
            btnBookConfirm.TabIndex = 5;
            btnBookConfirm.Text = "Confirm";
            btnBookConfirm.UseVisualStyleBackColor = false;
            // 
            // availabilityPicker
            // 
            availabilityPicker.Location = new Point(556, 76);
            availabilityPicker.Name = "availabilityPicker";
            availabilityPicker.Size = new Size(480, 554);
            availabilityPicker.TabIndex = 3;
            // 
            // BookAppointmentView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(availabilityPicker);
            Controls.Add(btnBookCancel);
            Controls.Add(pnlSummary);
            Controls.Add(btnBookConfirm);
            Controls.Add(txtReason);
            Controls.Add(lblReasonCaption);
            Controls.Add(pnlBookDivider);
            Controls.Add(cmbFilter);
            Controls.Add(lblSearch);
            Controls.Add(lblFilterBy);
            Controls.Add(lblHookCaption);
            Controls.Add(lblChooseCaption);
            Controls.Add(flowDoctors);
            Controls.Add(pnldivider);
            Controls.Add(lblPageTitle);
            Controls.Add(txtSearch);
            Name = "BookAppointmentView";
            Size = new Size(1512, 712);
            flowDoctors.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private FlowLayoutPanel flowDoctors;
        private Label lblChooseCaption;
        private Label lblHookCaption;
        private Label lblFilterBy;
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cmbFilter;
        private Panel pnlBookDivider;
        private Label lblReasonCaption;
        private TextBox txtReason;
        private Panel pnlSummary;
        private Label lblSummaryTitle;
        private Label lblSummaryTimeCaption;
        private Label lblSummaryDateCaption;
        private Label lblSummaryTime;
        private Label lblSummaryDate;
        private Label lblSummaryDoctor;
        private Label lblSummaryDoctorCaption;
        private Button btnBookCancel;
        private Button btnBookConfirm;
        private DoctorCardView doctorCardSample1;
        private DoctorCardView doctorCardSample2;
        private DoctorCardView doctorCardSample3;
        private DoctorCardView doctorCardSample4;
        private DoctorCardView doctorCardSample5;
        private AvailabilityPickerView availabilityPicker;
    }
}
