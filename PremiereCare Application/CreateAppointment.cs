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
        private int userID;
        private int patientID;
        List<DataRow> doctors = new List<DataRow>();
        List<Object> doctorNames = new List<Object>();

        User.Doctor doctor = new User.Doctor();
        Appointment.Appointment appointment = new Appointment.Appointment();

        public CreateAppointment()
        {
            InitializeComponent();
        }

        public CreateAppointment(int usrId, int pID)
        {
            InitializeComponent();
            userID = usrId;
            patientID = pID;
        }

        private void AlignItems()
        {
            buttonCreate.Location = new Point((this.ClientSize.Width - buttonCreate.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }
        private void removeErrors()
        {
            labelDoctorErr.Visible = false;
            labelDateErr.Visible = false;
        }

        private void ClearFields()
        {
            comboBoxDoctors.Text = "";
            appointmentDatePicker.Value = DateTime.Now;
        }

        private void PopulateComboBox()
        {
            DataTable dt = doctor.GetAllDoctors();
            foreach (DataRow row in dt.Rows)
            {
                doctors.Add(row);
                doctorNames.Add(row["fname"] + " " + row["lname"]);
            }
            comboBoxDoctors.DataSource = doctorNames;
        }

        private void CreateAppointment_Load(object sender, EventArgs e)
        {
            removeErrors();
            PopulateComboBox();
            AlignItems();
            buttonCreate.Visible = true;
            labelMain.Visible = true;
            //textBoxFname.Text = userID;
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
            bool failedVerification = false;

            removeErrors();

            if (comboBoxDoctors.Text == "")
            {
                labelDoctorErr.Visible = true;
                failedVerification = true;
            }

            if (appointmentDatePicker.Text == "")
            {
                labelDateErr.Visible = true;
                failedVerification = true;
            }

            if (!failedVerification)
            {
                addAppointment();
            }
        }

        public void addAppointment()
        {
            int docLocation = Convert.ToInt32(comboBoxDoctors.SelectedIndex);
            DataRow selectedDoctor = doctors[docLocation];
            int docID = Convert.ToInt32(selectedDoctor["doc_id"]);
            String appointmentDate = appointmentDatePicker.Value.Date.ToShortDateString();
            appointment.docId = docID;
            appointment.csrId = userID;
            appointment.patientId = patientID;
            appointment.appointmentDate = appointmentDate;

            bool success = appointment.CreateAppointment(appointment, this);

            if (success == true)
            {
                CustomMessageBox cm = new CustomMessageBox("Successfully Created Appointment", this);
                removeErrors();
                ClearFields();
                cm.Show();
            }
        }
    }
}
