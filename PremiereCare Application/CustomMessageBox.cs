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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(String customMessage, Form form)
        {
            InitializeComponent();

            labelCustomMessageBox.Text = customMessage;
            this.TopLevel = false;
            this.Parent = form;
            this.CenterToParent();
            this.BringToFront();
        }

        private void buttonCloseMessageBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
