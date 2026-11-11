namespace Haimen_Hospital_System
{
    partial class RescheduleDialog
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
            availabilityPickerReschedule = new AvailabilityPickerView();
            pnlRescheduleDivider = new Panel();
            btnRescheduleConfirm = new Button();
            btnRescheduleCancel = new Button();
            SuspendLayout();
            // 
            // availabilityPickerReschedule
            // 
            availabilityPickerReschedule.Location = new Point(24, 24);
            availabilityPickerReschedule.Name = "availabilityPickerReschedule";
            availabilityPickerReschedule.Size = new Size(480, 554);
            availabilityPickerReschedule.TabIndex = 0;
            // 
            // pnlRescheduleDivider
            // 
            pnlRescheduleDivider.BackColor = Color.FromArgb(200, 209, 218);
            pnlRescheduleDivider.ForeColor = Color.White;
            pnlRescheduleDivider.Location = new Point(24, 590);
            pnlRescheduleDivider.MinimumSize = new Size(400, 1);
            pnlRescheduleDivider.Name = "pnlRescheduleDivider";
            pnlRescheduleDivider.Size = new Size(480, 4);
            pnlRescheduleDivider.TabIndex = 3;
            // 
            // btnRescheduleConfirm
            // 
            btnRescheduleConfirm.BackColor = Color.FromArgb(15, 108, 189);
            btnRescheduleConfirm.FlatAppearance.BorderSize = 0;
            btnRescheduleConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRescheduleConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(9, 68, 120);
            btnRescheduleConfirm.FlatStyle = FlatStyle.Flat;
            btnRescheduleConfirm.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnRescheduleConfirm.ForeColor = Color.White;
            btnRescheduleConfirm.Location = new Point(374, 606);
            btnRescheduleConfirm.Name = "btnRescheduleConfirm";
            btnRescheduleConfirm.Size = new Size(130, 37);
            btnRescheduleConfirm.TabIndex = 1;
            btnRescheduleConfirm.Text = "Reschedule";
            btnRescheduleConfirm.UseVisualStyleBackColor = false;
            // 
            // btnRescheduleCancel
            // 
            btnRescheduleCancel.BackColor = Color.White;
            btnRescheduleCancel.FlatAppearance.BorderColor = Color.FromArgb(123, 135, 148);
            btnRescheduleCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(11, 83, 148);
            btnRescheduleCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 235, 242);
            btnRescheduleCancel.FlatStyle = FlatStyle.Flat;
            btnRescheduleCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnRescheduleCancel.ForeColor = Color.FromArgb(31, 41, 51);
            btnRescheduleCancel.Location = new Point(258, 606);
            btnRescheduleCancel.Name = "btnRescheduleCancel";
            btnRescheduleCancel.Size = new Size(104, 37);
            btnRescheduleCancel.TabIndex = 2;
            btnRescheduleCancel.Text = "Cancel";
            btnRescheduleCancel.UseVisualStyleBackColor = false;
            // 
            // RescheduleDialog
            // 
            AcceptButton = btnRescheduleConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 249);
            CancelButton = btnRescheduleCancel;
            ClientSize = new Size(528, 667);
            Controls.Add(btnRescheduleConfirm);
            Controls.Add(btnRescheduleCancel);
            Controls.Add(pnlRescheduleDivider);
            Controls.Add(availabilityPickerReschedule);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RescheduleDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reschedule Your Appointment";
            ResumeLayout(false);
        }

        #endregion

        private AvailabilityPickerView availabilityPickerReschedule;
        private Panel pnlRescheduleDivider;
        private Button btnRescheduleConfirm;
        private Button btnRescheduleCancel;
    }
}