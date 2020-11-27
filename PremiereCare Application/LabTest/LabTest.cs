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

        SqlCommand cmd_;
        SqlConnection conn_;
        SqlDataAdapter dtadapter_;
        SqlDataReader dtread_;
        DataTable dt_;
        //DataSet dts_;

        public string GetMessage { get; set; }


        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool TestRequest( LabTest labtest, Form form)
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                string qry = @"INSERT INTO  [PremiereCareHospital].[dbo].Lab_Test (test_id, doc_id, appointment_id) 
                            VALUES(NEXT VALUE FOR lab_test_seq, @doctor, @appointment)";

                cmd_ = new SqlCommand(qry, conn_);
                cmd_.Parameters.AddWithValue("@doctor", labtest.docID);
                cmd_.Parameters.AddWithValue("@appointment", labtest.appointmentID);

                conn_.Open();
                int rows = cmd_.ExecuteNonQuery();

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
                conn_.Close(); 
            }
            return isSuccess;
        }

        public bool Service(List<string> ids, LabTest labtest, Form form)
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                foreach (string item in ids)
                {
                    serviceID = item;
                    string qry = @"INSERT INTO [PremiereCareHospital].[dbo].Service (service_id, test_id) 
                            VALUES(@service_id, @test_id)";
                   
                    cmd_ = new SqlCommand(qry, conn_);
                    cmd_.Parameters.AddWithValue("@service_id", labtest.serviceID);
                    cmd_.Parameters.AddWithValue("@test_id", labtest.testID);

                    //cmd_.ExecuteNonQuery();
                    conn_.Open();
                    int rows = cmd_.ExecuteNonQuery();

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
                conn_.Close(); 
            }
            return isSuccess; 
                      
            
        }

        public void getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            List<string> data = new List<string>();
           
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry = "SELECT service  FROM [PremiereCareHospital].[dbo].Lab_Services";

                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);

                conn_.Open();

                dtread_ = cmd_.ExecuteReader();

                while (dtread_.Read())
                {
                    data.Add(dtread_[index].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                data.Clear();
            }
            finally
            {
                conn_.Close();
            }
            columndata = data;
           
        }

        public void getSingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry = query;

                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);
                conn_.Open();

                dtread_ = cmd_.ExecuteReader();

                while (dtread_.Read())
                {
                    val = dtread_[index].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn_.Close();
            }
            columndata = val;
        }

        public string getTest_ID(string appointmentID)
        {
            string  val = null;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
               string qry = @"SELECT test_id FROM [PremiereCareHospital].[dbo].Lab_Test 
                                WHERE appointment_id='" + appointmentID + "' ";


                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);
                conn_.Open();

                dtread_ = cmd_.ExecuteReader();

                val = dtread_.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                conn_.Close();
            }
            
            return val;
        }

        public DataTable GetAllLabTest(string query, out DataTable searchData)
        {

            // Step 1: Create database connection string query,
             conn_ = new SqlConnection(myconnstring);
            dt_ = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = query;

                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);
                conn_.Open();

                
                dtadapter_.Fill(dt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn_.Close();
            }
            searchData = dt_;
            return dt_;
        }
            
       


    }
    
}
