﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application.Drug
{
    class Drug
    {

        public string name { get; set; }
        public string cost { get; set; }

        //Private Attributes
        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        public bool AddNewDrug(Drug drug, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "INSERT INTO Drug (drug_id, drug, cost) VALUES (NEXT VALUE FOR drug_seq ,@name, @cost)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", drug.name);
                cmd.Parameters.AddWithValue("@cost", drug.cost);

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
                //CustomMessageBox cm = new CustomMessageBox("Failed to add drug", form);
                //cm.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable GetAllDrugs()
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT drug_id AS 'ID', drug AS 'Drug', cost AS 'Cost' FROM Drug ORDER BY Drug";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
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
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetDrugsFromPrescriptionID(int prescriptionID)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = @"SELECT
                                d.drug AS 'Drug',
                                d.cost AS 'Cost'
                                FROM[PremiereCareHospital].[dbo].[Prescribed_Drugs] pd
                                JOIN[PremiereCareHospital].[dbo].[Drug] d
                                   ON pd.drug_id = d.drug_id
                                WHERE pd.prescription_id = @prescriptionID";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("prescriptionID", prescriptionID);

                //Creating SQL DataAdapter using cmd
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
                //Close Connection
                conn.Close();
            }
            return dt;
        }

        public DataTable GetDrug(int drugId)
        {
            //Step 1: Create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM Drug WHERE drug_id = @drugId";


                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@drugId", drugId);

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

        public bool EditDrug(Drug drug, int drugId, Form form)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string query = "Update Drug Set drug = @drug, cost = @cost WHERE drug_id = @drugId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@drug", drug.name);
                cmd.Parameters.AddWithValue("@cost", drug.cost);
                cmd.Parameters.AddWithValue("@drugId", drugId);


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

    }
}

