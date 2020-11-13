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
    public partial class ViewAppointment : Form
    {

        Appointment.Appointment apppointment = new Appointment.Appointment();
        Panel panelContainer;

        private string userRole;
        private int userID;

       
        public ViewAppointment(String usrRole, int uID, Panel panel)
        {
            InitializeComponent();
            userRole = usrRole;
            userID = uID;
            panelContainer = panel;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnInactive_Click(object sender, EventArgs e)
        {

        }

        private void PopulateAppointments()
        {
            DataTable dt = apppointment.GetAllAppointments(userRole, userID);
            dgvAppointments.DataSource = dt;
        }

        private void ViewAppointment_Load(object sender, EventArgs e)
        {
            PopulateAppointments();
        }

        private void dgvAppointments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int appointmentID = Convert.ToInt32(dgvAppointments.Rows[rowIndex].Cells[0].Value);
            OpenChildForm(new IndividualAppointment(userRole, userID, appointmentID, panelContainer));
        }
    }
}
