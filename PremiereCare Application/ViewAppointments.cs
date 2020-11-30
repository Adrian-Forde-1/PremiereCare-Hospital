using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            //Get the value from textbox
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable(); 
            
            string qry = "";
            if (userRole == "CSR") qry = @"SELECT 
                                              a.appointment_id, 
                                              a.appointment_date, 
                                              d.fname + ' ' + d.lname AS 'Doctor Name', 
                                              p.fname + ' ' + p.lname AS 'Patient Name',
                                              s.status AS 'Status'
                                              FROM[PremiereCareHospital].[dbo].Appointment a
                                              JOIN[PremiereCareHospital].[dbo].Doctor d
                                                  ON a.doc_id = d.doc_id
                                              JOIN[PremiereCareHospital].[dbo].Patient p
                                                  ON a.patient_id = p.patient_id
                                              JOIN[PremiereCareHospital].[dbo].Appointment_Status s
                                                  ON a.status_id = s.status_id
                                              WHERE
                                              ( a.appointment_id LIKE '%" + keyword +
                                              "%' OR  a.appointment_date LIKE '%" + keyword +
                                              "%' OR  d.fname + ' ' + d.lname LIKE '%" + keyword +
                                              "%' OR  p.fname + ' ' + p.lname LIKE '%" + keyword +
                                              "%' OR  s.status LIKE '%" + keyword +
                                             "%') ORDER BY a.appointment_date ";

            else if (userRole == "Doctor") qry = @"SELECT 
                                              a.appointment_id, 
                                              a.appointment_date, 
                                              d.fname + ' ' + d.lname AS 'Doctor Name', 
                                              p.fname + ' ' + p.lname AS 'Patient Name',
                                              s.status AS 'Status'
                                              FROM[PremiereCareHospital].[dbo].Appointment a
                                              JOIN[PremiereCareHospital].[dbo].Doctor d
                                                  ON a.doc_id = d.doc_id
                                              JOIN[PremiereCareHospital].[dbo].Patient p
                                                  ON a.patient_id = p.patient_id
                                              JOIN[PremiereCareHospital].[dbo].Appointment_Status s
                                                  ON a.status_id = s.status_id
                                              WHERE (d.doc_id = @userID AND 
                                               a.appointment_id LIKE '%" + keyword +
                                              "%' OR  a.appointment_date LIKE '%" + keyword +
                                              "%' OR  d.fname + ' ' + d.lname LIKE '%" + keyword +
                                              "%' OR  p.fname + ' ' + p.lname LIKE '%" + keyword +
                                              "%' OR  s.status LIKE '%" + keyword +
                                             "%')ORDER BY a.appointment_date; ";


            
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(qry, conn);
            if (userRole == "Doctor")
            {
                cmd.Parameters.AddWithValue("@userID", userID);
            }

            //Creating SQL DataAdapter using cmd
            SqlDataAdapter dtadapter = new SqlDataAdapter(cmd);
            conn.Open();
            dtadapter.Fill(dt);
            conn.Close();
            dgvAppointments.DataSource = dt;
        }
    }
}
