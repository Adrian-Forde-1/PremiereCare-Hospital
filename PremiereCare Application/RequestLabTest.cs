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
    public partial class RequestLabTest : Form
    {
        LabTest.LabTest labtest = new LabTest.LabTest();
        public string GetMessage { get; set; }

        //variables
        private int docID;
        private int appointmentID;
       // private DateTime submitedDate = DateTime.Now;

        //Constructor passes doctor and appointment ID
        public RequestLabTest(int dID, int appID)
        {
            labtest = new LabTest.LabTest();
            InitializeComponent();
            docID = dID;
            appointmentID = appID;
        }

        //Method to remove error labels
        private void removeErrors()
        {
            labelServiceErr.Visible = false;

        }

        //Method to clear data entry points
        private void ClearField()
        {
           
            checkedListBoxServices.ClearSelected();
            checkedListBoxServices.CheckOnClick=false;
            //serviceDate.Value = DateTime.Now;
        }

        //Method to align items
        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        //Method to execute AlignItems
        private void RequestLabTest_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        //Method to execute tasks on the loading of form
        private void RequestLabTest_Load(object sender, EventArgs e)
        {
            removeErrors();
            AlignItems();
            loadServices();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        //Loads services from Lab_Service table into the checkedListBoxServices
        private List<string> loadServices()
        {
            labtest.getSingleValueArrayIndex(out List<string> lst, 0);
            foreach (var item in lst)
            {
                checkedListBoxServices.Items.Add(item);
            }
            return lst;
        }

        //Method to execute actions on clicking of button
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            bool failedVerification = false;

            removeErrors();

            if (checkedListBoxServices.Text == "")
            {
                labelServiceErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {

                addLabTest( docID.ToString(), appointmentID.ToString());
                addService(getTestId(appointmentID.ToString()), getServiceId(checkedListBoxServices));
                
            }
        }

                
        //Gets service_id for any item that may be checked/selected in check List Box and returns said Service_id in an array
        private List<string> getServiceId(CheckedListBox chk)
        {
           
            List<string> lst = new List<string>();

            foreach (var item in chk.CheckedItems)
            {
                string qry = "SELECT service_id FROM [PremiereCareHospital].[dbo].Lab_Services WHERE service LIKE '" + item + "' ";
                labtest.getSingleColumnValueByIndex(qry, out string serviceId, 0);
                lst.Add(serviceId);
            }
            return lst;

        }

        //Gets the test_id associated with the appointment id in question and returns it
        private string getTestId(string appointmentID)
        {

            string value = labtest.getTest_ID(appointmentID);
            return value;
        }

        //Inserts test_id and the selected Lab_Services service_id into the Service Table 
        private void addService( string test_id, List<string> ids)
        {
            labtest.testID = test_id;
                
            bool success = labtest.Service(ids, labtest, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Service", this);
                removeErrors();
                ClearField();
                cm.Show();
            }         
        }

        //Inserts doctor_id and the appointment_id into theLab_Test Table 
        private void addLabTest( String doctor, String appointment)
        {
            labtest.docID = doctor;
            labtest.appointmentID = appointment;
            
            bool success = labtest.TestRequest(labtest, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Requested Lab Test", this);
                removeErrors();
                ClearField();
                cm.Show();
            }

        }

        private void checkedListBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
