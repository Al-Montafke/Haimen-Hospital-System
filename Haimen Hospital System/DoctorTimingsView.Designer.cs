namespace Haimen_Hospital_System
{
    partial class DoctorTimingsView
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
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            lblSearch = new Label();
            lblFilterBy = new Label();
            flowDoctors = new FlowLayoutPanel();
            doctorCardSample1 = new DoctorCardView();
            doctorCardSample2 = new DoctorCardView();
            doctorCardSample3 = new DoctorCardView();
            doctorCardSample4 = new DoctorCardView();
            doctorCardSample5 = new DoctorCardView();
            availabilityPicker = new AvailabilityPickerView();
            lblCheckDocCaption = new Label();
            flowDoctors.SuspendLayout();
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
            lblPageTitle.Size = new Size(219, 38);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Doctor Timings";
            // 
            // pnldivider
            // 
            pnldivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnldivider.BackColor = Color.FromArgb(200, 209, 218);
            pnldivider.ForeColor = Color.White;
            pnldivider.Location = new Point(24, 60);
            pnldivider.Margin = new Padding(4);
            pnldivider.MinimumSize = new Size(343, 1);
            pnldivider.Name = "pnldivider";
            pnldivider.Size = new Size(1464, 10);
            pnldivider.TabIndex = 2;
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
            // availabilityPicker
            // 
            availabilityPicker.Location = new Point(556, 76);
            availabilityPicker.Name = "availabilityPicker";
            availabilityPicker.Size = new Size(480, 554);
            availabilityPicker.TabIndex = 3;
            // 
            // lblCheckDocCaption
            // 
            lblCheckDocCaption.AutoSize = true;
            lblCheckDocCaption.BackColor = Color.Transparent;
            lblCheckDocCaption.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            lblCheckDocCaption.ForeColor = SystemColors.Desktop;
            lblCheckDocCaption.Location = new Point(24, 76);
            lblCheckDocCaption.Name = "lblCheckDocCaption";
            lblCheckDocCaption.Size = new Size(263, 25);
            lblCheckDocCaption.TabIndex = 0;
            lblCheckDocCaption.Text = "Check our doctor's availability:";
            // 
            // DoctorTimingsView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(availabilityPicker);
            Controls.Add(txtSearch);
            Controls.Add(pnldivider);
            Controls.Add(lblCheckDocCaption);
            Controls.Add(lblPageTitle);
            Controls.Add(cmbFilter);
            Controls.Add(lblSearch);
            Controls.Add(lblFilterBy);
            Controls.Add(flowDoctors);
            Name = "DoctorTimingsView";
            Size = new Size(1512, 712);
            flowDoctors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnldivider;
        private TextBox txtSearch;
        private ComboBox cmbFilter;
        private Label lblSearch;
        private Label lblFilterBy;
        private FlowLayoutPanel flowDoctors;
        private DoctorCardView doctorCardSample1;
        private DoctorCardView doctorCardSample2;
        private DoctorCardView doctorCardSample3;
        private DoctorCardView doctorCardSample4;
        private DoctorCardView doctorCardSample5;
        private AvailabilityPickerView availabilityPicker;
        private Label lblCheckDocCaption;
    }
}
