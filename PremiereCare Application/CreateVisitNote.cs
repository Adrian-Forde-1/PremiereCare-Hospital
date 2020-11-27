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
    //Class
    public partial class CreateVisitNote : Form
    {
        //variables
        private int docID;
        private int appointmentID;
        
        //Method to pass doctor and appointment ID
        public CreateVisitNote(int dID, int appID)
        {
            InitializeComponent();
            docID = dID;
            appointmentID = appID;
        }

        //Method to align items
        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        //Method to clear data entry points
        private void ClearField()
        {
            textBoxNote.Text = "";
            noteDatePicker.Value = DateTime.Now;
        }

        //Method to remove error labels
        private void removeErrors()
        {
            labelNoteErr.Visible = false;
            labelDateErr.Visible = false;
        }
               
        //Method to execute tasks on the loading of form
        private void CreateVisitNote_Load(object sender, EventArgs e)
        {
            removeErrors();
            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
            noteDatePicker.Format = DateTimePickerFormat.Custom;
            noteDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            noteDatePicker.MinDate = DateTime.Now;
        }

        //Method to execute AlignItems
        private void CreateVisitNote_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        //Method to execute actions on clicking of button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (textBoxNote.Text == "")
            {
                labelNoteErr.Visible = true;
                failedVerification = true;
            }

            if (noteDatePicker.Text == "")
            {
                labelDateErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                addNote(textBoxNote.Text, noteDatePicker.Value.Date.ToShortDateString(), docID.ToString(), appointmentID.ToString());

            }

        }

        private void addNote(string note, String date, string doctor, string appointment)
        {
            DoctorVisitNotes.DoctorVisitNotes doctorvisitnotes = new DoctorVisitNotes.DoctorVisitNotes();
            doctorvisitnotes.note = note;
            doctorvisitnotes.date = date;
            doctorvisitnotes.docID = doctor;
            doctorvisitnotes.appointmentID = appointment;
            

            
            bool success = doctorvisitnotes.Insert(doctorvisitnotes, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Recorded Note", this);
                removeErrors();
                ClearField();
                cm.Show();
            }

        }
    }
}
