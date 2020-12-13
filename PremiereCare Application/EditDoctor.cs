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
    public partial class EditDoctor : Form
    {
        int doctorId;
        Panel panelContainer;
        User.Doctor doctor = new User.Doctor();

        public EditDoctor(int docId, Panel panel)
        {
            doctorId = docId;
            panelContainer = panel;
            InitializeComponent();
        }

        private void PopulateFields()
        {
            DataTable dt = doctor.GetDoctor(doctorId);
            DataRow row = dt.Rows[0];
            String firstName = row["fname"].ToString();
            String lastName = row["lname"].ToString();
            String dob = row["dob"].ToString();
            String username = row["username"].ToString();
            String password = row["password"].ToString();
            String salary = row["salary"].ToString();
            String specialty = row["specialty"].ToString();
            String sex = row["sex"].ToString();
            textBoxFname.Text = firstName;
            textBoxLname.Text = lastName;
            doctorDOBPicker.Value = Convert.ToDateTime(dob);
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            textBoxSalary.Text = salary;
            textBoxSpecialty.Text = specialty;
            comboBoxSex.Text = sex;
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
            textBoxSalary.Text = "";
            textBoxSpecialty.Text = "";
            comboBoxSex.Text = "";
            doctorDOBPicker.Value = DateTime.Now;
            comboBoxSex.Text = "Male";
        }

        private void EditDoctor_Load(object sender, EventArgs e)
        {
            buttonAdd.Visible = true;
            labelMain.Visible = true;
            PopulateFields();
            AlignItems();
            removeErrors();
            AlignItems();
        }

        private void labelLNameErr_Click(object sender, EventArgs e)
        {

        }

        private void EditDoctor_Resize(object sender, EventArgs e)
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

            if (textBoxSpecialty.Text == "")
            {
                labelSpecialtyErr.Visible = true;
                failedVerification = true;
            }

            //if (Convert.ToInt32(comboBoxSex.SelectedIndex) == -1)
            //{
            //    labelSexErr.Visible = true;
            //    failedVerification = true;
            //}

            if (!failedVerification)
            {
                editDoctor(textBoxFname.Text, textBoxLname.Text, textBoxUsername.Text,
                    textBoxPassword.Text, doctorDOBPicker.Value.Date.ToShortDateString(), textBoxSalary.Text, textBoxSpecialty.Text, comboBoxSex.Text);
            }
        }

        private void editDoctor(String fName, String lName, String username, String password, String dob, String salary, String specialty, String sex)
        {
            User.Doctor doctor = new User.Doctor();
            doctor.firstName = fName;
            doctor.lastName = lName;
            doctor.username = username;
            doctor.password = password;
            doctor.dob = dob;
            doctor.salary = salary;
            doctor.specialty = specialty;
            doctor.sex = sex;

            bool success = doctor.EditDoctor(doctor, doctorId, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Updated Doctor", this);
                cm.Show();
                ClearField();
                OpenChildForm(new IndividualDoctor(doctorId, panelContainer));
            }
            //else
            //{
            //    CustomMessageBox cm = new CustomMessageBox("Failed to add new doctor", this);
            //    cm.Show();
            //}
        }
    }
}
