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
    public partial class EditDrug : Form
    {
        Drug.Drug drug = new Drug.Drug();
        Panel panelContainer;
        int drugId;
        public EditDrug(int dId, Panel panel)
        {
            drugId = dId;
            panelContainer = panel;
            InitializeComponent();
        }

        private void AlignItems()
        {
            buttonEdit.Location = new Point((this.ClientSize.Width - buttonEdit.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void PopulateFields()
        {
            DataTable dt = drug.GetDrug(drugId);
            DataRow row = dt.Rows[0];
            String name = row["drug"].ToString();
            String cost = row["cost"].ToString();
            textBoxDrug.Text = name;
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

        private void ClearFields()
        {
            textBoxDrug.Text = "";
            textBoxCost.Text = "";
        }

        private void removeErrors()
        {
            labelDrugErr.Visible = false;
            labelCostErr.Visible = false;
        }
        private void EditDrug_Load(object sender, EventArgs e)
        {
            AlignItems();
            removeErrors();
            PopulateFields();
            buttonEdit.Visible = true;
            labelMain.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool failedVerification = false;

            removeErrors();

            if (textBoxDrug.Text == "")
            {
                labelDrugErr.Visible = true;
                failedVerification = true;
            }

            if (textBoxCost.Text == "")
            {
                labelCostErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                editDrug();
            }
        }

        private void GotoAllDrugs()
        {
            OpenChildForm(new AllDrugs(panelContainer));
        }
        private void editDrug()
        {
            drug.name = textBoxDrug.Text.ToString();
            drug.cost = textBoxCost.Text.ToString();

            bool success = drug.EditDrug(drug, drugId, this);
            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Edited Drug", this, GotoAllDrugs);
                cm.Show();
                ClearFields();
                
            }
        }

        private void EditDrug_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }
    }
}
