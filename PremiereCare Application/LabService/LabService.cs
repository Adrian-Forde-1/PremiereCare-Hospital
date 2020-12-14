using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.LabService
{
    class LabService
    {

        public string service { get; set; }
        public string cost { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewLabService(LabService labservice, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Lab_Services (service_id, service, cost) VALUES (NEXT VALUE FOR lab_service_seq ,@service, @cost)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@service", labservice.service);
                cmd.Parameters.AddWithValue("@cost", labservice.cost);

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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add Lab Service", form);
                //cm.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllLabService(string search)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql;

                if(search != "")
                {
                    sql = "SELECT service_id AS 'ID', service AS 'Service', cost AS 'Cost' FROM Lab_Services WHERE service LIKE '%" + search + "%'";
                } else
                {
                    sql = "SELECT service_id AS 'ID', service AS 'Service', cost AS 'Cost' FROM Lab_Services";
                }

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetAllLabServiceForTest(int testID)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = @"SELECT 
                                ls.service AS 'Service',
                                ls.cost AS 'Cost'
                                FROM [PremiereCareHospital].[dbo].[Service] s
                                JOIN [PremiereCareHospital].[dbo].[Lab_Services] ls 
                                	ON s.service_id = ls.service_id
                                WHERE test_id=@testID;";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@testID", testID);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetLabService(int serviceId)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM Lab_Services WHERE service_id = @serviceId";


                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@serviceId", serviceId);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public bool EditLabService(LabService labService, int serviceId, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "Update Lab_Services Set service = @service, cost = @cost WHERE service_id = @drugId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@service", labService.service);
                cmd.Parameters.AddWithValue("@cost", labService.cost);
                cmd.Parameters.AddWithValue("@drugId", serviceId);


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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add patient", form);
                //cm.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
