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
    public partial class IndividualAppointment : Form
    {

        private string userRole;
        private int userID;
        private int appointmentID;
        Panel panelContainer;
        public IndividualAppointment(string usrRole, int uID, int appID, Panel panel)
        {
            InitializeComponent();
            userRole = usrRole;
            userID = uID;
            panelContainer = panel;
            appointmentID = appID;
        }

        private void IndividualAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
