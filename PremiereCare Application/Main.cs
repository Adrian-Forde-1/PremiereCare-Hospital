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
        public int userID;

        public Main(String role, int ID )
        {
            InitializeComponent();
            userRole = role;
            userID = ID;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel3.Size = new Size(200, 450);
            CloseDropdowns();
            if (userRole == "CSR")
            {
                buttonLabTest.Hide();
                buttonNotes.Hide();
                buttonPrescriptions.Hide();
                buttonCreateNotes.Hide();
                buttonViewNotes.Hide();
            }
            else if (userRole == "Doctor")
            {
                buttonDoctor.Hide();
                buttonTechnician.Hide();
                buttonCSR.Hide();
                buttonAddDrug.Hide();
                buttonAddPatient.Hide();
                buttonAddLabService.Hide();
            } else
            {
                buttonAppointments.Hide();
                buttonDoctor.Hide();
                buttonTechnician.Hide();
                buttonCSR.Hide();
                buttonLabTest.Hide();
                buttonNotes.Hide();
                buttonPrescriptions.Hide();
                buttonPatient.Hide();
                buttonLabServices.Hide();
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
                        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        } 

        private void CloseDropdowns()
        {
            panel_LabTestDropdown.Visible = false;
            panelDoctorDropdown.Visible = false;
            panelTechnicianDropdown.Visible = false;
            panelCSRDropdown.Visible = false;
            panelDrugDropdown.Visible = false;
            panelNotesDropdown.Visible = false;
            panelAppointmentDropdown.Visible = false;
            panelPatientDropdown.Visible = false;
            panelLabServiceDropdown.Visible = false;
        }
 

        //Main Button Doctor
        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelDoctorDropdown.Visible == false) panelDoctorDropdown.Visible = true;
            else panelDoctorDropdown.Visible = false;
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            //Open add doctor form
            OpenChildForm(new AddDoctor());
            CloseDropdowns();
        }

        private void buttonAllDoctors_Click(object sender, EventArgs e)
        {

            //Open alldoctors forms
            OpenChildForm(new AllDoctors());
            CloseDropdowns();
        }

       
        //Main Button Technician
        private void buttonTechnician_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelTechnicianDropdown.Visible == false) panelTechnicianDropdown.Visible = true;
            else panelTechnicianDropdown.Visible = false;
        }

        private void buttonAddTechnician_Click(object sender, EventArgs e)
        {
            //Open add technician form
            OpenChildForm(new AddTechnician());
            CloseDropdowns();
        }

        private void buttonViewTechnicians_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllTechnicians());
            CloseDropdowns();
            ;
        }

        

        //Main Button CSR
        private void buttonCSR_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelCSRDropdown.Visible == false) panelCSRDropdown.Visible = true;
            else panelCSRDropdown.Visible = false;
        }

        private void buttonAddCSR_Click(object sender, EventArgs e)
        {
            //Open add CSR form
            OpenChildForm(new AddCSR());
            CloseDropdowns();
        }

        private void buttonViewCSR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllCSR());
            CloseDropdowns();
        }


        //Main Button Drug
        private void buttonDrug_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelDrugDropdown.Visible == false) panelDrugDropdown.Visible = true;
            else panelDrugDropdown.Visible = false;
            if (userRole == "Doctor") { panelDrugDropdown.Size = new Size(200, 36); }
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            OpenChildForm(new AddDrug());
        }

        private void buttonAllDrugs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllDrugs());
            CloseDropdowns();
        }

        private void buttonEditDrug_Click_1(object sender, EventArgs e)
        {
            CloseDropdowns();
        }


        //Main Button Lab Test
        private void buttonLabTest_Click_1(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panel_LabTestDropdown.Visible == false) panel_LabTestDropdown.Visible = true;
              else panel_LabTestDropdown.Visible = false;
        }
                
        private void buttonViewLabTest_Click_1(object sender, EventArgs e)
        {
            //Open view Lab Test forms
            OpenChildForm(new ViewLabTest(userRole, userID, panelChildFormContainer));
            CloseDropdowns();
        }


        //Main Button Notes
        private void buttonNotes_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelNotesDropdown.Visible == false) panelNotesDropdown.Visible = true;
            else panelNotesDropdown.Visible = false;
        }

        private void buttonCreateNotes_Click(object sender, EventArgs e)
        {
            //Open Create Notes forms
            OpenChildForm(new CreateNotes());
            CloseDropdowns();
        }

        private void buttonViewNotes_Click(object sender, EventArgs e)
        {
            //Open View Notes forms
            OpenChildForm(new ViewNotes());
            CloseDropdowns();
        }

        
        //Main Button Appointments
        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            if (panelAppointmentDropdown.Visible == false) panelAppointmentDropdown.Visible = true;
            else panelAppointmentDropdown.Visible = false;
        }

        private void buttonViewAppointments_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            OpenChildForm(new ViewAppointment(userRole, userID, panelChildFormContainer));
        }


        //Main Button Prescriptions
        private void buttonPrescriptions_Click(object sender, EventArgs e)
        {
            
            
            //Open Prescribe Medication forms
            OpenChildForm(new RequestedLabTest(userRole, userID, panelChildFormContainer));
            CloseDropdowns();
        }


        private void buttonCreateAppointment_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            //OpenChildForm(new CreateAppointment(userID));
        }

        
        //Main Button Patient
        private void buttonPatient_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            if (panelPatientDropdown.Visible == false) panelPatientDropdown.Visible = true;
            else panelPatientDropdown.Visible = false;
            if (userRole == "Doctor") { panelPatientDropdown.Size = new Size(200, 36); }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            OpenChildForm(new AddPatient());
        }

        private void buttonAllPatients_Click(object sender, EventArgs e)
        {
            CloseDropdowns();
            OpenChildForm(new ViewPatients(panelChildFormContainer, userID));
        }
       
        
        //Main Lab Services Button
        private void buttonLabServices_Click(object sender, EventArgs e)
        {
            CloseDropdowns();

            if (panelLabServiceDropdown.Visible == false) panelLabServiceDropdown.Visible = true;
            else panelLabServiceDropdown.Visible = false;
            if (userRole == "Doctor") { panelLabServiceDropdown.Size = new Size(200, 36); }
        }

        private void buttonAddLabService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddLabService());
            CloseDropdowns();
        }

        private void buttonViewLabServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllLabServices());
            CloseDropdowns();
        }

       
       
    }
}
