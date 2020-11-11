using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremiereCare_Application.Patient;

namespace PremiereCare_Application
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
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


        private void AddPatient_Load(object sender, EventArgs e)
        {
            AlignItems();
            removeErrors();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void AddPatient_Resize(object sender, EventArgs e)
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
                addPatient(textBoxFname.Text, textBoxLname.Text, textBoxAddress.Text, textBoxAllergies.Text, patientDOBPicker.Value.Date.ToShortDateString(), textBoxContactOne.Text, textBoxContactTwo.Text, textBoxEmergencyContact.Text, textBoxBloodType.Text, comboBoxSex.Text);
            }
        }

        private void addPatient(String fName, String lName, String address, String allergies, String dob, String contactOne, String contactTwo, String emergencyContact, String bloodType, String sex)
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

            bool success = patient.AddNewPatient(patient, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Patient", this);
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
