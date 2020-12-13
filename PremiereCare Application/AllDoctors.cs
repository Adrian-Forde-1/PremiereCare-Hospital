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
   
    public partial class AllDoctors : Form
    {
        User.Doctor doctor = new User.Doctor();
        Panel panelContainer;
        public AllDoctors(Panel panel)
        {
            panelContainer = panel;
            InitializeComponent();
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

        private void PopulateDataGridView()
        {
            DataTable dt = doctor.GetAllDoctors(textBoxSearch.Text.ToString());
            dgvAllDoctors.DataSource = dt;
        }

        private void StyleDataGridView()
        {
            //dgvAllDoctors.RowTemplate.DefaultHeaderCellType = typeof(CustomHeaderCell);
            //dgvAllDoctors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dgvAllDoctors.RowHeadersDefaultCellStyle.Padding = new Padding(2);
            dgvAllDoctors.BorderStyle = BorderStyle.None;
            dgvAllDoctors.RowsDefaultCellStyle.BackColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dgvAllDoctors.DefaultCellStyle.SelectionBackColor = Color.FromArgb(53, 64, 82);
            //dgvAllDoctors.DefaultCellStyle.SelectionForeColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.BackgroundColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAllDoctors.EnableHeadersVisualStyles = false;
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.Font = new Font("Calib", 10);
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(227, 224, 217);
            dgvAllDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(53, 64, 82);
        }

        private void AllDoctors_Load(object sender, EventArgs e)
        {
            //StyleDataGridView();
            PopulateDataGridView();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void dgvAllDoctors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int doctorId = Convert.ToInt32(dgvAllDoctors.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualDoctor(doctorId, panelContainer));
        }
    }
}
