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
        public string status { get; set; }
        public string serviceID { get; set; }
        public string testID { get; set; }

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter dtadapter;
        SqlDataReader dtread;
        DataTable dt;
        //DataSet dts_;

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool RequestLabTest( LabTest labtest, Form form)
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

        public bool TestResults(LabTest labtest, Form form) 
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                string qry = @"UPDATE [dbo].[Lab_Test] SET(tech_id = @tech_id, results = @results, status = @status)
                               WHERE(test_id = )";

                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@tech_id", labtest.techID);
                cmd.Parameters.AddWithValue("@results", labtest.results);
                cmd.Parameters.AddWithValue("@status", labtest.status);

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

        public bool Service(List<string> ids, LabTest labtest, Form form)
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
                   
                    cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@service_id", labtest.serviceID);
                    cmd.Parameters.AddWithValue("@test_id", labtest.testID);

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
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close(); 
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

        public void getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            List<string> data = new List<string>();

            //Step 1: Create database connection string query,
            conn= new SqlConnection(myconnstring);
            conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry = "SELECT service  FROM [PremiereCareHospital].[dbo].Lab_Services";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);

                conn.Open();

                dtread = cmd.ExecuteReader();

                while (dtread.Read())
                {
                    data.Add(dtread[index].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                data.Clear();
            }
            finally
            {
                conn.Close();
            }
            columndata = data;
           
        }

        public void getSingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry = query;

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtread = cmd.ExecuteReader();

                while (dtread.Read())
                {
                    val = dtread[index].ToString();
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
            columndata = val;
        }

        public string getTest_ID(string appointmentID)
        {
            string  val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
               string qry = @"SELECT test_id FROM [PremiereCareHospital].[dbo].Lab_Test 
                                WHERE appointment_id='" + appointmentID + "' ";


                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtread = cmd.ExecuteReader();

                val = dtread.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                conn.Close();
            }
            
            return val;
        }

        public DataTable GetAllLabTest(string userRole, int userID)//string query,
        {

            // Step 1: Create database connection string query,
             conn = new SqlConnection(myconnstring);
            dt = new DataTable();
            conn = new SqlConnection(myconnstring);
            dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query  

                string qry = "";  
                if (userRole == "CSR") qry = @"SELECT      
                                                 lt.test_id AS 'Test#',
                                                 lt.appointment_id AS 'Appointment', 
                                                 a.appointment_date AS 'Date Requested',
                                                 d.fname + ' ' + d.lname AS 'Doctor Name', 
                                                 d.specialty AS 'Doctor Specialty',
			                                     p.fname + ' ' + p.lname AS 'Patient Name',
                                                 ls.service AS 'Requested Test',
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

                else if (userRole == "Doctor") qry = @"SELECT  
                                                         lt.test_id AS 'Test#',
                                                         lt.appointment_id AS 'Appointment', 
                                                         a.appointment_date AS 'Date Requested',
                                                         d.fname + ' ' + d.lname AS 'Doctor Name', 
                                                         d.specialty AS 'Doctor Specialty',
			                                             p.fname + ' ' + p.lname AS 'Patient Name',
                                                         ls.service AS 'Requested Test',
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
                                                          WHERE d.doc_id = @userID
                                                          ORDER BY a.appointment_date ASC";

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
            searchData = dt;
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
                cmd = new SqlCommand(qry, conn);
                if (userRole == "Doctor")
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                }

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();


                dtadapter.Fill(dt);
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
                                ls.Service AS 'Requested Test',
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
				                    WHERE s.test_id = @labTestID				 
                                 ORDER BY a.appointment_date ASC;";

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
