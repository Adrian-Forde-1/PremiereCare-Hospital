﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
    public partial class AllCSR : Form
    {

        User.CSR csr = new User.CSR();
        Panel panelContainer;
        public AllCSR(Panel panel)
        {
            panelContainer = panel;
            InitializeComponent();
        }

        private void PopulateDataTable()
        {
            DataTable dt = csr.GetAllCSR(textBoxSearch.Text.ToString());
            dgvAllCSR.DataSource = dt;

        }

        private void OpenChildForm(Form childForm)
        {
            this.Close();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AllCSR_Load(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void dgvAllCSR_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int csrId = Convert.ToInt32(dgvAllCSR.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualCSR(csrId, panelContainer));
        }
    }
}
