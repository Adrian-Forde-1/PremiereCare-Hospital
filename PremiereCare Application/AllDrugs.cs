﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
    public partial class AllDrugs : Form
    {

        Drug.Drug drug = new Drug.Drug();
        public AllDrugs()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            DataTable dt = drug.GetAllDrugs();
            dgvDrugs.DataSource = dt;
        }

        private void AllDrugs_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvDrugs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //Get the value from textbox
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            string qry = @"SELECT  drug_id AS 'ID', drug AS 'Drug', cost AS 'Cost' FROM Drug WHERE 
                                                                                    (drug_id LIKE '%" + keyword +
                                                                                    "%' OR drug LIKE '%" + keyword +
                                                                                    "%' OR cost LIKE '%" + keyword + "%')";

            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(qry, conn);

            //Creating SQL DataAdapter using cmd
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            conn.Open();
            dtadapter.Fill(dt);
            conn.Close();
            dgvDrugs.DataSource = dt;
        }
    }
}
