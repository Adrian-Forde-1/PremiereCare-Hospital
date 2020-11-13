using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}
