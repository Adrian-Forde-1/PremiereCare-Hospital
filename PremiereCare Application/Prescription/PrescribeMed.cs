using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Prescription
{
    class PrescribeMed
    {
        public int appointment_id { get; set; }
        public string dosage { get; set; }
        public int doctor_id { get; set; }
        public int patient_id { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        SqlCommand cmd_;
        SqlConnection conn_;
        SqlDataAdapter dtadapter_;
        SqlDataReader dtread_;
        //DataTable dt_;
        //DataSet dts_;
               
        public bool PrescribeMedication(PrescribeMed prescription, Form form)//string query,
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                string qry = @"INSERT INTO  [PremiereCareHospital].[dbo].Prescription ( prescription_id, doc_id, appointment_id, patient_id, dosage) 
                            VALUES(NEXT VALUE FOR prescription_seq, @doctor, @appointment, @patient, @dosage)";

                cmd_ = new SqlCommand(qry, conn_);//allquerys
                cmd_.Parameters.AddWithValue("@doctor", prescription.doctor_id);
                cmd_.Parameters.AddWithValue("@appointment", prescription.appointment_id);
                cmd_.Parameters.AddWithValue("@patient", prescription.patient_id);
                cmd_.Parameters.AddWithValue("@dosage", prescription.dosage);

                conn_.Open();
                int rows = cmd_.ExecuteNonQuery();

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
               // CustomMessageBox cm = new CustomMessageBox("Failed to add Prescription", form);
               // cm.Show();
            }
            finally
            {
                conn_.Close(); ;
            }
            return isSuccess;
        }

        public bool PrescribedDrugs(int prescriptionID, List<int> IDs, Form form)//string query,
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            foreach (int item in IDs)
            {
                try
                {
                    string query = @"INSERT INTO [PremiereCareHospital].[dbo].Prescribed_Drugs (prescription_id, drug_id) 
                                 VALUES( @prescriptionID, @drugID)";

                    cmd_ = new SqlCommand(query, conn_);
                    cmd_.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                    cmd_.Parameters.AddWithValue("@drugID", item);

                    conn_.Open();
                    int rows = cmd_.ExecuteNonQuery();
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
                    //CustomMessageBox cm = new CustomMessageBox("Failed to add Prescribed Drugs", form);
                    //cm.Show();
                }
                finally
                {
                    conn_.Close(); ;
                }

            }  
            return isSuccess;
        }


        public string getPrescription_ID(string appointmentID)
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry =  @"SELECT prescription_id FROM [PremiereCareHospital].[dbo].Prescription 
                                WHERE appointment_id Like '" + appointmentID + "' ";
                
                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);
                conn_.Open();

                dtread_ = cmd_.ExecuteReader();
                val = dtread_.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() ); 
            }
            finally
            {
                conn_.Close();
            }
            
            return val;
        }

        public DataTable GetMostRecentPrescriptionID()
        {

            // Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT TOP 1 prescription_id FROM[PremiereCareHospital].[dbo].[Prescription]
                                ORDER BY prescription_id DESC";

                //Creating cmd using sql and conn
                cmd_ = new SqlCommand(qry, conn_);

                //Creating SQL DataAdapter using cmd
                dtadapter_ = new SqlDataAdapter(cmd_);
                conn_.Open();


                dtadapter_.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn_.Close();
            }
            return dt;
        }



    }    
}
