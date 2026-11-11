namespace Haimen_Hospital_System
{
    partial class ReceptionistHomeView
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
            flowAppointments = new FlowLayoutPanel();
            appointmentCardSample1 = new AppointmentCardView();
            appointmentCardSample2 = new AppointmentCardView();
            flowDoctors = new FlowLayoutPanel();
            doctorCardSample1 = new DoctorCardView();
            doctorCardSample2 = new DoctorCardView();
            doctorCardSample3 = new DoctorCardView();
            lblAppointmentsCaption = new Label();
            lblOnDutyCaption = new Label();
            identityBlockHome = new IdentityBlockView();
            pnlHomeHeader.SuspendLayout();
            flowAppointments.SuspendLayout();
            flowDoctors.SuspendLayout();
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
            pnlHomeHeader.TabIndex = 14;
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
            // flowAppointments
            // 
            flowAppointments.AutoScroll = true;
            flowAppointments.Controls.Add(appointmentCardSample1);
            flowAppointments.Controls.Add(appointmentCardSample2);
            flowAppointments.FlowDirection = FlowDirection.TopDown;
            flowAppointments.Location = new Point(24, 398);
            flowAppointments.Name = "flowAppointments";
            flowAppointments.Size = new Size(726, 290);
            flowAppointments.TabIndex = 27;
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
            // flowDoctors
            // 
            flowDoctors.AutoScroll = true;
            flowDoctors.Controls.Add(doctorCardSample1);
            flowDoctors.Controls.Add(doctorCardSample2);
            flowDoctors.Controls.Add(doctorCardSample3);
            flowDoctors.FlowDirection = FlowDirection.TopDown;
            flowDoctors.Location = new Point(762, 398);
            flowDoctors.Name = "flowDoctors";
            flowDoctors.Size = new Size(726, 290);
            flowDoctors.TabIndex = 28;
            flowDoctors.WrapContents = false;
            // 
            // doctorCardSample1
            // 
            doctorCardSample1.BackColor = Color.White;
            doctorCardSample1.BorderStyle = BorderStyle.FixedSingle;
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
            doctorCardSample2.DoctorName = "Drake Remoray";
            doctorCardSample2.DoctorProfession = "Surgeon";
            doctorCardSample2.DoctorRoom = "R301";
            doctorCardSample2.Location = new Point(0, 102);
            doctorCardSample2.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample2.Name = "doctorCardSample2";
            doctorCardSample2.Size = new Size(494, 94);
            doctorCardSample2.TabIndex = 1;
            // 
            // doctorCardSample3
            // 
            doctorCardSample3.BackColor = Color.White;
            doctorCardSample3.BorderStyle = BorderStyle.FixedSingle;
            doctorCardSample3.DoctorName = "Drake Remoray";
            doctorCardSample3.DoctorProfession = "Surgeon";
            doctorCardSample3.DoctorRoom = "R301";
            doctorCardSample3.Location = new Point(0, 204);
            doctorCardSample3.Margin = new Padding(0, 0, 0, 8);
            doctorCardSample3.Name = "doctorCardSample3";
            doctorCardSample3.Size = new Size(494, 94);
            doctorCardSample3.TabIndex = 2;
            // 
            // lblAppointmentsCaption
            // 
            lblAppointmentsCaption.AutoSize = true;
            lblAppointmentsCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblAppointmentsCaption.Location = new Point(24, 366);
            lblAppointmentsCaption.Name = "lblAppointmentsCaption";
            lblAppointmentsCaption.Size = new Size(197, 24);
            lblAppointmentsCaption.TabIndex = 4;
            lblAppointmentsCaption.Text = "Today's appointments";
            // 
            // lblOnDutyCaption
            // 
            lblOnDutyCaption.AutoSize = true;
            lblOnDutyCaption.Font = new Font("Segoe UI Variable Text", 13.5F, FontStyle.Bold);
            lblOnDutyCaption.Location = new Point(762, 366);
            lblOnDutyCaption.Name = "lblOnDutyCaption";
            lblOnDutyCaption.Size = new Size(147, 24);
            lblOnDutyCaption.TabIndex = 4;
            lblOnDutyCaption.Text = "Doctors on duty";
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
            identityBlockHome.TabIndex = 29;
            identityBlockHome.UserId = new Guid("cb5bc404-7f64-43c0-babc-c761b3ec1a98");
            identityBlockHome.UserImage = null;
            identityBlockHome.UserName = "Jacob";
            // 
            // ReceptionistHomeView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 246, 249);
            Controls.Add(identityBlockHome);
            Controls.Add(lblOnDutyCaption);
            Controls.Add(lblAppointmentsCaption);
            Controls.Add(flowAppointments);
            Controls.Add(pnlHomeHeader);
            Controls.Add(flowDoctors);
            Name = "ReceptionistHomeView";
            Size = new Size(1512, 712);
            pnlHomeHeader.ResumeLayout(false);
            pnlHomeHeader.PerformLayout();
            flowAppointments.ResumeLayout(false);
            flowDoctors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHomeHeader;
        private Label lblHomeHeader;
        private FlowLayoutPanel flowAppointments;
        private FlowLayoutPanel flowDoctors;
        private DoctorCardView doctorCardSample1;
        private DoctorCardView doctorCardSample2;
        private AppointmentCardView appointmentCardSample1;
        private AppointmentCardView appointmentCardSample2;
        private Label lblAppointmentsCaption;
        private Label lblOnDutyCaption;
        private IdentityBlockView identityBlockHome;
        private DoctorCardView doctorCardSample3;
    }
}
