using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.DoctorVisitNotes
{
    class DoctorVisitNotes
    {

        public string date { get; set; }
        public string appointment { get; set; }
        public string doctor { get; set; }
        public string note { get; set; }
       

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool Insert(DoctorVisitNotes doctorvisitnotes , Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Doctor_Visit_Notes (note_id, doc_id, appointment_id, visit_note_date, note) VALUES (NEXT VALUE FOR visit_notes_seq ,@doctor, @appointment, @date, @note)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@date", doctorvisitnotes.date);
                cmd.Parameters.AddWithValue("@appointment", doctorvisitnotes.appointment);
                cmd.Parameters.AddWithValue("@doctor", doctorvisitnotes.doctor);
                cmd.Parameters.AddWithValue("@note", doctorvisitnotes.note);
                

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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add Note to database", form);
                //cm.Show();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}

