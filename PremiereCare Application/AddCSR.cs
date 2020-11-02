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
    public partial class AddCSR : Form
    {
        public AddCSR()
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

        private void AddCSR_Load(object sender, EventArgs e)
        {
            removeErrors();
        }

        private void buttonAddCSR_Click(object sender, EventArgs e)
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
                addCSR(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, textBoxDOB.Text, textBoxSalary.Text, comboBoxSex.Text);
            }
        }

        private void addCSR(String fName, String lName, String username, String password, String dob, String salary, String sex)
        {
            User.CSR csr = new User.CSR();
            csr.firstName = fName;
            csr.lastName = lName;
            csr.username = username;
            csr.password = password;
            csr.dob = dob;
            csr.salary = salary;
            csr.sex = sex;

            bool success = csr.AddNewCSR(csr, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added CSR", this);
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
