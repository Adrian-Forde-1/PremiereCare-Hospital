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
        Drug.Drug drug = new Drug.Drug();
        Prescription.PrescribeMed prescription = new Prescription.PrescribeMed();

       
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
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelPatientAddress.Text = row["Patient Address"].ToString();
            labelPatienContact.Text = row["Patient Contact"].ToString();

            DataTable labTestDT = labTest.GetAllAppointmentLabTest(appointmentID);
            List<Tuple<string, string, decimal>> invoiceBilling = new List<Tuple<string, string, decimal>>();

            DataTable invoiceDataTable = new DataTable();
            invoiceDataTable.Columns.Add("Service / Drug".ToString());
            invoiceDataTable.Columns.Add("Cost".ToString());

            decimal totalCost = 0;

            if (labTestDT.Rows != null && labTestDT.Rows.Count != 0)
            {
                foreach (DataRow testRow in labTestDT.Rows)
                {
                    int testID = Convert.ToInt32(testRow["test_id"]);
                    DataTable serviceDt = labService.GetAllLabServiceForTest(testID);

                    foreach (DataRow serviceRow in serviceDt.Rows)
                    {
                        Console.WriteLine("Row");
                        Tuple<string, string, decimal> serivceInfo = new Tuple<string, string, decimal>("Service", serviceRow["Service"].ToString(), Convert.ToDecimal(serviceRow["Cost"]));
                        invoiceBilling.Add(serivceInfo);

                        totalCost = totalCost + Convert.ToDecimal(serviceRow["Cost"]);

                        DataRow dr = invoiceDataTable.NewRow();
                        dr["Service / Drug"] = "Service: " + serviceRow["Service"].ToString();
                        dr["Cost"] = serviceRow["Cost"].ToString();
                        invoiceDataTable.Rows.Add(dr);

                        //DataGridViewRow dgr = new DataGridViewRow();
                        //dgr.
                    }
                }
            }


            DataTable prescriptionDt = prescription.getPrescriptionIDFromAppointment(appointmentID);
            if (prescriptionDt.Rows != null && prescriptionDt.Rows.Count != 0)
            {
                int prescriptionID = Convert.ToInt32(prescriptionDt.Rows[0]["prescription_id"]);
                DataTable drugsDT = drug.GetDrugsFromPrescriptionID(prescriptionID);

                if (drugsDT.Rows != null && drugsDT.Rows.Count != 0)
                {
                    foreach (DataRow drugRow in drugsDT.Rows)
                    {
                        Tuple<string, string, decimal> drugInfo = new Tuple<string, string, decimal>("Drug", drugRow["Drug"].ToString(), Convert.ToDecimal(drugRow["Cost"]));
                        invoiceBilling.Add(drugInfo);

                        totalCost = totalCost + Convert.ToDecimal(drugRow["Cost"]);

                        DataRow dr = invoiceDataTable.NewRow();
                        dr["Service / Drug"] = "Drug: " + drugRow["Drug"].ToString();
                        dr["Cost"] = drugRow["Cost"].ToString();
                        invoiceDataTable.Rows.Add(dr);
                    }
                }
            }

            DataRow dataRow = invoiceDataTable.NewRow();
            dataRow["Service / Drug"] = "Total";
            dataRow["Cost"] = totalCost.ToString();
            invoiceDataTable.Rows.Add(dataRow);

            for (int i = 0; i < invoiceBilling.Count; i++)
            {
                Console.WriteLine(invoiceBilling[i]);
            }

            dgvInvoice.DataSource = invoiceDataTable;



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
            labelDate.Location = new Point((panelDateContainer.Width - labelDate.Width) / 2, (panelDateContainer.Height - labelDate.Height) / 2);
            labelInvoiceNumTitle.Location = new Point((panelInvoiceNumTitleContainer.Width - labelInvoiceNumTitle.Width) / 2, (panelInvoiceNumTitleContainer.Height - labelInvoiceNumTitle.Height) / 2);
            labelDateTitle.Location = new Point((panelDateTitleContainer.Width - labelDateTitle.Width) / 2, (panelDateTitleContainer.Height - labelDateTitle.Height) / 2);
            labelContact.Location = new Point((panelInvoiceFooter.Width - labelContact.Width) / 2, (panelInvoiceFooter.Height - labelContact.Height) / 2);
            labelContactDesc.Location = new Point((panelInvoiceFooter.Width - labelContactDesc.Width) / 2, labelContact.Height);
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

        private void invoiceContentContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
