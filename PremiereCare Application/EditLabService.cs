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
    public partial class EditLabService : Form
    {
        LabService.LabService labService = new LabService.LabService();
        Panel panelContainer;
        int labServiceId;

        public EditLabService(int lsId, Panel panel)
        {
            labServiceId = lsId;
            panelContainer = panel;
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

        private void PopulateFields()
        {
            DataTable dt = labService.GetLabService(labServiceId);
            DataRow row = dt.Rows[0];
            String name = row["service"].ToString();
            String cost = row["cost"].ToString();
            textBoxService.Text = name;
            textBoxCost.Text = cost;
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

        private void EditLabService_Load(object sender, EventArgs e)
        {
            AlignItems();
            removeErrors();
            PopulateFields();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void EditLabService_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e) { 

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
                editLabService();
            }
        }

        private void GotoLabService()
        {
            OpenChildForm(new AllLabServices(panelContainer));
        }
        private void editLabService()
        {
            labService.service = textBoxService.Text.ToString();
            labService.cost = textBoxCost.Text.ToString();


            bool success = labService.EditLabService(labService, labServiceId, this);
            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Edited Service", this, GotoLabService);
                cm.Show();
                ClearField();
                
            }
        }
    }
}
