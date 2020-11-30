using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Patient
{
    class Patient
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String bloodType { get; set; }
        public String allergies { get; set; }
        public String contactOne { get; set; }
        public String contactTwo { get; set; }
        public String emergencyContact { get; set; }
        public String dob { get; set; }
        public String sex { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewPatient(Patient patient, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Patient (patient_id, fname, lname, dob, address, blood_type, allergies, contact_one, contact_two, emergency_contact, sex) VALUES (NEXT VALUE FOR patient_seq ,@firstName, @lastName, @dob, @address, @bloodType, @allergies, @contactOne, @contactTwo, @emergencyContact, @sex)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", patient.firstName);
                cmd.Parameters.AddWithValue("@lastName", patient.lastName);
                cmd.Parameters.AddWithValue("@dob", patient.dob);
                cmd.Parameters.AddWithValue("@address", patient.address);
                cmd.Parameters.AddWithValue("@bloodType", patient.bloodType);
                cmd.Parameters.AddWithValue("@allergies", patient.allergies);
                cmd.Parameters.AddWithValue("@contactOne", patient.contactOne);
                cmd.Parameters.AddWithValue("@contactTwo", patient.contactTwo);
                cmd.Parameters.AddWithValue("@emergencyContact", patient.emergencyContact);
                cmd.Parameters.AddWithValue("@sex", patient.sex);

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

        public DataTable GetAllPatients(string search)
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
                    sql = @"SELECT patient_id AS 'Patient ID', fname + ' ' + lname AS Patient, sex AS Sex FROM Patient WHERE fname + ' ' + lname LIKE '%" + search + "'%";
                }
                else
                {
                    sql = "SELECT patient_id AS 'Patient ID', fname + ' ' + lname AS Patient, sex AS Sex FROM Patient";
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

        public DataTable GetPatient(int patientID)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM Patient WHERE patient_id = @patient_id";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@patient_id", patientID);

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
    }
}
