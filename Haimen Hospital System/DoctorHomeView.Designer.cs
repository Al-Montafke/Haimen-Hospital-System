namespace Haimen_Hospital_System
{
    partial class DoctorHomeView
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
            pnlHomeHeader = new Panel();
            lblHomeHeader = new Label();
            lblRecordsCaption = new Label();
            lblAppointmentsCaption = new Label();
            flowAppointments = new FlowLayoutPanel();
            appointmentCardSample1 = new AppointmentCardView();
            appointmentCardSample2 = new AppointmentCardView();
            flowRecords = new FlowLayoutPanel();
            recordCardSample1 = new RecordCardView();
            recordCardSample2 = new RecordCardView();
            identityBlockHome = new IdentityBlockView();
            pnlHomeHeader.SuspendLayout();
            flowAppointments.SuspendLayout();
            flowRecords.SuspendLayout();
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
            // lblRecordsCaption
            // 
            lblRecordsCaption.AutoSize = true;
            lblRecordsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblRecordsCaption.Location = new Point(762, 366);
            lblRecordsCaption.Name = "lblRecordsCaption";
            lblRecordsCaption.Size = new Size(202, 24);
            lblRecordsCaption.TabIndex = 28;
            lblRecordsCaption.Text = "Recent patient records";
            // 
            // lblAppointmentsCaption
            // 
            lblAppointmentsCaption.AutoSize = true;
            lblAppointmentsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblAppointmentsCaption.Location = new Point(24, 366);
            lblAppointmentsCaption.Name = "lblAppointmentsCaption";
            lblAppointmentsCaption.Size = new Size(197, 24);
            lblAppointmentsCaption.TabIndex = 29;
            lblAppointmentsCaption.Text = "Today's appointments";
            // 
            // flowAppointments
            // 
            flowAppointments.AutoScroll = true;
            flowAppointments.BackColor = Color.FromArgb(243, 246, 249);
            flowAppointments.Controls.Add(appointmentCardSample1);
            flowAppointments.Controls.Add(appointmentCardSample2);
            flowAppointments.FlowDirection = FlowDirection.TopDown;
            flowAppointments.Location = new Point(24, 398);
            flowAppointments.Name = "flowAppointments";
            flowAppointments.Size = new Size(726, 290);
            flowAppointments.TabIndex = 30;
            flowAppointments.WrapContents = false;
            // 
            // appointmentCardSample1
            // 
            appointmentCardSample1.BackColor = Color.White;
            appointmentCardSample1.BorderStyle = BorderStyle.FixedSingle;
            appointmentCardSample1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            appointmentCardSample1.Location = new Point(0, 0);
            appointmentCardSample1.Margin = new Padding(0, 0, 0, 8);
            appointmentCardSample1.Name = "appointmentCardSample1";
            appointmentCardSample1.Size = new Size(526, 177);
            appointmentCardSample1.TabIndex = 0;
            // 
            // appointmentCardSample2
            // 
            appointmentCardSample2.BackColor = Color.White;
            appointmentCardSample2.BorderStyle = BorderStyle.FixedSingle;
            appointmentCardSample2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            appointmentCardSample2.Location = new Point(0, 185);
            appointmentCardSample2.Margin = new Padding(0, 0, 0, 8);
            appointmentCardSample2.Name = "appointmentCardSample2";
            appointmentCardSample2.Size = new Size(526, 177);
            appointmentCardSample2.TabIndex = 1;
            // 
            // flowRecords
            // 
            flowRecords.AutoScroll = true;
            flowRecords.BackColor = Color.FromArgb(243, 246, 249);
            flowRecords.Controls.Add(recordCardSample1);
            flowRecords.Controls.Add(recordCardSample2);
            flowRecords.FlowDirection = FlowDirection.TopDown;
            flowRecords.Location = new Point(762, 398);
            flowRecords.Name = "flowRecords";
            flowRecords.Size = new Size(726, 290);
            flowRecords.TabIndex = 31;
            flowRecords.WrapContents = false;
            // 
            // recordCardSample1
            // 
            recordCardSample1.Diagnoses = "Lung Cancer - stage 4";
            recordCardSample1.DoctorId = new Guid("d552394a-5023-4902-b3cf-422394de997e");
            recordCardSample1.Location = new Point(0, 0);
            recordCardSample1.Margin = new Padding(0, 0, 0, 6);
            recordCardSample1.Name = "recordCardSample1";
            recordCardSample1.Prescription = "Advanced Chemical Operations";
            recordCardSample1.RecordDate = "07/12/2026";
            recordCardSample1.RecordId = new Guid("abcd462e-38ce-44a4-b917-226c6b9f439f");
            recordCardSample1.Size = new Size(526, 130);
            recordCardSample1.TabIndex = 0;
            // 
            // recordCardSample2
            // 
            recordCardSample2.Diagnoses = "Lung Cancer - stage 4";
            recordCardSample2.DoctorId = new Guid("e2fb2cf2-4c87-446c-a548-a7574187fa35");
            recordCardSample2.Location = new Point(0, 136);
            recordCardSample2.Margin = new Padding(0, 0, 0, 6);
            recordCardSample2.Name = "recordCardSample2";
            recordCardSample2.Prescription = "Advanced Chemical Operations";
            recordCardSample2.RecordDate = "07/12/2026";
            recordCardSample2.RecordId = new Guid("6586e5e0-d4ea-4b62-bee2-2bbc04672bf7");
            recordCardSample2.Size = new Size(526, 130);
            recordCardSample2.TabIndex = 1;
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
            identityBlockHome.TabIndex = 32;
            identityBlockHome.UserId = new Guid("cb5bc404-7f64-43c0-babc-c761b3ec1a98");
            identityBlockHome.UserImage = null;
            identityBlockHome.UserName = "Jacob";
            // 
            // DoctorHomeView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(identityBlockHome);
            Controls.Add(lblRecordsCaption);
            Controls.Add(lblAppointmentsCaption);
            Controls.Add(pnlHomeHeader);
            Controls.Add(flowAppointments);
            Controls.Add(flowRecords);
            Name = "DoctorHomeView";
            Size = new Size(1512, 712);
            pnlHomeHeader.ResumeLayout(false);
            pnlHomeHeader.PerformLayout();
            flowAppointments.ResumeLayout(false);
            flowRecords.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHomeHeader;
        private Label lblHomeHeader;
        private Label lblRecordsCaption;
        private Label lblAppointmentsCaption;
        private FlowLayoutPanel flowAppointments;
        private AppointmentCardView appointmentCardSample1;
        private AppointmentCardView appointmentCardSample2;
        private FlowLayoutPanel flowRecords;
        private RecordCardView recordCardSample1;
        private RecordCardView recordCardSample2;
        private IdentityBlockView identityBlockHome;
    }
}
