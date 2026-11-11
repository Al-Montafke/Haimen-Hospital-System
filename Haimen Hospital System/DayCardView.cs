using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haimen_Hospital_System
{
    public partial class DayCardView : UserControl
    {


        private string _dayName = "Saturday";
        private string _timeStart = "09:00";
        private string _timeEnd = "16:00";

        [Category("Data")]
        [Description("Fills the days item for the user")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DayName
        {
            get => _dayName;
            set
            {
                _dayName = value;
                lblDayName.Text = value;
            }
        }
        [Category("Data")]
        [Description("Fills the time start item for the user")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TimeStart
        {
            get => _timeStart;
            set
            {
                _timeStart = value;
                lblTimeStart.Text = value;
            }
        }

        [Category("Data")]
        [Description("Fills the time end item for the user")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TimeEnd
        {
            get => _timeEnd;
            set
            {
                _timeEnd = value;
                lblTimeEnd.Text = value;
            }
        }

        public DayCardView()
        {
            InitializeComponent();
        }
    }

}
