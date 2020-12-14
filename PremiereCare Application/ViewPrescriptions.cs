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
    public partial class ViewPrescriptions : Form
    {
        private int appointmentID;
        Panel panelContainer;
        Prescription.PrescribeMed prescription = new Prescription.PrescribeMed();

        public ViewPrescriptions(int appID, Panel panel)
        {
            panelContainer = panel;
            InitializeComponent();
            appointmentID = appID;
            PopulateDataGridView();
        }

        private void OpenChildForm(Form childForm)
        {
            this.Close();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PopulateDataGridView()
        {
            DataTable dt = prescription.GetAllPrescriptionsForAppointment(appointmentID);
            dgvAllPrescriptions.DataSource = dt;
        }

        private void dgvAllPrescriptions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int prescriptionId = Convert.ToInt32(dgvAllPrescriptions.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualPrescription(prescriptionId, panelContainer));
        }
    }
}
