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
    public partial class ViewPatients : Form
    {
        private int userID;

        Patient.Patient patient = new Patient.Patient();
        Panel panelContainer;

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

        public ViewPatients(Panel panel, int usrID)
        {
            InitializeComponent();
            PopulateDataGridView();
            panelContainer = panel;
            userID = usrID;
        }

        private void PopulateDataGridView()
        {
            DataTable dt = patient.GetAllPatients(textBoxSearch.Text.ToString());
            dgvPatients.DataSource = dt;
        }

        private void dgvPatients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int patientID = Convert.ToInt32(dgvPatients.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualPatient(userID, patientID, panelContainer));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
