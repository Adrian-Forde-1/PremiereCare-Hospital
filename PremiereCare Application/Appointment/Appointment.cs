using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Appointment
{
    class Appointment
    {
        public int docId { get; set; }
        public int csrId { get; set; }
        public int patientId { get; set; }
        public String appointmentDate { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool CreateAppointment(Appointment appointment, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Appointment (appointment_id, doc_id, csr_id, patient_id, appointment_date, cost) VALUES (NEXT VALUE FOR appointment_seq ,@docId, @csrId, @patientId, @appointmentDate, @cost)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@docID", appointment.docId);
                cmd.Parameters.AddWithValue("@csrId", appointment.csrId);
                cmd.Parameters.AddWithValue("@patientId", appointment.patientId);
                cmd.Parameters.AddWithValue("@appointmentDate", appointment.appointmentDate);
                cmd.Parameters.AddWithValue("@cost", 0);

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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add appointment", form);
                //cm.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllAppointments(String userRole, int userID)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "";
                if (userRole == "CSR") sql = @"SELECT 
                                              a.appointment_id, 
                                              a.appointment_date, 
                                              d.fname + ' ' + d.lname AS 'Doctor Name', 
                                              p.fname + ' ' + p.lname AS 'Patient Name'
                                              FROM[PremiereCareHospital].[dbo].Appointment a
                                              JOIN[PremiereCareHospital].[dbo].Doctor d
                                                  ON a.doc_id = d.doc_id
                                              JOIN[PremiereCareHospital].[dbo].Patient p
                                                  ON a.patient_id = p.patient_id
                                              ORDER BY a.appointment_date; ";

                else if (userRole == "Doctor") sql = @"SELECT 
                                              a.appointment_id, 
                                              a.appointment_date, 
                                              d.fname + ' ' + d.lname AS 'Doctor Name', 
                                              p.fname + ' ' + p.lname AS 'Patient Name'
                                              FROM[PremiereCareHospital].[dbo].Appointment a
                                              JOIN[PremiereCareHospital].[dbo].Doctor d
                                                  ON a.doc_id = d.doc_id
                                              JOIN[PremiereCareHospital].[dbo].Patient p
                                                  ON a.patient_id = p.patient_id
                                              WHERE d.doc_id = @userID
                                              ORDER BY a.appointment_date; ";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                if(userRole == "Doctor")
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                }

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
