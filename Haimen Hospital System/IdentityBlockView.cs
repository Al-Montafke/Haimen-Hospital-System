using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haimen_Hospital_System
{
    public partial class IdentityBlockView : UserControl
    {
        public IdentityBlockView()
        {
            InitializeComponent();
        }

        readonly public static Guid _userId = Guid.NewGuid();

        private Guid _identityUserId = _userId;
        private string _identityGender = "Male";
        private string _identityEmail = "example@gmail.com";
        private string _identityEthnicity = "European";
        private string _identityNationalID = "241-21443553423-11212-42";
        private string _identityAge = "26";
        private string _identityBirthday = "14/04/1999";

        private string _identityName = "Jacob";

        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a user ID value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Guid UserId
        {
            get => _identityUserId;
            set
            {
                _identityUserId = value;
                lblIdentityUserId.Text = Convert.ToString(value);

            }
        }

        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a gender value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Gender
        {
            get => _identityGender;
            set
            {
                _identityGender = value;
                lblIdentityGender.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a mail value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Email
        {
            get => _identityEmail;
            set
            {
                _identityEmail = value;
                lblIdentityEmail.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns an ethnicity value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Ethnicity
        {
            get => _identityEthnicity;
            set
            {
                _identityEthnicity = value;
                lblIdentityEthnicity.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a National ID value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string NationalID
        {
            get => _identityNationalID;
            set
            {
                _identityNationalID = value;
                lblIdentityNationalId.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns an age value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Age
        {
            get => _identityAge;
            set
            {
                _identityAge = value;
                lblIdentityAge.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a birthday value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Birthday
        {
            get => _identityBirthday;
            set
            {
                _identityBirthday = value;
                lblIdentityBirthday.Text = Convert.ToString(value);

            }
        }
        [Category("Data")]
        [Browsable(true)]
        [Description("Assigns a name value to the user")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string UserName
        {
            get => _identityName;
            set
            {
                _identityName = value;
                lblIdentityName.Text = Convert.ToString(value);

            }
        }

        [Category("Appearance")]
        [Browsable(true)]
        [Editable(true)]
        [Description("Assigns an image to the picure box.")]
        [AllowNull]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Image UserImage
        {
            get => picIdentityPhoto.Image;

            set
            {
                picIdentityPhoto.Image = value;
            }
        }
    }
}
