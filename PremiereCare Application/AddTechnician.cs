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

        private void RemoveErrors()
        {
            labelFNameErr.Visible = false;
            labelLNameErr.Visible = false;
            labelUsernameErr.Visible = false;
            labelPasswordErr.Visible = false;
            labelSalaryErr.Visible = false;
            labelSexErr.Visible = false;
        }

        private void ClearField()
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            techDOB.Value = DateTime.Now;
            textBoxSalary.Text = "";
        }

        private void AddTechnician_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            RemoveErrors();
            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
            comboBoxSex.SelectedText = "Male";
        }

        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            RemoveErrors();

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

            if (Convert.ToInt32(comboBoxSex.SelectedIndex) == -1)
            {
                labelSexErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                addTechnician(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, techDOB.Value.Date.ToShortDateString(), textBoxSalary.Text, comboBoxSex.Text);
            }
        }
     
        private void addTechnician(String fName, String lName, String username, String password, String dob, String salary, String sex)
        {
            User.Technician technician = new User.Technician();
            technician.firstName = fName;
            technician.lastName = lName;
            technician.username = username;
            technician.password = password;
            technician.dob = dob;
            technician.salary = salary;
            technician.sex = sex;

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

       
        private void buttonAdd_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

    }
}
