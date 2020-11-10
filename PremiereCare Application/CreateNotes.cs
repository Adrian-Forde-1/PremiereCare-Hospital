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
    public partial class CreateNotes : Form
    {
        public CreateNotes()
        {
            InitializeComponent();
        }

        private void removeErrors()
        {
            labelNoteErr.Visible = false;
        }

        private void ClearField()
        {
            dateTimePickerNote.Text = "";
            textBoxAppointment_ID.Text = "";
            textBoxDoc_ID.Text = "";
            txtBoxNote.Text = "";
            textBoxSearch.Text = "";
        }

        private void CreateNotes_Load(object sender, EventArgs e)
        {
            removeErrors();
        }

        private void buttnRecordNotes_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (dateTimePickerNote.Text == "")
            {
                labelNoteErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxAppointment_ID.Text == "")
            {
                labelNoteErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxDoc_ID.Text == "")
            {
                labelNoteErr.Visible = true;
                failedVerification = true;
            }

            if (txtBoxNote.Text == "")
            {
                labelNoteErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                RecordDoctorNotes(dateTimePickerNote.Text, textBoxAppointment_ID.Text, textBoxDoc_ID.Text,
                    txtBoxNote.Text);
            }

           
        }

        public void RecordDoctorNotes(String date, String appointment, String doctor, String note)
        {
              DoctorVisitNotes.DoctorVisitNotes doctorvisitnotes = new DoctorVisitNotes.DoctorVisitNotes();
              doctorvisitnotes.date = date;
              doctorvisitnotes.appointment = appointment;
              doctorvisitnotes.doctor = doctor;
              doctorvisitnotes.note = note;

              bool success = doctorvisitnotes.Insert( doctorvisitnotes, this);

              if (success == true)
              {
                  CustomMessageBox cm = new CustomMessageBox("Successfully Recorded Note", this);
                  cm.Show();
                  ClearField();
              }
                
           

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
