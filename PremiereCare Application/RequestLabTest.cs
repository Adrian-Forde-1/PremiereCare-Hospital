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
        LabTest.LabTest labTest = new LabTest.LabTest();
        LabService.LabService labServices = new LabService.LabService();
        public string GetMessage { get; set; }

        //variables
        private int docID;
        private int appointmentID;
        private List<int> serviceIDs = new List<int>();

        Panel panelContainer;
        string userRole;
        // private DateTime submitedDate = DateTime.Now;

        //Constructor passes doctor and appointment ID
        public RequestLabTest(int dID, int appID, string usrRole, Panel panel)
        {
            docID = dID;
            appointmentID = appID;
            panelContainer = panel;
            userRole = usrRole;
            InitializeComponent();
            
        }

        //Method to remove error labels
        private void removeErrors()
        {
            labelServiceErr.Visible = false;

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

        private void PopulateServices()
        {
            DataTable dt = labServices.GetAllLabService("");
            foreach (DataRow row in dt.Rows)
            {
                int serviceID = Convert.ToInt32(row["ID"]);
                String service = row["Service"].ToString();
                serviceIDs.Add(serviceID);
                checkedListBoxServices.Items.Add(service, false);
            }


            int numServices = serviceIDs.Count();
            checkedListBoxServices.Size = new Size(250, 15 * numServices);
            int errLabelYPos = checkedListBoxServices.Location.Y + (15 * numServices);
            labelServiceErr.Location = new Point(checkedListBoxServices.Location.X, errLabelYPos);
        }

        private void ClearChecked()
        {
            for (int i = 0; i < checkedListBoxServices.Items.Count; i++)
            {
                if (checkedListBoxServices.GetItemChecked(i))
                {
                    checkedListBoxServices.SetItemChecked(i, false);
                }
            }
        }

        //Method to execute tasks on the loading of form
        private void RequestLabTest_Load(object sender, EventArgs e)
        {
            removeErrors();
            AlignItems();
            PopulateServices();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        //Method to execute actions on clicking of button
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int failedVerification = 0;

            removeErrors();

            for (int i = 0; i < checkedListBoxServices.Items.Count; i++)
            {
                if (checkedListBoxServices.GetItemChecked(i))
                {
                    failedVerification++;
                }
            }

            if (failedVerification > 0)
            {   
                addLabTest( docID.ToString(), appointmentID.ToString());
            } else
            {
                labelServiceErr.Visible = true;
            }
        }

        private void gotoIndividualAppointment()
        {
            OpenChildForm(new IndividualAppointment(userRole, docID, appointmentID, panelContainer));
        }


        //Inserts doctor_id and the appointment_id into theLab_Test Table 
        private void addLabTest( String doctor, String appointment)
        {
            labTest.docID = doctor;
            labTest.appointmentID = appointment;

            List<int> servicesOnTest = new List<int>();

            for(int i = 0; i < checkedListBoxServices.Items.Count; i++)
            {
                if(checkedListBoxServices.GetItemChecked(i))
                {
                    servicesOnTest.Add(serviceIDs[i]);
                }
            }

            bool success = labTest.CreateLabRequest(labTest, this);


            if (success == true)
            {
                DataTable testIdDt = labTest.GetMostRecentTestID();
                int recentTestID = Convert.ToInt32(testIdDt.Rows[0]["test_id"]);
                bool servicesAdded = labTest.SetServices(recentTestID, servicesOnTest, this);
                Console.WriteLine(servicesAdded);
                if(servicesAdded)
                {
                    CustomMessageBox cm = new CustomMessageBox("Successfully Requested Lab Test", this, gotoIndividualAppointment);
                    removeErrors();
                    ClearChecked();
                    cm.Show();
                }

                
            }

        }

        private void checkedListBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelServiceErr_Click(object sender, EventArgs e)
        {

        }

        private void labelServiceErr_Click_1(object sender, EventArgs e)
        {

        }
    }
}
