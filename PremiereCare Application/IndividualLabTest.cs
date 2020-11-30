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
    public partial class IndividualLabTest : Form
    {
        private string userRole;
        private int labTestID;
        private int userID;

        LabTest.LabTest labtest = new LabTest.LabTest();
        Panel panelContainer;

        public IndividualLabTest(string usrRole, int usrID, int ltID, Panel panel)
        {
            InitializeComponent();
            panelContainer = panel;
            userRole = usrRole;
            userID = usrID;
            labTestID = ltID;
           

            buttonComplete.Hide();

            if (userRole != "Doctor")
            {
                buttonCancel.Hide();
                buttonGenerateInvoice.Hide();
            }
            if (userRole != "Technician")
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
            DataTable dt = labtest.GetLabTest(labTestID);
            DataRow row = dt.Rows[0];
            String appID = row["Appointment ID"].ToString();
            String docFName = row["Doctor First Name"].ToString();
            String docLName = row["Doctor Last Name"].ToString();
            String docSpecialty = row["Doctor Specialty"].ToString();
            String patFName = row["Patient First Name"].ToString();
            String patLName = row["Patient Last Name"].ToString();
            String reqDate = row["Requested Date"].ToString();
            String requTest = row["Requested Test"].ToString();
            String status = row["Status"].ToString();
            String results = row["Results"].ToString();
            labelLabTestID.Text = labTestID.ToString();
            labelAppointmentNO.Text = appID;
            labelDoctorName.Text = docFName + " " + docLName;
            labelDoctorSpecialty.Text = docSpecialty;
            labelPatientName.Text = patFName + " " + patLName;
            labelRequestedDate.Text = reqDate;
            labelRequestedTest.Text = requTest;
            labelStatus.Text = status;
            labelResults.Text = results;
                           
            if (status != "Complete" && userRole == "Doctor") buttonComplete.Show();
        }

        private void IndividualLabTest_Load(object sender, EventArgs e)
        {
            SetValues();
        }

    }
}
