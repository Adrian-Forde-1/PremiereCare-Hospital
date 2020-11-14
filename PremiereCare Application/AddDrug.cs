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
    public partial class AddDrug : Form
    {

        Drug.Drug drug = new Drug.Drug();
        public AddDrug()
        {
            InitializeComponent();
        }

        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
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

        private void AddDrug_Load(object sender, EventArgs e)
        {
            AlignItems();
            removeErrors();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void AddDrug_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                addDrug();
            }
        }

        private void addDrug()
        {
            drug.name = textBoxDrug.Text.ToString();
            drug.cost = textBoxCost.Text.ToString();

            bool success = drug.AddNewDrug(drug, this);
            if(success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Added Drug", this);
                cm.Show();
                ClearFields();
            }
        }
    }
}
