using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.User
{
    class CSR
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string salary { get; set; }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewCSR(CSR csr, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO CSR (csr_id, fname, lname, username, password, dob, salary) VALUES (NEXT VALUE FOR csr_pk_seq ,@firstName, @lastName, @username, @password, @dob, @salary)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", csr.firstName);
                cmd.Parameters.AddWithValue("@lastName", csr.lastName);
                cmd.Parameters.AddWithValue("@username", csr.username);
                cmd.Parameters.AddWithValue("@password", csr.password);
                cmd.Parameters.AddWithValue("@dob", csr.dob);
                cmd.Parameters.AddWithValue("@salary", csr.salary);

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
    }
}
