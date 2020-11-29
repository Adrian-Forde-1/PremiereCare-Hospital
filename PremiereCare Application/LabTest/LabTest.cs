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

        public string GetMessage { get; set; }


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

        public void getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            List<string> data = new List<string>();

            //Step 1: Create database connection string query,
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

        public DataTable GetAllLabTest(string query, out DataTable searchData)
        {

            // Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = query;

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




    }
    
}
