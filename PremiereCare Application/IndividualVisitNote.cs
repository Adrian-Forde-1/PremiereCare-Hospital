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
    public partial class IndividualVisitNote : Form
    {
        int visitNoteId;
        Panel panelContainer;
        DoctorVisitNotes.DoctorVisitNotes visitNote = new DoctorVisitNotes.DoctorVisitNotes();
        public IndividualVisitNote(int vNId, Panel panel)
        {
            visitNoteId = vNId;
            panelContainer = panel;
            InitializeComponent();
        }

        private void PopuldateFields()
        {
            DataTable dt = visitNote.GetVisitNote(visitNoteId);
            DataRow row = dt.Rows[0];
            labelVisitNoteID.Text = row["Note Id"].ToString();
            labelAppointmentId.Text = row["Appointment Id"].ToString();
            labeldate.Text = row["Date"].ToString();
            labelPatientName.Text = row["Patient Name"].ToString();
            labelNote.Text = row["Note"].ToString();
        }

        private void IndividualVisitNote_Load(object sender, EventArgs e)
        {
            PopuldateFields();
        }
    }
}
