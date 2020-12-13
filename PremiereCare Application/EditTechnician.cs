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
    public partial class EditTechnician : Form
    {
        int technicianId;
        Panel panelContainer;
        User.Technician technician = new User.Technician();

        public EditTechnician(int techId, Panel panel)
        {
            technicianId = techId;
            panelContainer = panel;
            InitializeComponent();
        }

        private void PopulateFields()
        {
            DataTable dt = technician.GetTechnician(technicianId);
            DataRow row = dt.Rows[0];
            String firstName = row["fname"].ToString();
            String lastName = row["lname"].ToString();
            String dob = row["dob"].ToString();
            String username = row["username"].ToString();
            String password = row["password"].ToString();
            String salary = row["salary"].ToString();
            String sex = row["sex"].ToString();
            textBoxFname.Text = firstName;
            textBoxLname.Text = lastName;
            techDOB.Value = Convert.ToDateTime(dob);
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            textBoxSalary.Text = salary;
            comboBoxSex.Text = sex;
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
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void EditTechnician_Load(object sender, EventArgs e)
        {
            RemoveErrors();
            AlignItems();
            PopulateFields();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
            comboBoxSex.SelectedText = "Male";
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
                editTechnician(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, techDOB.Value.Date.ToShortDateString(), textBoxSalary.Text, comboBoxSex.Text);
            }
        }

        private void editTechnician(String fName, String lName, String username, String password, String dob, String salary, String sex)
        {
            technician.firstName = fName;
            technician.lastName = lName;
            technician.username = username;
            technician.password = password;
            technician.dob = dob;
            technician.salary = salary;
            technician.sex = sex;

            bool success = technician.EditTechnician(technician, technicianId, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Edited Technician", this);
                cm.Show();
                ClearField();
                OpenChildForm(new IndividualTechnician(technicianId, panelContainer));
            }
            //else
            //{
            //    CustomMessageBox cm = new CustomMessageBox("Failed to add new doctor", this);
            //    cm.Show();
            //}
        }


        private void EditTechnician_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }
    }
}
