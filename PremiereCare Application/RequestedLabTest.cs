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
            DataTable dt = labtest.GetAllLabTest(userRole, userID); 
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
            //Get the value from textbox
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            string qry = "";
            if (userRole == "Technicians") qry = @"SELECT  
                                            lt.test_id AS 'Test#',
                                            lt.appointment_id AS 'Appointment', 
                                            a.appointment_date AS 'Submited Date',
                                            d.fname + ' ' + d.lname AS 'Doctor Name',
								            p.fname + ' ' + p.lname AS 'Patient Name',
                                            ls.service AS 'Test Requested',
                                            lt.status AS 'Status', 
                                            lt.results AS 'Results' 
                                             FROM[PremiereCareHospital].[dbo].Lab_Test lt
                                            JOIN[PremiereCareHospital].[dbo].Doctor d
                                                ON lt.doc_id = d.doc_id
                                            JOIN[PremiereCareHospital].[dbo].Appointment a
                                                ON lt.appointment_id = a.appointment_id
                                            JOIN[PremiereCareHospital].[dbo].Service s  
                                                ON lt.test_id = s.test_id 
								            JOIN[PremiereCareHospital].[dbo].Lab_Services ls  
                                                ON s.service_id = ls.service_id
								            JOIN[PremiereCareHospital].[dbo].Patient p  
                                                ON a.patient_id = p.patient_id	
                                             WHERE
                                            (lt.test_id LIKE '%" + keyword +
                                            "%' OR lt.appointment_id LIKE '%" + keyword +
                                            "%' OR a.appointment_date LIKE '%" + keyword +
                                            "%' OR d.fname + ' ' + d.lname LIKE '%" + keyword +
                                            "%' OR p.fname + ' ' + p.lname LIKE '%" + keyword +
                                            "%' OR ls.service LIKE '%" + keyword +
                                            "%' OR lt.status LIKE '%" + keyword +
                                            "%' OR lt.results LIKE '%" + keyword +
                                            "%')ORDER BY a.appointment_date ASC";

            else if (userRole == "Doctor") qry = @"SELECT
                                                    lt.test_id AS 'Test#',
                                                    lt.appointment_id AS 'Appointment', 
                                                    a.appointment_date AS 'Submited Date',
                                                    d.fname + ' ' + d.lname AS 'Doctor Name',
								                    p.fname + ' ' + p.lname AS 'Patient Name',
                                                    ls.service AS 'Test Requested',
                                                    lt.status AS 'Status', 
                                                    lt.results AS 'Results' 
                                                     FROM[PremiereCareHospital].[dbo].Lab_Test lt
                                                    JOIN[PremiereCareHospital].[dbo].Doctor d
                                                        ON lt.doc_id = d.doc_id
                                                    JOIN[PremiereCareHospital].[dbo].Appointment a
                                                        ON lt.appointment_id = a.appointment_id
                                                    JOIN[PremiereCareHospital].[dbo].Service s  
                                                        ON lt.test_id = s.test_id 
								                    JOIN[PremiereCareHospital].[dbo].Lab_Services ls  
                                                        ON s.service_id = ls.service_id
								                    JOIN[PremiereCareHospital].[dbo].Patient p  
                                                        ON a.patient_id = p.patient_id	
                                                     WHERE (d.doc_id = @userID AND 
                                                    lt.test_id LIKE '%" + keyword +
                                                    "%' OR lt.appointment_id LIKE '%" + keyword +
                                                    "%' OR a.appointment_date LIKE '%" + keyword +
                                                    "%' OR d.fname + ' ' + d.lname LIKE '%" + keyword +
                                                    "%' OR p.fname + ' ' + p.lname LIKE '%" + keyword +
                                                    "%' OR ls.service LIKE '%" + keyword +
                                                    "%' OR lt.status LIKE '%" + keyword +
                                                    "%' OR lt.results LIKE '%" + keyword +
                                                    "%')ORDER BY a.appointment_date ASC";

            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(qry, conn);
            if (userRole == "Doctor")
            {
                cmd.Parameters.AddWithValue("@userID", userID);
            }

            //Creating SQL DataAdapter using cmd
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            conn.Open();
            dtadapter.Fill(dt);
            conn.Close();
            dgvRequestedLabTest.DataSource = dt;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
