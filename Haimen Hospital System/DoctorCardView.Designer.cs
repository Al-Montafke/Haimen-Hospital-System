namespace Haimen_Hospital_System
{
    partial class DoctorCardView
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
            picDoctor = new PictureBox();
            lblDoctorName = new Label();
            lblProfession = new Label();
            lblRoom = new Label();
            btnChooseDoctor = new Button();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            SuspendLayout();
            // 
            // picDoctor
            // 
            picDoctor.Location = new Point(8, 8);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(64, 78);
            picDoctor.SizeMode = PictureBoxSizeMode.Zoom;
            picDoctor.TabIndex = 0;
            picDoctor.TabStop = false;
            // 
            // lblDoctorName
            // 
            lblDoctorName.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDoctorName.Location = new Point(80, 10);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(290, 22);
            lblDoctorName.TabIndex = 1;
            // 
            // lblProfession
            // 
            lblProfession.Font = new Font("Segoe UI", 10.5F);
            lblProfession.Location = new Point(80, 36);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(290, 19);
            lblProfession.TabIndex = 1;
            // 
            // lblRoom
            // 
            lblRoom.Font = new Font("Segoe UI", 10.5F);
            lblRoom.Location = new Point(80, 60);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(290, 19);
            lblRoom.TabIndex = 1;
            // 
            // btnChooseDoctor
            // 
            btnChooseDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseDoctor.Location = new Point(386, 28);
            btnChooseDoctor.Name = "btnChooseDoctor";
            btnChooseDoctor.Size = new Size(96, 34);
            btnChooseDoctor.TabIndex = 2;
            btnChooseDoctor.Text = "Select";
            btnChooseDoctor.UseVisualStyleBackColor = true;
            // 
            // DoctorCardView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnChooseDoctor);
            Controls.Add(lblProfession);
            Controls.Add(lblRoom);
            Controls.Add(lblDoctorName);
            Controls.Add(picDoctor);
            Name = "DoctorCardView";
            Size = new Size(494, 94);
            ((System.ComponentModel.ISupportInitialize)picDoctor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picDoctor;
        private Label lblDoctorName;
        private Label lblProfession;
        private Label lblRoom;
        private Button btnChooseDoctor;
    }
}
