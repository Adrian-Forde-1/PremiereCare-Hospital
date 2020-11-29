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

        SqlCommand cmd;
        SqlConnection conn;
        SqlDataAdapter dtadapter;
        SqlDataReader dtread;
        //DataTable dt_;
        //DataSet dts_;
               
        public bool PrescribeMedication(PrescribeMed prescription, Form form)//string query,
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                string qry = @"INSERT INTO  [PremiereCareHospital].[dbo].Prescription ( prescription_id, doc_id, appointment_id, patient_id, dosage) 
                            VALUES(NEXT VALUE FOR prescription_seq, @doctor, @appointment, @patient, @dosage)";

                cmd = new SqlCommand(qry, conn);//allquerys
                cmd.Parameters.AddWithValue("@doctor", premed.doctor_id);
                cmd.Parameters.AddWithValue("@appointment", premed.appointment_id);
                cmd.Parameters.AddWithValue("@patient", premed.patient_id);
                cmd_ = new SqlCommand(qry, conn_);//allquerys
                cmd_.Parameters.AddWithValue("@doctor", prescription.doctor_id);
                cmd_.Parameters.AddWithValue("@appointment", prescription.appointment_id);
                cmd_.Parameters.AddWithValue("@patient", prescription.patient_id);
                cmd_.Parameters.AddWithValue("@dosage", prescription.dosage);

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
               // CustomMessageBox cm = new CustomMessageBox("Failed to add Prescription", form);
               // cm.Show();
            }
            finally
            {
                conn.Close(); ;
            }
            return isSuccess;
        }

        public bool PrescribedDrugs(int prescriptionID, List<int> IDs, Form form)//string query,
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            
            try
            {
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

                    cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@prescriptionID", premed.prescription_id);
                    cmd.Parameters.AddWithValue("@drugID", premed.drug_id);
                    cmd.Parameters.AddWithValue("@dosage", premed.dosage);
                    
                                        
                }
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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add Prescribed Drugs", form);
                //cm.Show();
            }
            finally 
            {
                conn.Close(); ; 
            }
            return isSuccess;
        }
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

        public void getSingleValueArrayIndex( out List<string> columndata, int index)
        {
            List<string> data = new List<string>();
            
            //Step 1: Create database connection string query,
             conn = new SqlConnection(myconnstring);
            
            try
            {
                //Step 2: Writing SQL Query
                string qry = "SELECT drug  FROM [PremiereCareHospital].[dbo].Drug";
                
                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);
                
                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
               
                conn.Open();
                dtread = cmd.ExecuteReader();
                
                while (dtread.Read())
                {
                    data.Add(dtread[index].ToString());
                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                data.Clear();
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            columndata = data;
            //return ret;
        }
            }  
            return isSuccess;
        }

        public void getSingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string  val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            
            try
            {
                //Step 2: Writing SQL Query
                string qry  = query;

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtread = cmd.ExecuteReader();

                while (dtread.Read())
                {
                    val = dtread[index].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            columndata = val;
            //return ret;

        }

        public string getPatient_ID(string appointmentID)
        {

        public string getPrescription_ID(string appointmentID)
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Writing SQL Query
                string qry =  @"SELECT prescription_id FROM [PremiereCareHospital].[dbo].Prescription 
                                WHERE appointment_id Like '" + appointmentID + "' ";
                
                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtread = cmd.ExecuteReader();
                val = dtread.ToString();

                dtread_ = cmd_.ExecuteReader();
                val = dtread_.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() ); 
            }
            finally
            {
                conn.Close();
            }
            
            return val;
        }

        public DataTable GetMostRecentPrescriptionID()
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);


            // Step 1: Create database connection string query,
            conn_ = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT TOP 1 prescription_id FROM[PremiereCareHospital].[dbo].[Prescription]
                                ORDER BY prescription_id DESC";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtread = cmd.ExecuteReader();
                val = dtread.ToString();
                

                dtadapter_.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                //Close Connection
                conn_.Close();
            }
            return dt;
        }



    }    
}
