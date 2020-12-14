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
    public partial class ViewVisitNotes : Form
    {
        int doctorId;
        Panel panelContainer;
        DoctorVisitNotes.DoctorVisitNotes visitNotes = new DoctorVisitNotes.DoctorVisitNotes();
        public ViewVisitNotes(int dId, Panel panel)
        {
            doctorId = dId;
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

        private void PopulateDataTable()
        {
            DataTable dt = visitNotes.GetVisitNotes(doctorId, textBoxSearch.Text.ToString());
            dgvAllVisitNotes.DataSource = dt;
        }

        private void ViewNotes_Load(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDataTable();
        }

        private void dgvAllVisitNotes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int visitNoteId = Convert.ToInt32(dgvAllVisitNotes.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualVisitNote(visitNoteId, panelContainer));
        }
    }
}
