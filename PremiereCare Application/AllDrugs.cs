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
    }
}
