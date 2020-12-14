using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
    public partial class AllLabServices : Form
    {
        LabService.LabService labservice = new LabService.LabService();
        Panel panelContainer;
        public AllLabServices(Panel panel)
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


        private void PopulateDataGridView()
        {
            DataTable dt = labservice.GetAllLabService(textBoxSearch.Text.ToString());
            dgvLabServices.DataSource = dt;
        }

        private void AllLabServices_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }


        private void dgvLabServices_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int labServiceId = Convert.ToInt32(dgvLabServices.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new EditLabService(labServiceId, panelContainer));
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
