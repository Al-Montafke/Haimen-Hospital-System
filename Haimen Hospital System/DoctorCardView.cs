using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Haimen_Hospital_System
{
    public partial class DoctorCardView : UserControl
    {
        public DoctorCardView()
        {
            InitializeComponent();
        }

        private string _doctorName = "Drake Remoray";
        private string _doctorProfession = "Surgeon";
        private string _doctorRoom= "R301";

        [Category("Data")]
        [Description("Fills the docotr's name")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string DoctorName
        {
            get => _doctorName;
            set
            {
                _doctorName = value;
                lblDoctorName.Text = value;
            }
        }

        [Category("Data")]
        [Description("Fills the docotr's prfoession")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string DoctorProfession
        {
            get => _doctorProfession;
            set
            {
                _doctorProfession = value;
                lblProfession.Text = value;
            }
        }

        [Category("Data")]
        [Description("Fills the docotr's room")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string DoctorRoom
        {
            get => _doctorRoom;
            set
            {
                _doctorRoom = value;
                lblRoom.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Fills the image of the doctor")]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility (DesignerSerializationVisibility.Visible)]

        public Image? DoctorImage
        {
            get => picDoctor.Image;
            set
            {
                picDoctor.Image = value;
            }
        }
    }
}
