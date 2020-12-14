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
               
        public bool PrescribeMedication(PrescribeMed prescription, Form form)
        {
            bool isSuccess = false;
            //Step 1: Create database connection string query,
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string qry = @"INSERT INTO [PremiereCareHospital].[dbo].Prescription ( prescription_id, doc_id, appointment_id, patient_id, dosage) 
                            VALUES(NEXT VALUE FOR prescription_seq, @doctor, @appointment, @patient, @dosage)";

                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@doctor", prescription.doctor_id);
                cmd.Parameters.AddWithValue("@appointment", prescription.appointment_id);
                cmd.Parameters.AddWithValue("@patient", prescription.patient_id);
                cmd.Parameters.AddWithValue("@dosage", prescription.dosage);

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
                                       
           foreach (int drug in IDs)
           {
                try
                {
                    string query = @"INSERT INTO [PremiereCareHospital].[dbo].Prescribed_Drugs (prescription_id, drug_id) 
                                 VALUES( @prescriptionID, @drugID)";

                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                    cmd.Parameters.AddWithValue("@drugID", drug);


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
                }
                finally
                {
                    conn.Close(); 
                }

            }  
            return isSuccess;
        }

        public DataTable getPrescriptionIDFromAppointment(int appointmentID)
        {
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT prescription_id FROM [PremiereCareHospital].[dbo].Prescription 
                                WHERE appointment_id=@appointmentID";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@appointmentID", appointmentID);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtadapter.Fill(dt);

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

        public DataTable GetMostRecentPrescriptionID()
        {
            string val = null;
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT TOP 1 prescription_id FROM [PremiereCareHospital].[dbo].[Prescription]
                                ORDER BY prescription_id DESC";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtadapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetAllPrescriptionsForAppointment(int appointmentID)
        {
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT 
                                p.prescription_id AS 'Prescription ID',
                                d.fname + d.lname AS 'Doctor',
                                pat.fname + pat.lname AS 'Patient',
                                p.dosage AS 'Dosage'
                                FROM [PremiereCareHospital].[dbo].Prescription p
                                JOIN [PremiereCareHospital].[dbo].Doctor d
                                    ON p.doc_id = d.doc_id
                                JOIN [PremiereCareHospital].[dbo].Patient pat
                                    ON p.patient_id = pat.patient_id
                                WHERE appointment_id=@appointmentID";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@appointmentID", appointmentID);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtadapter.Fill(dt);

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

        public DataTable GetPrescription(int prescriptionId)
        {
            //Step 1: Create database connection string query,
            conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                //Step 2: Writing SQL Query
                string qry = @"SELECT 
                                p.prescription_id AS 'Prescription ID',
                                d.fname + d.lname AS 'Doctor',
                                pat.fname + pat.lname AS 'Patient',
                                p.dosage AS 'Dosage'
                                FROM [PremiereCareHospital].[dbo].Prescription p
                                JOIN [PremiereCareHospital].[dbo].Doctor d
                                    ON p.doc_id = d.doc_id
                                JOIN [PremiereCareHospital].[dbo].Patient pat
                                    ON p.patient_id = pat.patient_id
                                WHERE prescription_id = @prescriptionId";

                //Creating cmd using sql and conn
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@prescriptionId", prescriptionId);

                //Creating SQL DataAdapter using cmd
                dtadapter = new SqlDataAdapter(cmd);
                conn.Open();

                dtadapter.Fill(dt);

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

