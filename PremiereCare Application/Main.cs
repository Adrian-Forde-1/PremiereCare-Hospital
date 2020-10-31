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
    public partial class Main : Form
    {

        private Form activeForm = null;

        public string userRole;
        public Main(String role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CloseDropdowns();
            if (userRole == "CSR")
            {
                buttonDoc.Hide();
                buttonTech.Hide();
            } else if(userRole == "Doctor")
            {
                buttonTech.Hide();
                buttonDoctor.Hide();
                buttonTechnician.Hide();
                buttonCSR.Hide();
            } else
            {
                buttonDoc.Hide();
                buttonDoctor.Hide();
                buttonTechnician.Hide();
                buttonCSR.Hide();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormContainer.Controls.Add(childForm);
            panelChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddDoctor());
           
        }

        private void buttonAddCSR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCSR());
        }

        private void buttonAddTechnician_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddTechnician());
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CloseDropdowns()
        {
            panelDoctorDropdown.Visible = false;
            panelTechnicianDropdown.Visible = false;
            panelCSRDropdown.Visible = false;
            panelDrugDropdown.Visible = false;
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelDoctorDropdown.Visible == false) panelDoctorDropdown.Visible = true;
            else panelDoctorDropdown.Visible = false;
        }

        private void buttonTechnician_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelTechnicianDropdown.Visible == false) panelTechnicianDropdown.Visible = true;
            else panelTechnicianDropdown.Visible = false;
        }

        private void buttonCSR_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelCSRDropdown.Visible == false) panelCSRDropdown.Visible = true;
            else panelCSRDropdown.Visible = false;
        }

      

        private void buttonDrug_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelDrugDropdown.Visible == false) panelDrugDropdown.Visible = true;
            else panelDrugDropdown.Visible = false;
        }
    }
}
