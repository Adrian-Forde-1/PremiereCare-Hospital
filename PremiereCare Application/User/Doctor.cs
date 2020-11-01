﻿using System;
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
                CustomMessageBox cm = new CustomMessageBox(ex.ToString(), form);
                cm.Show();
            } finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllDoctors()
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT doc_id, fname, lname, sex, specialty FROM Doctor";

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

    }
}
