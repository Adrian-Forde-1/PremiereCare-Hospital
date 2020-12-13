using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.User
{
 //csr Class
    class CSR
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string salary { get; set; }

        public string sex { get; set; }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewCSR(CSR csr, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO CSR (csr_id, fname, lname, username, password, dob, salary, sex) VALUES (NEXT VALUE FOR csr_pk_seq ,@firstName, @lastName, @username, @password, @dob, @salary, @sex)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", csr.firstName);
                cmd.Parameters.AddWithValue("@lastName", csr.lastName);
                cmd.Parameters.AddWithValue("@username", csr.username);
                cmd.Parameters.AddWithValue("@password", csr.password);
                cmd.Parameters.AddWithValue("@dob", csr.dob);
                cmd.Parameters.AddWithValue("@salary", csr.salary);
                cmd.Parameters.AddWithValue("@sex", csr.sex);

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
                CustomMessageBox cm = new CustomMessageBox("Failed to add CSR to database", form);
                cm.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllCSR(string search)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql;
                if (search != "")
                {
                    sql = @"SELECT csr_id AS 'CSR ID', fname + ' ' + lname AS Name, sex AS Sex, dob as 'Date of Birth', username AS Username, salary AS Salary FROM CSR WHERE fname + ' ' + lname LIKE '%" + search + "%'";
                } else
                {
                    sql = "SELECT csr_id AS 'CSR ID', fname + ' ' + lname AS Name, sex AS Sex, dob as 'Date of Birth', username AS Username, salary AS Salary FROM CSR";
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
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetCSR(int csrId)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM CSR WHERE csr_id = @csrId";


                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@csrId", csrId);

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

        public bool EditCSR(CSR csr, int csrId, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "Update CSR Set fname = @firstName, lname = @lastName, dob = @dob, salary = @salary, username = @username, password = @password, sex = @sex WHERE csr_id = @csrId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", csr.firstName);
                cmd.Parameters.AddWithValue("@lastName", csr.lastName);
                cmd.Parameters.AddWithValue("@dob", csr.dob);
                cmd.Parameters.AddWithValue("@salary", csr.salary);
                cmd.Parameters.AddWithValue("@username", csr.username);
                cmd.Parameters.AddWithValue("@password", csr.password);
                cmd.Parameters.AddWithValue("@sex", csr.sex);
                cmd.Parameters.AddWithValue("@csrId", csrId);


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
