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
    

    public partial class ViewLabTest : Form
    {
        LabTest.LabTest labtest = new LabTest.LabTest();
        Panel panelContainer;

        private string userRole;
        private int userID;

        public ViewLabTest(String usrRole, int uID, Panel panel)
        {
            InitializeComponent();
            userRole = usrRole;
            userID = uID;
            panelContainer = panel;
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
           DataTable dt = labtest.GetAllLabTest(textBoxSearch.Text.ToString(), userRole, userID);
            dgvViewLabTest.DataSource = dt;
        }

        private void ViewLabTest_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvViewLabTest_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int testID = Convert.ToInt32(dgvViewLabTest.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualLabTest(userRole, userID, testID, panelContainer));
        }
    }
}
