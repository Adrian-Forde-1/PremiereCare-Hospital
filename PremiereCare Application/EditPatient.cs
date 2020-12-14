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
    public partial class EditPatient : Form
    {
        int patientID;
        private int userID;
        string userRole;
        Panel panelContainer;
        Patient.Patient patient = new Patient.Patient();
        public EditPatient(int usrID, int pId, Panel panel, string usrRole)
        {
            panelContainer = panel;
            userID = usrID;
            patientID = pId;
            userRole = usrRole;
            InitializeComponent();
        }

        private void PopulateFields()
        {
            DataTable dt = patient.GetPatient(patientID);
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
            textBoxFname.Text = firstName;
            textBoxLname.Text = lastName;
            patientDOBPicker.Value = Convert.ToDateTime(dob);
            textBoxAddress.Text = address;
            textBoxBloodType.Text = bloodType;
            textBoxAllergies.Text = allergies;
            textBoxContactOne.Text = contactOne;
            textBoxContactTwo.Text = contactTwo;
            textBoxEmergencyContact.Text = emergencyContact;
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

        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, comboBoxSex.Location.Y + 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void removeErrors()
        {
            labelFNameErr.Visible = false;
            labelLNameErr.Visible = false;
            labelDOBErr.Visible = false;
            labelAllergiesErr.Visible = false;
            labelAddressErr.Visible = false;
            labelBloodTypeErr.Visible = false;
            labelContactOneErr.Visible = false;
        }

        private void ClearField()
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxAllergies.Text = "";
            textBoxBloodType.Text = "";
            textBoxContactOne.Text = "";
            textBoxContactTwo.Text = "";
            textBoxEmergencyContact.Text = "";
            comboBoxSex.Text = "Male";
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            PopulateFields();
            AlignItems();
            removeErrors();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void EditPatient_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (textBoxFname.Text == "")
            {
                labelFNameErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxLname.Text == "")
            {
                labelLNameErr.Visible = true;
                failedVerification = true;
            }

            if (patientDOBPicker.Value.Date.ToShortDateString() == "")
            {
                labelDOBErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxAddress.Text == "")
            {
                labelAddressErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxBloodType.Text == "")
            {
                labelBloodType.Visible = true;
                failedVerification = true;
            }

            if (textBoxAllergies.Text == "")
            {
                labelAllergiesErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxContactOne.Text == "")
            {
                labelContactOneErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                editPatient(textBoxFname.Text, textBoxLname.Text, textBoxAddress.Text, textBoxAllergies.Text, patientDOBPicker.Value.Date.ToShortDateString(), textBoxContactOne.Text, textBoxContactTwo.Text, textBoxEmergencyContact.Text, textBoxBloodType.Text, comboBoxSex.Text);
            }

        }

        private void GotoPatient()
        {
            OpenChildForm(new IndividualPatient(userID, patientID, panelContainer, userRole));
        }

        private void editPatient(String fName, String lName, String address, String allergies, String dob, String contactOne, String contactTwo, String emergencyContact, String bloodType, String sex)
        {
            Patient.Patient patient = new Patient.Patient();
            patient.firstName = fName;
            patient.lastName = lName;
            patient.address = address;
            patient.allergies = allergies;
            patient.dob = dob;
            patient.bloodType = bloodType;
            patient.contactOne = contactOne;
            patient.contactTwo = contactTwo;
            patient.emergencyContact = emergencyContact;
            patient.sex = sex;

            bool success = patient.EditPatient(patient, patientID, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Edited Patient", this, GotoPatient);
                cm.Show();
                ClearField();
                

            }
            //else
            //{
            //    CustomMessageBox cm = new CustomMessageBox("Failed to add new doctor", this);
            //    cm.Show();
            //}
        }
    }
}
