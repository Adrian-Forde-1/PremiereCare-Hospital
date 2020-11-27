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
    
    public partial class PrescribeMedication : Form
    {
        Prescription.PrescribeMed premed = new Prescription.PrescribeMed();
        //variables
        private int docID;
        private int appointmentID;
        // private DateTime submitedDate = DateTime.Now;
        
        public PrescribeMedication(int dID, int appID)
        {
            InitializeComponent();
            docID = dID;
            appointmentID = appID;
        }

        //Method to remove error labels
        private void removeObject()
        {            
            labelDrugErr.Visible = false;
            labelDosageErr.Visible = false;
        }

        //Method to clear data entry points
        private void ClearFields()
        {
            chkListBoxDrug.ClearSelected();
            chkListBoxDrug.CheckOnClick = false;
            textBoxDosage.Text = "";
           
        }

        //Method to align items
        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void labelMain_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void PrescribeMedication_Load(object sender, EventArgs e)
        {
            removeObject();
            AlignItems();
            loadDrugs();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
           
        }

        private List<string> loadDrugs()
        {
            premed.getSingleValueArrayIndex(out List<string> lst, 0);
            foreach (var item in lst)
            {
                chkListBoxDrug.Items.Add(item);
            }
            return lst;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeObject();

            if (chkListBoxDrug.CheckedItems.Count == 0)
            {
                labelDrugErr.Visible = true;
                failedVerification = true;
            }

            if (chkListBoxDrug.CheckedItems.Count == 0 && textBoxDosage.Text == "")
            {
                
                labelDosageErr.Visible = true;
                failedVerification = true;
            }

            if ( chkListBoxDrug.CheckedItems.Count != 0 && textBoxDosage.Text == "")
            {               
                labelDosageErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {

                addPrescription(docID.ToString(), appointmentID.ToString(), getPatientId(appointmentID.ToString()));
                addPrescribedDrugs(getPrescriptionId(appointmentID.ToString()), getDrugId(chkListBoxDrug), textBoxDosage.Text);

            }

        }

        //Gets drug_id for any item that may be checked/selected in check List Box and returns said Service_id in a list
        private List<string> getDrugId(CheckedListBox chk)
        {
            List<string> lst = new List<string>();
            
            foreach (var item in chk.CheckedItems)
            {
                string qry = "SELECT drug_id FROM [PremiereCareHospital].[dbo].Drug WHERE drug Like '" + item + "' ";
                premed.getSingleColumnValueByIndex(qry, out string drugId, 0);
                lst.Add(drugId);
            }
            return lst;

        }

        //Gets the patient_id associated with the appointment id in question and returns it
        private string getPatientId(string appointmentID)
        {           
            return  premed.getPatient_ID(appointmentID);
        }

        //Gets the test_id associated with the appointment id in question and returns it
        private string getPrescriptionId(string appointmentID)
        {
            return premed.getPrescription_ID(appointmentID);            
        }

        //Inserts doctor_id and the appointment_id into theLab_Test Table 
        private void addPrescription(string doctor, string appointment, string patient)
        {

            premed.doctor_id = doctor;
            premed.appointment_id = appointment;
            premed.patient_id = patient;
           
            bool success = premed.Prescription(premed, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Created Prescriptio", this);
                removeObject();
                ClearFields();
                cm.Show();
            }

        }

        //Inserts test_id and the selected Lab_Services service_id into the Service Table 
        private void addPrescribedDrugs(string prescription_id, List<string> ids, string dosage)
        {
            premed.prescription_id = prescription_id;
            premed.dosage = dosage;
               
            bool success = premed.PrescribedDrugs(ids, premed, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Prescribed Drug", this);
                removeObject();
                ClearFields();
                cm.Show();
            }
        }
    }
}
