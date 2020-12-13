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
    public partial class IndividualPatient : Form
    {
        
        private int patientID;
        private int userID;

        Panel panelContainer;
        Patient.Patient patient = new Patient.Patient();

       
        public IndividualPatient(int usrID, int pID, Panel panel)
        {
            InitializeComponent();
            userID = usrID;
            patientID = pID;
            panelContainer = panel;
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


        private void PopulateDataGridView(int ID)
        {
            DataTable dt = patient.GetPatient(ID);
            DataRow row = dt.Rows[0];
            String firstName = row["fname"].ToString();
            String lastName = row["lname"].ToString();
            String dob = row["dob"].ToString();
            String address = row["address"].ToString();
            String bloodType = row["blood_type"].ToString();
            String allergies = row["allergies"].ToString();
            String contactOne = row["contact_one"].ToString();
            String contactTwo = row["contact_two"].ToString();
            String emergencyContact = row["emergency_contact"].ToString();
            String sex = row["sex"].ToString();
            String numberOfAppointments = row["No.of Appointments"].ToString();
            labelName.Text = firstName + " " + lastName;
            labelAddress.Text = address;
            labelDOB.Text = dob;
            labelAllergies.Text = allergies;
            labelBloodType.Text = bloodType;
            labelSex.Text = sex;
            labelContactOne.Text = contactOne;
            labelContactTwo.Text = contactTwo;
            labelEmergencyContact.Text = emergencyContact;
            labelNoAppointments.Text = numberOfAppointments;
        }

        private void IndividualPatient_Load(object sender, EventArgs e)
        {

            PopulateDataGridView(patientID);
        }

        private void buttonCreateAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateAppointment(userID, patientID));
        }

        private void buttonEditPatientProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditPatient(userID ,patientID, panelContainer));
        }

        private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
