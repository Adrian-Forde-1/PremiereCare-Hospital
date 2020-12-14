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
        Prescription.PrescribeMed prescription = new Prescription.PrescribeMed();
        Drug.Drug drug = new Drug.Drug();
        //variables
        private int docID;
        private int appointmentID;
        private int patientID;
        private List<int> drugIDs = new List<int>();
        // private DateTime submitedDate = DateTime.Now;

        public PrescribeMedication(int dID, int appID, int pID)
        {
            InitializeComponent();
            docID = dID;
            appointmentID = appID;
            patientID = pID;
        }

        //Method to remove error labels
        private void removeErrors()
        {            
            labelDrugErr.Visible = false;
            labelDosageErr.Visible = false;
        }

        private void PopulateDrugs()
        {
            DataTable dt = drug.GetAllDrugs();
            foreach (DataRow row in dt.Rows)
            {
                int drugID = Convert.ToInt32(row["ID"]);
                String drug = row["Drug"].ToString();
                drugIDs.Add(drugID);
                checkedListBoxDrugs.Items.Add(drug, false);
            }

            int numServices = drugIDs.Count();
            checkedListBoxDrugs.Size = new Size(250, 15 * numServices);
            int errLabelYPos = checkedListBoxDrugs.Location.Y + (15 * numServices);
            labelDrugErr.Location = new Point(checkedListBoxDrugs.Location.X, errLabelYPos);
            labelDosage.Location = new Point(labelDrugErr.Location.X, labelDrugErr.Location.Y + 15);
            textBoxDosage.Location = new Point(labelDosage.Location.X, labelDosage.Location.Y + 20);
            labelDosageErr.Location = new Point(textBoxDosage.Location.X, textBoxDosage.Location.Y + 10);
        }

        //Method to clear data entry points
        private void ClearFields()
        {
            textBoxDosage.Text = "";
        }

        private void ClearChecked()
        {
            for (int i = 0; i < checkedListBoxDrugs.Items.Count; i++)
            {
                if (checkedListBoxDrugs.GetItemChecked(i))
                {
                    checkedListBoxDrugs.SetItemChecked(i, false);
                }
            }
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
            removeErrors();
            AlignItems();
            PopulateDrugs();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
           
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int failedVerification = 0;
            int checkedItems = 0;

            removeErrors();

            for (int i = 0; i < checkedListBoxDrugs.Items.Count; i++)
            {
                if (checkedListBoxDrugs.GetItemChecked(i))
                {
                    failedVerification++;
                    checkedItems++;
                }
            }

            if(checkedItems == 0)
            {
                labelDrugErr.Visible = true;
            }

            if(textBoxDosage.Text == "")
            {
                failedVerification++;
                labelDosageErr.Visible = true;
            }

            if (failedVerification > 0)
            {
                addPrescription(Convert.ToInt32(docID), Convert.ToInt32(appointmentID), textBoxDosage.Text.ToString());

            }

        }


        //Inserts doctor_id and the appointment_id into theLab_Test Table 
        private void addPrescription(int doctor, int appointment, string dosage)
        {

            prescription.doctor_id = doctor;
            prescription.appointment_id = appointment;
            prescription.patient_id = patientID;
            prescription.dosage = dosage;

            List<int> drugsOnPrescription = new List<int>();

            for (int i = 0; i < checkedListBoxDrugs.Items.Count; i++)
            {
                if (checkedListBoxDrugs.GetItemChecked(i))
                {
                    drugsOnPrescription.Add(drugIDs[i]);
                }
            }

            bool success = prescription.PrescribeMedication(prescription, this);

            if (success == true)
            {
                DataTable precriptionIdDt = prescription.GetMostRecentPrescriptionID();
                int recentPrecriptionID = Convert.ToInt32(precriptionIdDt.Rows[0]["prescription_id"]);
                bool servicesAdded = prescription.PrescribedDrugs(recentPrecriptionID, drugsOnPrescription, this);

                if (servicesAdded)
                {
                    CustomMessageBox cm = new CustomMessageBox("Successfully Created Prescription", this);
                    removeErrors();
                    ClearChecked();
                    ClearFields();
                    cm.Show();
                }
            }

        }

    }
}
