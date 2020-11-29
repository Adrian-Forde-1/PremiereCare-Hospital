using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiereCare_Application
{
    public partial class Invoice : Form
    {

        private int appointmentID;
        Reports.Invoice invoice = new Reports.Invoice();
        LabTest.LabTest labTest = new LabTest.LabTest();
        LabService.LabService labService = new LabService.LabService();

       
        public Invoice(int appID)
        {
            InitializeComponent();
            appointmentID = appID;
        }

        private void SetValues()
        {
            DataTable dt = invoice.GetInvoiceData(appointmentID);
            DataRow row = dt.Rows[0];
            String docFName = row["Doctor First Name"].ToString();
            String docLName = row["Doctor Last Name"].ToString();
            String patFName = row["Patient First Name"].ToString();
            String patLName = row["Patient Last Name"].ToString();
            labelInvoiceNum.Text = row["Appointment ID"].ToString();
            labelPatientName.Text = patFName + " " + patLName;
            labelDoctorName.Text = docFName + " " + docLName;
            labelDoctorSpecialty.Text = row["Doctor Specialty"].ToString();
            labelTermDesc.Text = DateTime.Now.ToShortDateString();
            labelPatientAddress.Text = row["Patient Address"].ToString();
            labelPatienContact.Text = row["Patient Contact"].ToString();

            DataTable labTestDT = labTest.GetAllAppointmentLabTest(appointmentID);
            List<Tuple<string, decimal>> services = new List<Tuple<string, decimal>>();

            foreach(DataRow testRow in labTestDT.Rows)
            {
                int testID = Convert.ToInt32(testRow["test_id"]);
                DataTable serviceDt = labService.GetAllLabServiceForTest(testID);

                foreach(DataRow serviceRow in serviceDt.Rows)
                {
                    Tuple<string, decimal> serivceInfo = new Tuple<string, decimal>(serviceRow["Service"].ToString(), Convert.ToDecimal(serviceRow["Cost"]));
                    services.Add(serivceInfo);
                }
            }

            for(int i = 0; i < services.Count; i++)
            {
                Console.WriteLine(services[i]);
            }

            //labelAppointmentID.Text = appointmentID.ToString();
            //labelDoctorName.Text = docFName + " " + docLName;
            //labelDoctorSpecialty.Text = patFName + " " + patLName;
            //labelPatientAllergies.Text = allergies;
            //labelPatientDOB.Text = DOB;
            //labelPatientBloodType.Text = bloodType;
            //labelAppointmentStatus.Text = status;
        }

        private void AlignItems()
        {
            panelInvoice.Location = new Point((panelInvoiceContainer.Width - panelInvoice.Width) / 2, (panelInvoiceContainer.Height - panelInvoice.Height) / 2);
            labelDoctorName.Location = new Point((panelDocNameContainer.Width - labelDoctorName.Width) / 2, (panelDocNameContainer.Height - labelDoctorName.Height) / 2);
            labelDoctorSpecialty.Location = new Point((panelDocSpecialtyContainer.Width - labelDoctorSpecialty.Width) / 2, (panelDocSpecialtyContainer.Height - labelDoctorSpecialty.Height) / 2);
            labelDocTitle.Location = new Point((panelDocTitleContainer.Width - labelDocTitle.Width) / 2, (panelDocTitleContainer.Height - labelDocTitle.Height) / 2);;
            labelDocSpecialtyTitle.Location = new Point((panelDocSpecialtyTitleContainer.Width - labelDocSpecialtyTitle.Width) / 2, (panelDocSpecialtyTitleContainer.Height - labelDocSpecialtyTitle.Height) / 2);
            labelInvoiceNum.Location = new Point((panelInvoiceNumContainer.Width - labelInvoiceNum.Width) / 2, (panelInvoiceNumContainer.Height - labelInvoiceNum.Height) / 2);;
            labelTermDesc.Location = new Point((panelTermDescContainer.Width - labelTermDesc.Width) / 2, (panelTermDescContainer.Height - labelTermDesc.Height) / 2);
            labelInvoiceNumTitle.Location = new Point((panelInvoiceNumTitleContainer.Width - labelInvoiceNumTitle.Width) / 2, (panelInvoiceNumTitleContainer.Height - labelInvoiceNumTitle.Height) / 2);
            labelTermsTitle.Location = new Point((panelTermsTitleContainer.Width - labelTermsTitle.Width) / 2, (panelTermsTitleContainer.Height - labelTermsTitle.Height) / 2);
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            AlignItems();
            SetValues();
        }

        private void Invoice_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
