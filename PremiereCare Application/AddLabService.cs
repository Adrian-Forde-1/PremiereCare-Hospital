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
    public partial class AddLabService : Form
    {
        LabService.LabService labservice = new LabService.LabService();
        public AddLabService()
        {
            InitializeComponent();
        }

        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void ClearField()
        {
            textBoxService.Text = "";
            textBoxCost.Text = "";
        }

        private void removeErrors()
        {
            labelSericeErr.Visible = false;
            labelCostErr.Visible = false;
        }

        
        private void AddLabService_Load(object sender, EventArgs e)
        {

            AlignItems();
            removeErrors();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void AddLabService_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (textBoxService.Text == "")
            {
                labelSericeErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxCost.Text == "")
            {
                labelCostErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                addLabService();
            }
                        
        }

        private void addLabService()
        {
            labservice.service = textBoxService.Text.ToString();
            labservice.cost = textBoxCost.Text.ToString();


            bool success = labservice.AddNewLabService(labservice, this);
            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Service", this);
                cm.Show();
                ClearField();
            }
        }

    }
}
