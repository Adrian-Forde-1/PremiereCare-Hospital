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
            DataTable dt = labservice.GetAllLabService();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            string qry = @"SELECT  service_id AS 'ID', service AS 'Service', cost AS 'Cost' FROM Lab_Services WHERE 
                                                                                    (service_id LIKE '%" + keyword +
                                                                                    "%' OR service LIKE '%" + keyword +
                                                                                    "%' OR cost LIKE '%" + keyword + "%')";

            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(qry, conn);

            //Creating SQL DataAdapter using cmd
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            conn.Open();
            dtadapter.Fill(dt);
            conn.Close();
            dgvLabServices.DataSource = dt;
        }


    }
}
