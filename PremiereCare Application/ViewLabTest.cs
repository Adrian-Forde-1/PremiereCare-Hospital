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
                         
           DataTable dt = labtest.GetAllLabTest(userRole, userID);
            dgvViewLabTest.DataSource = dt;
        }

        private void ViewLabTest_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            string qry = "";
            if (userRole == "Technician") qry = @"SELECT  
                                                 lt.test_id AS 'Test#',
                                                 lt.appointment_id AS 'Appointment', 
                                                 a.appointment_date AS 'Date Requested',
                                                 d.fname + ' ' + d.lname AS 'Doctor Name', 
                                                 d.specialty AS 'Doctor Specialty',
			                                     p.fname + ' ' + p.lname AS 'Patient Name',
                                                 lts.status AS 'Status' 
                                             FROM[PremiereCareHospital].[dbo].Lab_Test lt
                                            JOIN[PremiereCareHospital].[dbo].Doctor d
                                                ON lt.doc_id = d.doc_id
                                            JOIN[PremiereCareHospital].[dbo].Appointment a
                                                ON lt.appointment_id = a.appointment_id                                           
								            JOIN[PremiereCareHospital].[dbo].Patient p  
                                                ON a.patient_id = p.patient_id	
                                            JOIN[PremiereCareHospital].[dbo].Lab_Test_Status lts
                                                     ON lt.status_id = lts.status_id
                                             WHERE
                                            (lt.test_id LIKE '%" + keyword +
                                            "%' OR lt.appointment_id LIKE '%" + keyword +
                                            "%' OR a.appointment_date LIKE '%" + keyword +
                                            "%' OR d.fname + ' ' + d.lname LIKE '%" + keyword +
                                            "%' OR p.fname + ' ' + p.lname LIKE '%" + keyword +
                                            "%' OR lts.status LIKE '%" + keyword +
                                            "%' OR lt.results LIKE '%" + keyword +
                                            "%')ORDER BY a.appointment_date ASC";

            else if (userRole == "Doctor") qry = @"SELECT
                                                     lt.test_id AS 'Test#',
                                                     lt.appointment_id AS 'Appointment', 
                                                     a.appointment_date AS 'Date Requested',
                                                     d.fname + ' ' + d.lname AS 'Doctor Name', 
                                                     d.specialty AS 'Doctor Specialty',
			                                         p.fname + ' ' + p.lname AS 'Patient Name',
                                                     lts.status AS 'Status', 
                                                     lt.results AS 'Results'
                                                     FROM[PremiereCareHospital].[dbo].Lab_Test lt
                                                    JOIN[PremiereCareHospital].[dbo].Doctor d
                                                        ON lt.doc_id = d.doc_id
                                                    JOIN[PremiereCareHospital].[dbo].Appointment a
                                                        ON lt.appointment_id = a.appointment_id                                                    
								                    JOIN[PremiereCareHospital].[dbo].Patient p  
                                                        ON a.patient_id = p.patient_id
                                                    JOIN[PremiereCareHospital].[dbo].Lab_Test_Status lts
                                                        ON lt.status_id = lts.status_id
                                                     WHERE (d.doc_id = @userID AND 
                                                    lt.test_id LIKE '%" + keyword +
                                                    "%' OR lt.appointment_id LIKE '%" + keyword +
                                                    "%' OR a.appointment_date LIKE '%" + keyword +
                                                    "%' OR d.fname + ' ' + d.lname LIKE '%" + keyword +
                                                    "%' OR p.fname + ' ' + p.lname LIKE '%" + keyword +
                                                    "%' OR lts.status LIKE '%" + keyword +
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
            dgvViewLabTest.DataSource = dt;
        }

        private void dgvViewLabTest_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int testID = Convert.ToInt32(dgvViewLabTest.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualLabTest(userRole, userID, testID, panelContainer));
        }
    }
}
