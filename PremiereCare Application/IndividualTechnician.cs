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
    public partial class IndividualTechnician : Form
    {
        User.Technician technician = new User.Technician();
        int technicianId;
        Panel panelContainer;

        public IndividualTechnician(int techId, Panel panel)
        {
            technicianId = techId;
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
            DataTable technicianDt = technician.GetTechnician(technicianId);

            if (technicianDt.Rows != null && technicianDt.Rows.Count != 0)
            {
                DataRow row = technicianDt.Rows[0];
                labelName.Text = row["fname"].ToString() + " " + row["lname"].ToString();
                labelDOB.Text = row["dob"].ToString();
                labelSalary.Text = row["salary"].ToString();
                labelSex.Text = row["sex"].ToString();

            }
        }

        private void IndividualTechnician_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void buttonEditPatientProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditTechnician(technicianId, panelContainer));
        }
    }
}
