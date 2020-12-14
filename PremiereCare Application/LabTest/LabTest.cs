using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.LabTest
{
    class LabTest
    {
        public string docID { get; set; }
        public string techID { get; set; }
        public string appointmentID { get; set; }
        public string results { get; set; }
        //public string status { get; set; }
        //public string serviceID { get; set; }
        //public string testID { get; set; }

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter dtadapter;
        DataTable dt;
        //SqlDataReader dtread;
        //DataSet dts_;

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool CreateLabRequest(LabTest labtest, Form form)
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                string qry = @"INSERT INTO  [PremiereCareHospital].[dbo].Lab_Test (test_id, doc_id, appointment_id) 
                            VALUES(NEXT VALUE FOR lab_test_seq, @doctor, @appointment)";

                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@doctor", labtest.docID);
                cmd.Parameters.AddWithValue("@appointment", labtest.appointmentID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close(); 
            }
            return isSuccess;
        }

        public bool SubmitTestResults(int labTestID, LabTest labtest, Form form) 
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                string qry = @" UPDATE [PremiereCareHospital].[dbo].Lab_Test SET tech_id=@tech_id, results=@results, status_id=@status WHERE test_id = @labTestID ";

                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@results", labtest.results);
                cmd.Parameters.AddWithValue("@tech_id", labtest.techID);                
                cmd.Parameters.AddWithValue("@status", 2);
                cmd.Parameters.AddWithValue("@labTestID", labTestID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
                
        public bool SetServices(int testID, List<int> IDs, Form form)
        {
            bool isSuccess = false;
            bool errors = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);


            foreach (int ID in IDs)
            {
                try
                {
                    string query = @"INSERT INTO [PremiereCareHospital].[dbo].Service (service_id, test_id) 
                            VALUES(@service_id, @test_id)";

                    /*cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@service_id", labtest.serviceID);
                    cmd.Parameters.AddWithValue("@test_id", labtest.testID);
                    */
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@service_id", ID);
                    cmd.Parameters.AddWithValue("@test_id", testID);

                    //cmd_.ExecuteNonQuery();
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }               

            }
            return isSuccess;
        }

        public DataTable GetAllLabTest(string search, string userRole, int userID)
        {

            // Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            dt = new DataTable();

            try
            {
                //Step 2: Writing SQL Query  
               string qry ="";
                if (search != "")
                {

                        if (userRole == "Doctor")
                        { 
                               qry = @"SELECT
                                             lt.test_id AS 'Test ID',
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
                                                  lt.test_id LIKE '%" + search +
                                               "%' OR lt.appointment_id LIKE '%" + search +
                                               "%' OR a.appointment_date LIKE '%" + search +
                                               "%' OR d.fname + ' ' + d.lname LIKE '%" + search +
                                               "%' OR p.fname + ' ' + p.lname LIKE '%" + search +
                                               "%' OR lts.status LIKE '%" + search +
                                               "%')ORDER BY a.appointment_date ASC";
                        }
                            else if (userRole == "Technician")
                            {
                                    qry = @"SELECT  
                                                     lt.test_id AS 'Test ID',
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
                                                    WHERE
                                                        (lt.test_id LIKE '%" + search +
                                                        "%' OR lt.appointment_id LIKE '%" + search +
                                                        "%' OR a.appointment_date LIKE '%" + search +
                                                        "%' OR d.fname + ' ' + d.lname LIKE '%" + search +
                                                        "%' OR p.fname + ' ' + p.lname LIKE '%" + search +
                                                        "%' OR lts.status LIKE '%" + search +
                                                        "%)ORDER BY a.appointment_date ASC";
                            }




                }
                   else
                   {
                         if (userRole == "Doctor") 
                         {            
                               qry = @"SELECT  
                                             lt.test_id AS 'Test ID',
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
                                             WHERE d.doc_id = @userID
                                             ORDER BY a.appointment_date ASC";
                         }
                                else if (userRole == "Technician")
                                {
                                      qry = @"SELECT      
                                                    lt.test_id AS 'Test ID',
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
                                                     ORDER BY a.appointment_date ASC";
                                }

                   }

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);
                if (userRole == "Doctor")
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                }

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();
                dtadapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            //searchData = dt;
            return dt;
        }

        public DataTable GetAllAppointmentLabTest(int appointmentID)
        {

            // Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string query = "SELECT * FROM [PremiereCareHospital].[dbo].[Lab_Test] WHERE appointment_id=@appointmentID";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@appointmentID", appointmentID);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();


                dtadapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetMostRecentTestID()
        {

            // Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT TOP 1 test_id FROM[PremiereCareHospital].[dbo].[Lab_Test]
                                ORDER BY test_id DESC";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtadapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetLabTest(int labTestID)
         {
             SqlConnection conn = new SqlConnection(myconnstring);
             DataTable dt = new DataTable();
             try
             {
                 string qry = @"SELECT	 
			                    lt.test_id AS 'Test#',
                                a.appointment_id AS 'Appointment ID',
			                    d.fname  AS  'Doctor First Name',
                                d.lname AS  'Doctor Last Name',
                                d.specialty AS 'Doctor Specialty',
			                    p.fname AS 'Patient First Name',
                                p.lname AS  'Patient Last Name',
			                    a.appointment_date AS 'Requested Date',
			                    lts.status AS 'Status',
			                    lt.results AS 'Results'
			                    FROM[PremiereCareHospital].[dbo].Lab_Test lt
                                 JOIN[PremiereCareHospital].[dbo].Doctor d
                                     ON lt.doc_id = d.doc_id
                                 JOIN[PremiereCareHospital].[dbo].Appointment a
                                     ON lt.appointment_id = a.appointment_id
                                 JOIN[PremiereCareHospital].[dbo].Service s  
                                     ON lt.test_id = s.test_id                                 
                                 JOIN[PremiereCareHospital].[dbo].Patient p  
                                     ON a.patient_id = p.patient_id
                                JOIN[PremiereCareHospital].[dbo].Lab_Test_Status lts
                                    ON lt.status_id = lts.status_id
				                    WHERE s.test_id = @labTestID				 
                                 ORDER BY a.appointment_date ASC";

                SqlCommand cmd = new SqlCommand(qry, conn);
                 cmd.Parameters.AddWithValue("@labTestID", labTestID);

                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 conn.Open();
                 adapter.Fill(dt);
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
             finally
             {
                 conn.Close();
             }
             return dt;
         } 




    }

}
