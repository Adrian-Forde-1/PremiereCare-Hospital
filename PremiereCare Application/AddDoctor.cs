using PremiereCare_Application.User;
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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void removeErrors()
        {
            labelFNameErr.Visible = false;
            labelLNameErr.Visible = false;
            labelUsernameErr.Visible = false;
            labelPasswordErr.Visible = false;
            labelSalaryErr.Visible = false;
            labelSpecialtyErr.Visible = false;
        }

        private void ClearField()
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxDOB.Text = "";
            textBoxSalary.Text = "";
            textBoxSpecialty.Text = "";
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            removeErrors();
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
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

            if (textBoxUsername.Text == "")
            {
                labelUsernameErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxPassword.Text == "")
            {
                labelPasswordErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxSalary.Text == "")
            {
                labelSalaryErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxSpecialty.Text == "")
            {
                labelSpecialtyErr.Visible = true;
                failedVerification = true;
            }

            if(!failedVerification)
            {
                addDoctor(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, textBoxDOB.Text, textBoxSalary.Text, textBoxSpecialty.Text);
            } 


        }

        private void addDoctor(String fName, String lName, String username, String password, String dob, String salary, String specialty)
        {
            User.Doctor doctor = new User.Doctor();
            doctor.firstName = fName;
            doctor.lastName = lName;
            doctor.username = username;
            doctor.password = password;
            doctor.dob = dob;
            doctor.salary = salary;
            doctor.specialty = specialty;

            bool success = doctor.AddNewDoctor(doctor, this);

            if(success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Doctor", this);
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
