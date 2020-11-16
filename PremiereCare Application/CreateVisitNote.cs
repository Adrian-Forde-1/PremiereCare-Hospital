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
    public partial class CreateVisitNote : Form
    {

        private int docID;
        private int appointmentID;
        public CreateVisitNote(int dID, int appID)
        {
            InitializeComponent();
            docID = dID;
            appointmentID = appID;
        }

        private void removeErrors()
        {
            labelNoteErr.Visible = false;
            labelDateErr.Visible = false;
        }

        private void ClearField()
        {
            textBoxNote.Text = "";
            noteDate.Value = DateTime.Now;
        }
        private void AlignItems()
        {
            buttonAdd.Location = new Point((this.ClientSize.Width - buttonAdd.Width) / 2, this.ClientSize.Height - 50);
            labelMain.Location = new Point((this.ClientSize.Width - labelMain.Width) / 2, 20);
        }



        private void labelFNameErr_Click(object sender, EventArgs e)
        {

        }

        private void CreateVisitNote_Load(object sender, EventArgs e)
        {
            removeErrors();
            AlignItems();
            buttonAdd.Visible = true;
            labelMain.Visible = true;
        }

        private void CreateVisitNote_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }
    }
}
