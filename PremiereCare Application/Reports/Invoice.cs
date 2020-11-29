using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Reports
{
    class Invoice
    {
        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        //public bool GenerateInvoice(int appointmentID, Form form)
        //{
        //    bool isSuccess = false;

        //    SqlConnection conn = new SqlConnection(myconnstring);

        //    try
        //    {
        //        string query = @"INSERT INTO Invoice (invoice_id, appointment_id) 
        //                        VALUES (NEXT VALUE FOR invoice_seq, @appointment_id)";

        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        cmd.Parameters.AddWithValue("@a", appointment.docId);
        //        cmd.Parameters.AddWithValue("@cost", 0);

        //        conn.Open();
        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //        //CustomMessageBox cm = new CustomMessageBox("Failed to add appointment", form);
        //        //cm.Show();
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return isSuccess;
        //}

        public DataTable GetInvoiceData(int appointmentID)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT
                                a.appointment_id AS 'Appointment ID', 
                                p.fname AS 'Patient First Name',
                                p.lname AS 'Patient Last Name',
                                p.address AS 'Patient Address',
                                p.contact_one AS 'Patient Contact',
                                d.fname AS 'Doctor First Name',
                                d.lname AS 'Doctor Last Name',
                                d.specialty AS 'Doctor Specialty'
                                FROM [PremiereCareHospital].[dbo].[Appointment] a
                                JOIN [PremiereCareHospital].[dbo].[Doctor] d
                                	ON a.doc_id = d.doc_id
                                JOIN [PremiereCareHospital].[dbo].[Patient] p
                                	ON a.patient_id = p.patient_id 
                                WHERE appointment_id = @appointmentID;
                                ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@appointmentID", appointmentID);

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
