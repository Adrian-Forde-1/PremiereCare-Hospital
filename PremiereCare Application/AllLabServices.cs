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
        public AllLabServices()
        {
            InitializeComponent();
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

        }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
