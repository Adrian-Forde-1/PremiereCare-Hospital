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
    public partial class AllTechnicians : Form
    {
        User.Technician technician = new User.Technician();
        Panel panelContainer;

        public AllTechnicians(Panel panel)
        {
            panelContainer = panel;
            InitializeComponent();
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

        private void PopulateDataTable()
        {
            DataTable dt = technician.GetAllTechnicians(textBoxSearch.Text.ToString());
            dgvAllTechnicians.DataSource = dt;

        }

        private void AllTechnicians_Load(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void dgvAllTechnicians_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int technicianId = Convert.ToInt32(dgvAllTechnicians.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualTechnician(technicianId, panelContainer));
        }
    }
}
