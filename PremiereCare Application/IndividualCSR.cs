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
    public partial class IndividualCSR : Form
    {
        User.CSR csr = new User.CSR();
        int csrId;
        Panel panelContainer;
        public IndividualCSR(int csrID, Panel panel)
        {
            csrId = csrID;
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
            DataTable csrDt = csr.GetCSR(csrId);

            if (csrDt.Rows != null && csrDt.Rows.Count != 0)
            {
                DataRow row = csrDt.Rows[0];
                labelName.Text = row["fname"].ToString() + " " + row["lname"].ToString();
                labelDOB.Text = row["dob"].ToString();
                labelSalary.Text = row["salary"].ToString();
                labelSex.Text = row["sex"].ToString();

            }
        }

        private void IndividualCSR_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void buttonEditPatientProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditCSR(csrId, panelContainer));
        }
    }
}
