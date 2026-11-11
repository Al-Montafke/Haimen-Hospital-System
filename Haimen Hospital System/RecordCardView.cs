using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Haimen_Hospital_System
{
    public partial class RecordCardView : UserControl
    {

        private Guid _recId = Guid.NewGuid();
        private string _recDate = "07/12/2026";
        private string _recDiagnoses = "Lung Cancer - stage 4";
        private string _recPrescription = "Advanced Chemical Operations";

        private Guid _docId = Guid.NewGuid();

        public RecordCardView()
        {
            InitializeComponent();
        }

        [Category("Data")]
        [Description("Assigns record ID to the record")]
        [Browsable(false)]
        //[Editable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Guid RecordId
        {
            get => _recId;
            set 
            {
                _recId = value;
                lblrecId.Text = value.ToString();
            }
        }

        [Category("Data")]
        [Description("Assigns Id to a doctor")] // Temporary - Doc ID should be assigned somewhere else.
        [Browsable(false)]
        //[Editable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public Guid DoctorId
        {
            get => _docId;
            set
            {
                _docId = value;
                lblDoctorId.Text = value.ToString();
            }
        }

        [Category("Data")]
        [Description("Assigns date to the record")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string RecordDate
        {
            get => _recDate;
            set
            {
                _recDate = value;
                lbldate.Text = value;
            }
        }

        [Category("Data")]
        [Description("Assigns value to the diagnoses property")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Diagnoses
        {
            get => _recDiagnoses;
            set
            {
                _recDiagnoses = value;
                lbldiagnoses.Text = value;
            }
        }

        [Category("Data")]
        [Description("Assigns value to the prescritpion")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public string Prescription
        {
            get => _recPrescription;
            set
            {
                _recPrescription = value;
                lblpers.Text = value;
            }
        }
    }
}
