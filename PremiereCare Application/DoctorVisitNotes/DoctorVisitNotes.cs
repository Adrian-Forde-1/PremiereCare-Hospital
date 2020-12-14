using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public string appointmentID { get; set; }
        public string docID { get; set; }
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
                cmd.Parameters.AddWithValue("@appointment", doctorvisitnotes.appointmentID);
                cmd.Parameters.AddWithValue("@doctor", doctorvisitnotes.docID);
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

        public DataTable GetVisitNotes(int doctorId, string search)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql;

                if(search == "")
                {
                    sql = @"SELECT 
                                dvn.note_id AS 'Note Id',
                                dvn.appointment_id AS 'Appointment Id', 
                                p.fname + ' ' + p.lname AS 'Patient Name',
                                visit_note_date as 'Date', 
                                note AS Note
                                FROM PremiereCareHospital.dbo.Doctor_Visit_Notes dvn
                                JOIN PremiereCareHospital.dbo.Appointment a
                                    ON dvn.appointment_id = a.appointment_id
                                JOIN PremiereCareHospital.dbo.Patient p
                                    ON a.patient_id = p.patient_id
                                WHERE dvn.doc_id = @doctorId
                                ORDER BY visit_note_date DESC";
                } else
                {
                    sql = @"SELECT 
                                dvn.note_id AS 'Note Id',
                                dvn.appointment_id AS 'Appointment Id', 
                                p.fname + ' ' + p.lname AS 'Patient Name',
                                visit_note_date as 'Date', 
                                note AS Note
                                FROM PremiereCareHospital.dbo.Doctor_Visit_Notes dvn
                                JOIN PremiereCareHospital.dbo.Appointment a
                                    ON dvn.appointment_id = a.appointment_id
                                JOIN PremiereCareHospital.dbo.Patient p
                                    ON a.patient_id = p.patient_id
                                WHERE dvn.doc_id = @doctorId AND p.fname + ' ' + p.lname LIKE '%" + search + "%' OR  visit_note_date LIKE '%" + search + "%' OR dvn.appointment_id LIKE '%" + search + @"%'
                                ORDER BY visit_note_date DESC";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@doctorId", doctorId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable GetVisitNote(int visitNoteId)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                                dvn.note_id AS 'Note Id',
                                dvn.appointment_id AS 'Appointment Id', 
                                p.fname + ' ' + p.lname AS 'Patient Name',
                                visit_note_date as 'Date', 
                                note AS Note
                                FROM PremiereCareHospital.dbo.Doctor_Visit_Notes dvn
                                JOIN PremiereCareHospital.dbo.Appointment a
                                    ON dvn.appointment_id = a.appointment_id
                                JOIN PremiereCareHospital.dbo.Patient p
                                    ON a.patient_id = p.patient_id
                                WHERE dvn.note_id = @noteId
                                ORDER BY visit_note_date DESC";



                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@noteId", visitNoteId);

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
                conn.Close();
            }

            return dt;
        }
    }
}

