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
    public partial class IndividualAppointment : Form
    {

        private string userRole;
        private int userID;
        private int appointmentID;
        Panel panelContainer;
        Appointment.Appointment appointment = new Appointment.Appointment();
        public IndividualAppointment(string usrRole, int uID, int appID, Panel panel)
        {
            InitializeComponent();
            userRole = usrRole;
            userID = uID;
            panelContainer = panel;
            appointmentID = appID;

            buttonComplete.Hide();

            if (userRole != "CSR")
            {
                buttonCancel.Hide();
                buttonGenerateInvoice.Hide();
            }
            if(userRole !="Doctor")
            {
                buttonCreateVisitNote.Hide();
                buttonRequestLabTest.Hide();
                buttonPrescribeMedication.Hide();
            }
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

        private void SetValues()
        {
            DataTable dt = appointment.GetAppointment(appointmentID);
            DataRow row = dt.Rows[0];
            String docFName = row["Doctor First Name"].ToString();
            String docLName = row["Doctor Last Name"].ToString();
            String patFName = row["Patient First Name"].ToString();
            String patLName = row["Patient Last Name"].ToString();
            String DOB = row["Patient Date of Birth"].ToString();
            String bloodType = row["Patient Blood Type"].ToString();
            String allergies = row["Patient Allergies"].ToString();
            String status = row["Status"].ToString();
            labelAppointmentID.Text = appointmentID.ToString();
            labelDoctorName.Text = docFName + " " + docLName;
            labelDoctorSpecialty.Text = patFName + " " + patLName;
            labelPatientAllergies.Text = allergies;
            labelPatientDOB.Text = DOB;
            labelPatientBloodType.Text = bloodType;
            label10.Text = status;

            if (status != "Complete" && userRole == "Doctor") buttonComplete.Show();
        }


        private void IndividualAppointment_Load(object sender, EventArgs e)
        {
            SetValues();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCreateVisitNote_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateVisitNote(userID, appointmentID));
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {

        }
    }
}
