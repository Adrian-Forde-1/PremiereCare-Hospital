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
    public partial class ViewLabTest : Form
    {
        LabTest.LabTest labtest = new LabTest.LabTest();

        public ViewLabTest()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            
            DataTable dt;
            string qry = @"SELECT  
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
                                 ORDER BY a.appointment_date ASC";  
             
            labtest.GetAllLabTest( qry, out dt );
            dgvViewLabTest.DataSource = dt;
        }

        private void ViewLabTest_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get the value from textbox
            string keyword = textBox1.Text;
            DataTable dt;
            string qry = @"SELECT  
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
                                   
            labtest.GetAllLabTest(qry, out dt);
            dgvViewLabTest.DataSource = dt;
            
        }
    }
}
