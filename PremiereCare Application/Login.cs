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
    public partial class Login : Form
    {

        static private string myconnstring = ConfigurationManager.ConnectionStrings["PCHospitalConnStr"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelIncorrectCredentials.Visible = false;
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            String loginRole = comboBoxLoginRole.Text;

            DataTable dt = new DataTable();

            String query;

            if (loginRole == "CSR") query = "SELECT * FROM CSR WHERE username = '" + username + "' AND password = '" + password + "'";
            else if (loginRole == "Doctor") query = "SELECT * FROM Doctor WHERE username = '" + username + "' AND password = '" + password + "'";
            else query = "SELECT * FROM Technician WHERE username = '" + username + "' AND password = '" + password + "'";

            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                String userRole = dt.Rows[0]["role"].ToString();
                this.Hide();
                Main main = new Main(userRole);
                main.Show();
            }
            else
            {
                //MessageBox.Show("Invalid Username and/or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelIncorrectCredentials.Visible = true;
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            labelIncorrectCredentials.Visible = false;
        }

        private void buttonCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
