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
    public partial class IndividualDoctor : Form
    {
        User.Doctor doctor = new User.Doctor();
        int doctorId;
        Panel panelContainer;
        Patient.Patient patient = new Patient.Patient();

       

        public IndividualDoctor(int docId, Panel panel)
        {
            doctorId = docId;
            panelContainer = panel;
            InitializeComponent();
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

        private void PopulateFields()
        {
            DataTable doctorDT = doctor.GetDoctor(doctorId);

            if(doctorDT.Rows != null && doctorDT.Rows.Count != 0)
            {
                DataRow row = doctorDT.Rows[0];
                labelName.Text = row["fname"].ToString() + " " + row["lname"].ToString();
                labelSpecialty.Text = row["specialty"].ToString();
                labelDOB.Text = row["dob"].ToString();
                labelSalary.Text = row["salary"].ToString();
                labelSex.Text = row["sex"].ToString();

            }
        }

        private void IndividualDoctor_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void buttonEditPatientProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditDoctor(doctorId, panelContainer));
        }
    }
}
