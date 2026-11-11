namespace Haimen_Hospital_System
{
    partial class DayCardView
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
            lblDayName = new Label();
            lblTimeStart = new Label();
            lblTimeEnd = new Label();
            picClock = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picClock).BeginInit();
            SuspendLayout();
            // 
            // lblDayName
            // 
            lblDayName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDayName.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDayName.Location = new Point(0, 6);
            lblDayName.Margin = new Padding(3, 0, 0, 0);
            lblDayName.Name = "lblDayName";
            lblDayName.Size = new Size(58, 22);
            lblDayName.TabIndex = 0;
            lblDayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeStart
            // 
            lblTimeStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeStart.Location = new Point(0, 60);
            lblTimeStart.Margin = new Padding(3, 0, 0, 0);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(58, 17);
            lblTimeStart.TabIndex = 0;
            lblTimeStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeEnd
            // 
            lblTimeEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeEnd.Location = new Point(0, 77);
            lblTimeEnd.Margin = new Padding(3, 0, 0, 0);
            lblTimeEnd.Name = "lblTimeEnd";
            lblTimeEnd.Size = new Size(58, 17);
            lblTimeEnd.TabIndex = 0;
            lblTimeEnd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picClock
            // 
            picClock.Image = Properties.Resources.Clock_icon;
            picClock.Location = new Point(17, 32);
            picClock.Name = "picClock";
            picClock.Size = new Size(24, 24);
            picClock.SizeMode = PictureBoxSizeMode.Zoom;
            picClock.TabIndex = 1;
            picClock.TabStop = false;
            // 
            // DayCardView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(picClock);
            Controls.Add(lblTimeEnd);
            Controls.Add(lblTimeStart);
            Controls.Add(lblDayName);
            Margin = new Padding(3, 3, 6, 3);
            Name = "DayCardView";
            Size = new Size(62, 98);
            ((System.ComponentModel.ISupportInitialize)picClock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDayName;
        private Label lblTimeStart;
        private Label lblTimeEnd;
        private PictureBox picClock;
    }
}
