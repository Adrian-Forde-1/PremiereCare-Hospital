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
           // textBoxDosage.Visible = false;
            //labelDosage.Visible = false;
            labelDosageErr.Visible = false;
        }

        //Method to clear data entry points
        private void ClearField()
        {
            chkListBoxDrug.ClearSelected();
            chkListBoxDrug.CheckOnClick = false;
            textBoxDosage.Text = "";
            //serviceDate.Value = DateTime.Now;
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
            List<string> lst = new List<string>();

            premed.getSingleValueArrayIndex( out lst, 0);
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
                //labelDosage.Visible = true;
               // textBoxDosage.Visible = true;
                labelDosageErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {

                addPrescription(docID.ToString(), appointmentID.ToString());
                addData(getPrescriptionId(appointmentID.ToString()), getDrugId(chkListBoxDrug));

            }

        }

        //Gets drug_id for any item that may be checked/selected in check List Box and returns said Service_id in a list
        private List<string> getDrugId(CheckedListBox chk)
        {
            string drugId;
            List<string> lst = new List<string>();
            
            foreach (var item in chk.CheckedItems)
            {
                string qry = "SELECT drug_id FROM [PremiereCareHospital].[dbo].Drug WHERE drug ='" + item + "' ";
                premed.getSingleColumnValueByIndex(qry, out drugId, 0);
                lst.Add(drugId);
            }
            return lst;

        }



        //Gets the test_id associated with the appointment id in question and returns it
        private string getPrescriptionId(String appointmentID)
        {
            string prescription_ID;
            string qry = "SELECT prescription_id FROM [PremiereCareHospital].[dbo].Prescription WHERE appointment_id='" + appointmentID + "' ";
            premed.getPrescription_ID(qry, out prescription_ID);
            return prescription_ID;
        }

        //Inserts test_id and the selected Lab_Services service_id into the Service Table 
        private string addData(string prescription_id, List<string> ids)
        {
           
            
            foreach (var item in ids)
            {

                string qry = @"INSERT INTO [PremiereCareHospital].[dbo].Prescribed_Drug (prescription_id, drug_id) 
                            VALUES('" + prescription_id + "', '" + item + "')";
                premed.insertData(qry, premed, this);

            }
            
            ClearField();
            return " ";
        }

        //Inserts doctor_id and the appointment_id into theLab_Test Table 
        private void addPrescription(String doctor, String appointment)
        {
            string qry = @"INSERT INTO  [PremiereCareHospital].[dbo].Prescription (NEXT VALUE FOR prescription_seq, doc_id, appointment_id) 
                            VALUES('" + doctor + "', '" + appointment + "')";
            premed.insertData(qry, premed, this);

            ClearField();

        }

    }
}
