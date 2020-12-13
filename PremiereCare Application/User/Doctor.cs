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
    //Doctor Class
    class Doctor
    {
        //Public Attributes
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string salary { get; set; }
        public string specialty { get; set; }
        public string sex { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewDoctor(Doctor doctor, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Doctor (doc_id, fname, lname, username, password, dob, salary, specialty, sex) VALUES (NEXT VALUE FOR doc_pk_seq ,@firstName, @lastName, @username, @password, @dob, @salary, @specialty, @sex)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", doctor.firstName);
                cmd.Parameters.AddWithValue("@lastName", doctor.lastName);
                cmd.Parameters.AddWithValue("@username", doctor.username);
                cmd.Parameters.AddWithValue("@password", doctor.password);
                cmd.Parameters.AddWithValue("@dob", doctor.dob);
                cmd.Parameters.AddWithValue("@salary", doctor.salary);
                cmd.Parameters.AddWithValue("@specialty", doctor.specialty);
                cmd.Parameters.AddWithValue("@sex", doctor.sex);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                } else
                {
                    isSuccess = false;
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //CustomMessageBox cm = new CustomMessageBox("Failed to add doctor", form);
                //cm.Show();
            } finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllDoctors(string search)
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
                    sql = "SELECT doc_id AS 'Doctor ID', fname + ' ' + lname AS 'Doctor Name', sex AS 'Sex', specialty AS 'Specialty', dob AS 'Date of Birth' FROM Doctor WHERE fname + ' ' + lname LIKE '%" + search + "%'";
                } else
                {
                    sql = "SELECT doc_id AS 'Doctor ID', fname + ' ' + lname AS 'Doctor Name', sex AS 'Sex', specialty AS 'Specialty', dob AS 'Date of Birth' FROM Doctor";
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

        public DataTable GetDoctor(int doctorId)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM Doctor WHERE doc_id = @docId";


                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@docId", doctorId);

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

        public bool EditDoctor(Doctor doctor, int doctorId, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "Update Doctor Set fname = @firstName, lname = @lastName, dob = @dob, salary = @salary, username = @username, password = @password, specialty = @specialty, sex = @sex WHERE doc_id = @doctorId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", doctor.firstName);
                cmd.Parameters.AddWithValue("@lastName", doctor.lastName);
                cmd.Parameters.AddWithValue("@dob", doctor.dob);
                cmd.Parameters.AddWithValue("@salary", doctor.salary);
                cmd.Parameters.AddWithValue("@username", doctor.username);
                cmd.Parameters.AddWithValue("@password", doctor.password);
                cmd.Parameters.AddWithValue("@specialty", doctor.specialty);
                cmd.Parameters.AddWithValue("@sex", doctor.sex);
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                

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
