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
    public partial class AllTechnicians : Form
    {
        User.Technician technician = new User.Technician();

        public AllTechnicians()
        {
            InitializeComponent();
        }

        private void PopulateDataTable()
        {
            DataTable dt = technician.GetAllTechnicians(textBoxSearch.Text.ToString());
            dgvAllTechnicians.DataSource = dt;

        }

        private void AllTechnicians_Load(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataTable();
        }
    }
}
