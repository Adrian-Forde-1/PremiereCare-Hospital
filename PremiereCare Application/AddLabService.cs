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
        public AddLabService()
        {
            InitializeComponent();
        }
        private void removeErrors()
        {
            labelSericeErr.Visible = false;
            labelCostErr.Visible = false;
        }

        private void ClearField()
        {
            textBoxService.Text = "";
            textBoxCost.Text = "";
        }


        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void AddLabService_Load(object sender, EventArgs e)
        {
            removeErrors();

            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void AddLabService_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }
    }
}
