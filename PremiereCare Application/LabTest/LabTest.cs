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
        /*public string docID { get; set; }
        public string techID { get; set; }
        public string appointmentID { get; set; }
        public string results { get; set; }
        public string status { get; set; }
        */

        SqlCommand cmd_;
        SqlConnection conn_;
        SqlDataAdapter dtadapter_;
        SqlDataReader dtread_;
        DataTable dt_;
        DataSet dts_;

        public string GetMessage { get; set; }


        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;
             
                
        public string insertData(string query, LabTest labtest, Form form)
        {
            string ret = "";
            string allquerys = query.ToLower();
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                
                if (allquerys.ToLower().Contains("insert into"))
                {
                    ret = GetMessage = ("Insert Successfully");
                }
                else if(allquerys.Contains("Delete from"))
                {
                    ret = GetMessage = ("Deleted Successfully");
                }
                else if (allquerys.Contains("Update into") && allquerys.Contains("set")) 
                {
                    ret = GetMessage = ("Update Successfully");
                }
                
                cmd_ = new SqlCommand(allquerys, conn_);
                conn_.Open();
                cmd_.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ret = GetMessage = "Faild to execute" + query + "\n reasion : " + ex.Message;

            }
            finally
            {
                conn_.Close(); 
            }
            return ret; 
                      
            
        }

        public string getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            List<string> data = new List<string>();
            string ret;

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

                ret = GetMessage = "Operation Successfull! Values successfully got from getSingleValueArrayIndex() function";


            }
            catch (Exception ex)
            {
                ret = "Error in Labtest -> getSingleValueArrayIndex() Reason: " + ex.Message;
                GetMessage = "Error in Labtest getSingleValueArrayIndex() for dtread_ \n" + ex.Message;
                data.Clear();
            }
            finally
            {
                conn_.Close();
            }

            columndata = data;
            return ret;
        }

        public string getSingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string ret, val = null;
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

                ret = "Operation Successfull!";
                GetMessage = "Values successfully got from getSingleValueArrayIndex() function";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ret = GetMessage = "Faild to execute!!! " + query + " \n reasion : " + ex.Message;

            }
            finally
            {
                conn_.Close();
            }

            columndata = val;
            return ret;
        }

        public string getTest_ID(string query, out string searchData)
        {
            string ret = "", val = null;
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

                val = dtread_.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ret = GetMessage = "Faild to execute" + query + "\n reasion : " + ex.Message;
                
            }
            finally 
            {
                conn_.Close();
            }
            searchData = val;
            return ret;
        }

       

        

        public DataTable GetAllLabTest(string query, out DataTable searchData)
        {
            string ret = "";

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
                ret = GetMessage = "Faild to execute getPrescription_ID!!! \n reasion : " + ex.Message;
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
