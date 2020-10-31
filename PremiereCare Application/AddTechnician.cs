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
    public partial class AddTechnician : Form
    {
        public AddTechnician()
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
        }

        private void ClearField()
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxDOB.Text = "";
            textBoxSalary.Text = "";
        }

        private void AddTechnician_Load(object sender, EventArgs e)
        {
            removeErrors();
        }

        private void buttonAddTech_Click(object sender, EventArgs e)
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

            if (!failedVerification)
            {
                addTechnician(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, textBoxDOB.Text, textBoxSalary.Text);
            }
        }

        private void addTechnician(String fName, String lName, String username, String password, String dob, String salary)
        {
            User.Technician technician = new User.Technician();
            technician.firstName = fName;
            technician.lastName = lName;
            technician.username = username;
            technician.password = password;
            technician.dob = dob;
            technician.salary = salary;

            bool success = technician.AddNewTechnician(technician, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Technician", this);
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
