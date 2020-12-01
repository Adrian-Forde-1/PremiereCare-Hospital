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
    public partial class RequestedLabTest : Form
    {
        LabTest.LabTest labtest = new LabTest.LabTest();
        Panel panelContainer;

        private string userRole;
        private int userID;
                
        public RequestedLabTest(string usrRole, int usrID, Panel panel)
        {
            InitializeComponent();
            panelContainer = panel;
            userID = usrID;
            userRole = usrRole;
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
            dgvRequestedLabTest.DataSource = dt;
        }

        private void RequestedLabTest_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvRequestedLabTest_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int testID = Convert.ToInt32(dgvRequestedLabTest.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualLabTest(userRole, userID, testID, panelContainer));
        }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
