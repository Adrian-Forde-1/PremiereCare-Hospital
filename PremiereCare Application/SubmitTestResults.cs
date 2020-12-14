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
    public partial class SubmitTestResults : Form
    {
        private int techID;
        private int labTestID;
        private string userRole;
        Panel panelContainer;

        public SubmitTestResults(int tID, int lTestID, string usrRole, Panel panel)
        {
            techID = tID;
            labTestID = lTestID;
            userRole = usrRole;
            panelContainer = panel;
            InitializeComponent();
            
           
        }
        
        //Method to align items
        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        //Method to clear data entry points
        private void ClearField()
        {
            textBoxResults.Text = "";
        }

        //Method to remove error labels
        private void removeErrors()
        {
            labelResultsErr.Visible = false;
        }

        //Method to execute tasks on the loading of form
        private void SubmitTestResults_Load(object sender, EventArgs e)
        {
            removeErrors();
            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        //Method to execute AlignItems
        private void SubmitTestResults_Resize(object sender, EventArgs e)
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


        //Method to execute actions on clicking of button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (textBoxResults.Text == "")
            {
                labelResultsErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {                
                addResults(textBoxResults.Text, techID.ToString());
            }
        }

        private void addResults(string results, string technician)
        {
           LabTest.LabTest labtest = new LabTest.LabTest();
            labtest.results = results;
            labtest.techID = technician;

            bool success = labtest.SubmitTestResults(labTestID, labtest, this);

           if (success == true)
           {
                CustomMessageBox cm = new CustomMessageBox("Successfully Submited Test Results", this);
                removeErrors();
                ClearField();
                cm.Show();
                OpenChildForm(new ViewLabTest(userRole, techID, panelContainer));
           }

        }

        
    }
}
