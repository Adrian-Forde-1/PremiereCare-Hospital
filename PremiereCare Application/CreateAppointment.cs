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
    public partial class CreateAppointment : Form
    {
        private String userID;
        public CreateAppointment()
        {
            InitializeComponent();
        }

        public CreateAppointment(String ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void AlignItems()
        {
            buttonCreate.Location = new Point((this.ClientSize.Width - buttonCreate.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }

        private void CreateAppointment_Load(object sender, EventArgs e)
        {
            AlignItems();
            buttonCreate.Visible = true;
            labelMain.Visible = true;
            textBoxFname.Text = userID;
            appointmentDatePicker.Format = DateTimePickerFormat.Custom;
            appointmentDatePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            appointmentDatePicker.MinDate = DateTime.Now;
        }

        private void CreateAppointment_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
