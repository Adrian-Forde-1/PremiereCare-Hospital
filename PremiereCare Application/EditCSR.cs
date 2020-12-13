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
    public partial class EditCSR : Form
    {
        User.CSR csr = new User.CSR();
        int csrId;
        Panel panelContainer;
        public EditCSR(int csrID, Panel panel)
        {
            csrId = csrID;
            panelContainer = panel;
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
            csrDOB.Value = DateTime.Now;
            textBoxSalary.Text = "";
        }

        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void PopulateFields()
        {
            DataTable dt = csr.GetCSR(csrId);
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
            csrDOB.Value = Convert.ToDateTime(dob);
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            textBoxSalary.Text = salary;
            comboBoxSex.Text = sex;
        }

        private void EditCSR_Load(object sender, EventArgs e)
        {
            removeErrors();
            PopulateFields();
            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
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

        private void EditCSR_Resize(object sender, EventArgs e)
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

            //if (Convert.ToInt32(comboBoxSex.SelectedIndex) == -1)
            //{
            //    labelSexErr.Visible = true;
            //    failedVerification = true;
            //}

            if (!failedVerification)
            {
                editCSR(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, csrDOB.Value.Date.ToShortDateString(), textBoxSalary.Text, comboBoxSex.Text);
            }
        }

        private void editCSR(String fName, String lName, String username, String password, String dob, String salary, String sex)
        {
            User.CSR csr = new User.CSR();
            csr.firstName = fName;
            csr.lastName = lName;
            csr.username = username;
            csr.password = password;
            csr.dob = dob;
            csr.salary = salary;
            csr.sex = sex;

            bool success = csr.EditCSR(csr, csrId, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Edited CSR", this);
                cm.Show();
                ClearField();
                OpenChildForm(new IndividualCSR(csrId, panelContainer));
            }
            //else
            //{
            //    CustomMessageBox cm = new CustomMessageBox("Failed to add new doctor", this);
            //    cm.Show();
            //}
        }
    }
}
