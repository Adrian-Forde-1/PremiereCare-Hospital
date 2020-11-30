using System;
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
        public AllCSR()
        {
            InitializeComponent();
        }

        private void PopulateDataTable()
        {
            DataTable dt = csr.GetAllCSR(textBoxSearch.Text.ToString());
            dgvAllCSR.DataSource = dt;

        }

        private void AllCSR_Load(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataTable();
        }
    }
}
