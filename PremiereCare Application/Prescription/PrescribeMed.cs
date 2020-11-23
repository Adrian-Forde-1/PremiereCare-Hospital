using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Prescription
{
    class PrescribeMed
    {
        public string appointment_id { get; set; }
        public string drug_id { get; set; }
        public string dosage { get; set; }
        public string patient_id { get; set; }
        public string prescription_id { get; set; }
        

        SqlCommand cmd_;
        SqlConnection conn_;
        SqlDataAdapter dtadapter_;
        SqlDataReader dtread_;
        DataTable dt_;
        DataSet dts_;
        //Private Attributes
       static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public string GetMessage { get; set; }

        public string insertData(string query, PrescribeMed premed, Form form)
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
                else if (allquerys.Contains("Delete from"))
                {
                    ret = GetMessage = ("Deleted Successfully");
                }
                else if (allquerys.Contains("Update into") && allquerys.Contains("set"))
                {
                    ret = GetMessage = ("Update Successfully");
                }

                cmd_= new SqlCommand(allquerys, conn_);
                conn_.Open();
                cmd_.ExecuteNonQuery();
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
                ret= GetMessage = "Faild to execute" + query + "\n reasion : " + ex.Message;

            }
            finally 
            {
                conn_.Close(); ; 
            }
            return ret;


        }

        public string getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            string ret = "";
            List<string> data = new List<string>();
            
            //Step 1: Create database connection string query,
             conn_ = new SqlConnection(myconnstring);
            

            try
            {
                //Step 2: Writing SQL Query
                string qry = "SELECT drug  FROM [PremiereCareHospital].[dbo].Drug";
                
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
                MessageBox.Show(ex.ToString());
                ret = GetMessage = "Faild to execute select Drug!!! \n reasion : " + ex.Message;
                data.Clear();
            }
            finally
            {
                //Close Connection
                conn_.Close();
            }

            columndata = data;
            return ret;
        }


        public string getSingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string ret = "", val = null;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);
            
            try
            {
                //Step 2: Writing SQL Query
                string qry  = query;

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
                ret = GetMessage = "Faild to execute!!! "+ query +" \n reasion : " + ex.Message;
            }
            finally
            {
                conn_.Close();
            }

            columndata = val;
            return ret;

        }

        public string getPrescription_ID(string query, out string searchData)
        {
            string  ret ="", val = null;
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
                MessageBox.Show( ex.ToString() );
                ret = GetMessage = "Faild to execute getPrescription_ID!!! \n reasion : " + ex.Message;
            }
            finally
            {
                conn_.Close();
            }
            searchData = val;
            return ret;
        }

       

    }    
}
