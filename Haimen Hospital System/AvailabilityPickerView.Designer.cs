namespace Haimen_Hospital_System
{
    partial class AvailabilityPickerView
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
            components = new System.ComponentModel.Container();
            lblTimeTableTitle = new Label();
            picDoctor = new PictureBox();
            lblDocNameCap = new Label();
            lblProfessionCap = new Label();
            btnPrevWeek = new Button();
            btnNextWeek = new Button();
            btnPrevMonth = new Button();
            btnNextMonth = new Button();
            btnTip = new ToolTip(components);
            lbldocname = new Label();
            lblprofession = new Label();
            lblMonth = new Label();
            flowDays = new FlowLayoutPanel();
            dayCardView1 = new DayCardView();
            dayCardView2 = new DayCardView();
            dayCardView3 = new DayCardView();
            dayCardView4 = new DayCardView();
            dayCardView5 = new DayCardView();
            dayCardView6 = new DayCardView();
            dayCardView7 = new DayCardView();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            flowDays.SuspendLayout();
            SuspendLayout();
            // 
            // lblTimeTableTitle
            // 
            lblTimeTableTitle.AutoSize = true;
            lblTimeTableTitle.Font = new Font("Segoe UI Variable Display", 21F, FontStyle.Bold);
            lblTimeTableTitle.Location = new Point(12, 8);
            lblTimeTableTitle.Name = "lblTimeTableTitle";
            lblTimeTableTitle.Size = new Size(269, 37);
            lblTimeTableTitle.TabIndex = 1;
            lblTimeTableTitle.Text = "Working Timetable";
            // 
            // picDoctor
            // 
            picDoctor.Location = new Point(12, 52);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(80, 96);
            picDoctor.SizeMode = PictureBoxSizeMode.Zoom;
            picDoctor.TabIndex = 2;
            picDoctor.TabStop = false;
            // 
            // lblDocNameCap
            // 
            lblDocNameCap.AutoSize = true;
            lblDocNameCap.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDocNameCap.ForeColor = Color.FromArgb(82, 96, 109);
            lblDocNameCap.Location = new Point(104, 56);
            lblDocNameCap.Name = "lblDocNameCap";
            lblDocNameCap.Size = new Size(114, 20);
            lblDocNameCap.TabIndex = 1;
            lblDocNameCap.Text = "Doctor's Name:";
            // 
            // lblProfessionCap
            // 
            lblProfessionCap.AutoSize = true;
            lblProfessionCap.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblProfessionCap.ForeColor = Color.FromArgb(82, 96, 109);
            lblProfessionCap.Location = new Point(104, 108);
            lblProfessionCap.Name = "lblProfessionCap";
            lblProfessionCap.Size = new Size(84, 20);
            lblProfessionCap.TabIndex = 1;
            lblProfessionCap.Text = "Profession:";
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.Font = new Font("Segoe UI Variable Display", 10.5F);
            btnPrevWeek.Location = new Point(60, 160);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(36, 32);
            btnPrevWeek.TabIndex = 1;
            btnPrevWeek.Text = "<";
            btnTip.SetToolTip(btnPrevWeek, "Previous Week");
            btnPrevWeek.UseVisualStyleBackColor = true;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Font = new Font("Segoe UI Variable Display", 10.5F);
            btnNextWeek.Location = new Point(384, 160);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(36, 32);
            btnNextWeek.TabIndex = 2;
            btnNextWeek.Text = ">";
            btnTip.SetToolTip(btnNextWeek, "Next Week");
            btnNextWeek.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            btnPrevMonth.Font = new Font("Segoe UI Variable Display", 10.5F);
            btnPrevMonth.Location = new Point(12, 160);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(44, 32);
            btnPrevMonth.TabIndex = 0;
            btnPrevMonth.Text = "|<<";
            btnTip.SetToolTip(btnPrevMonth, "Previous Month");
            btnPrevMonth.UseVisualStyleBackColor = true;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Font = new Font("Segoe UI Variable Display", 10.5F);
            btnNextMonth.Location = new Point(424, 160);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(44, 32);
            btnNextMonth.TabIndex = 3;
            btnNextMonth.Text = ">>|";
            btnTip.SetToolTip(btnNextMonth, "Next Month");
            btnNextMonth.UseVisualStyleBackColor = true;
            // 
            // lbldocname
            // 
            lbldocname.AutoSize = true;
            lbldocname.Font = new Font("Segoe UI", 10.5F);
            lbldocname.Location = new Point(104, 76);
            lbldocname.Name = "lbldocname";
            lbldocname.Size = new Size(0, 19);
            lbldocname.TabIndex = 2;
            // 
            // lblprofession
            // 
            lblprofession.AutoSize = true;
            lblprofession.Font = new Font("Segoe UI", 10.5F);
            lblprofession.Location = new Point(104, 128);
            lblprofession.Name = "lblprofession";
            lblprofession.Size = new Size(0, 19);
            lblprofession.TabIndex = 2;
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Segoe UI", 13.5F);
            lblMonth.ForeColor = Color.FromArgb(82, 96, 109);
            lblMonth.Location = new Point(100, 160);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(280, 32);
            lblMonth.TabIndex = 1;
            lblMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowDays
            // 
            flowDays.BackColor = Color.FromArgb(243, 246, 249);
            flowDays.Controls.Add(dayCardView1);
            flowDays.Controls.Add(dayCardView2);
            flowDays.Controls.Add(dayCardView3);
            flowDays.Controls.Add(dayCardView4);
            flowDays.Controls.Add(dayCardView5);
            flowDays.Controls.Add(dayCardView6);
            flowDays.Controls.Add(dayCardView7);
            flowDays.Location = new Point(12, 200);
            flowDays.Name = "flowDays";
            flowDays.Size = new Size(456, 100);
            flowDays.TabIndex = 4;
            flowDays.WrapContents = false;
            // 
            // dayCardView1
            // 
            dayCardView1.BorderStyle = BorderStyle.FixedSingle;
            dayCardView1.DayName = "Sat 12";
            dayCardView1.Location = new Point(3, 2);
            dayCardView1.Margin = new Padding(3, 2, 0, 2);
            dayCardView1.Name = "dayCardView1";
            dayCardView1.Size = new Size(62, 98);
            dayCardView1.TabIndex = 0;
            dayCardView1.TimeEnd = "-";
            dayCardView1.TimeStart = "-";
            // 
            // dayCardView2
            // 
            dayCardView2.BorderStyle = BorderStyle.FixedSingle;
            dayCardView2.DayName = "Sun 13";
            dayCardView2.Location = new Point(68, 2);
            dayCardView2.Margin = new Padding(3, 2, 0, 2);
            dayCardView2.Name = "dayCardView2";
            dayCardView2.Size = new Size(62, 98);
            dayCardView2.TabIndex = 1;
            dayCardView2.TimeEnd = "-";
            dayCardView2.TimeStart = "-";
            // 
            // dayCardView3
            // 
            dayCardView3.BorderStyle = BorderStyle.FixedSingle;
            dayCardView3.DayName = "Mon 14";
            dayCardView3.Location = new Point(133, 2);
            dayCardView3.Margin = new Padding(3, 2, 0, 2);
            dayCardView3.Name = "dayCardView3";
            dayCardView3.Size = new Size(62, 98);
            dayCardView3.TabIndex = 2;
            dayCardView3.TimeEnd = "16:00";
            dayCardView3.TimeStart = "09:00";
            // 
            // dayCardView4
            // 
            dayCardView4.BorderStyle = BorderStyle.FixedSingle;
            dayCardView4.DayName = "Tue 15";
            dayCardView4.Location = new Point(198, 2);
            dayCardView4.Margin = new Padding(3, 2, 0, 2);
            dayCardView4.Name = "dayCardView4";
            dayCardView4.Size = new Size(62, 98);
            dayCardView4.TabIndex = 3;
            dayCardView4.TimeEnd = "16:00";
            dayCardView4.TimeStart = "09:00";
            // 
            // dayCardView5
            // 
            dayCardView5.BorderStyle = BorderStyle.FixedSingle;
            dayCardView5.DayName = "Wed 16";
            dayCardView5.Location = new Point(263, 2);
            dayCardView5.Margin = new Padding(3, 2, 0, 2);
            dayCardView5.Name = "dayCardView5";
            dayCardView5.Size = new Size(62, 98);
            dayCardView5.TabIndex = 4;
            dayCardView5.TimeEnd = "16:00";
            dayCardView5.TimeStart = "09:00";
            // 
            // dayCardView6
            // 
            dayCardView6.BorderStyle = BorderStyle.FixedSingle;
            dayCardView6.DayName = "Thu 17";
            dayCardView6.Location = new Point(328, 2);
            dayCardView6.Margin = new Padding(3, 2, 0, 2);
            dayCardView6.Name = "dayCardView6";
            dayCardView6.Size = new Size(62, 98);
            dayCardView6.TabIndex = 5;
            dayCardView6.TimeEnd = "16:00";
            dayCardView6.TimeStart = "09:00";
            // 
            // dayCardView7
            // 
            dayCardView7.BorderStyle = BorderStyle.FixedSingle;
            dayCardView7.DayName = "Fri 18";
            dayCardView7.Location = new Point(393, 2);
            dayCardView7.Margin = new Padding(3, 2, 0, 2);
            dayCardView7.Name = "dayCardView7";
            dayCardView7.Size = new Size(62, 98);
            dayCardView7.TabIndex = 6;
            dayCardView7.TimeEnd = "16:00";
            dayCardView7.TimeStart = "09:00";
            // 
            // AvailabilityPickerView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(flowDays);
            Controls.Add(btnNextMonth);
            Controls.Add(btnNextWeek);
            Controls.Add(btnPrevMonth);
            Controls.Add(btnPrevWeek);
            Controls.Add(lblprofession);
            Controls.Add(lbldocname);
            Controls.Add(picDoctor);
            Controls.Add(lblTimeTableTitle);
            Controls.Add(lblMonth);
            Controls.Add(lblProfessionCap);
            Controls.Add(lblDocNameCap);
            Name = "AvailabilityPickerView";
            Size = new Size(480, 554);
            ((System.ComponentModel.ISupportInitialize)picDoctor).EndInit();
            flowDays.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTimeTableTitle;
        private PictureBox picDoctor;
        private Label lblDocNameCap;
        private Label lblProfessionCap;
        private Button btnPrevWeek;
        private Button btnNextWeek;
        private Button btnPrevMonth;
        private Button btnNextMonth;
        private ToolTip btnTip;
        private Label lbldocname;
        private Label lblprofession;
        private Label lblMonth;
        private FlowLayoutPanel flowDays;
        private DayCardView dayCardView1;
        private DayCardView dayCardView2;
        private DayCardView dayCardView3;
        private DayCardView dayCardView4;
        private DayCardView dayCardView5;
        private DayCardView dayCardView6;
        private DayCardView dayCardView7;
    }
}
