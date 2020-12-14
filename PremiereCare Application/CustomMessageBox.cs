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
        private bool mouseDown;
        private Point lastLocation;
        private Action callback;

        public CustomMessageBox(String customMessage, Form form)
        {
            InitializeComponent();

            labelCustomMessageBox.Text = customMessage;
            this.TopLevel = false;
            this.Parent = form;
            this.Location = new Point((Parent.ClientSize.Width - this.Width) / 2,
                          (Parent.ClientSize.Height - this.Height) / 2);
            this.BringToFront();
        }

        public CustomMessageBox(String customMessage, Form form, Action cb)
        {
            InitializeComponent();
            callback = cb;
            labelCustomMessageBox.Text = customMessage;
            this.TopLevel = false;
            this.Parent = form;
            this.Location = new Point((Parent.ClientSize.Width - this.Width) / 2,
                          (Parent.ClientSize.Height - this.Height) / 2);
            this.BringToFront();
        }

        private void buttonCloseMessageBox_Click(object sender, EventArgs e)
        {
            this.Hide();

            if(callback != null)
            {
                callback();
            }
        }

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void CustomMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
