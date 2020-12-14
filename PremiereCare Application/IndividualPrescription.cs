using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
    public partial class IndividualPrescription : Form
    {
        int prescriptionId;
        Prescription.PrescribeMed prescription = new Prescription.PrescribeMed();
        Drug.Drug drug = new Drug.Drug();
        Panel panelContainer;
        public IndividualPrescription(int pId, Panel panel)
        {
            panelContainer = panel;
            prescriptionId = pId;
            InitializeComponent();
        }

        private void PopulateFields()
        {
            DataTable dt = prescription.GetPrescription(prescriptionId);
            DataRow row = dt.Rows[0];
            labelPrescriptionId.Text = row["Prescription Id"].ToString();
            labelDoctorName.Text = row["Doctor"].ToString();
            labelPatientName.Text = row["Patient"].ToString();
            labelDosage.Text = row["Dosage"].ToString();

            if(dt.Rows != null && dt.Rows.Count != 0)
            {
                DataTable drugDt = drug.GetDrugsFromPrescriptionID(prescriptionId);
                dgvAllDrugs.DataSource = drugDt;
            }
        }

        private void IndividualPrescription_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }
    }
}
