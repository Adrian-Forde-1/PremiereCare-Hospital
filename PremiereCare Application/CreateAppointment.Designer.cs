namespace PremiereCare_Application
{
    partial class CreateAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.labelPatientErr = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.labelDoctorErr = new System.Windows.Forms.Label();
            this.labelDateErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelPatient
            // 
            this.labelPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(152, 127);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(47, 13);
            this.labelPatient.TabIndex = 53;
            this.labelPatient.Text = "Patient *";
            // 
            // labelDoctor
            // 
            this.labelDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(151, 69);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(46, 13);
            this.labelDoctor.TabIndex = 52;
            this.labelDoctor.Text = "Doctor *";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.ForeColor = System.Drawing.Color.Black;
            this.textBoxLname.Location = new System.Drawing.Point(155, 143);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(294, 19);
            this.textBoxLname.TabIndex = 47;
            // 
            // labelPatientErr
            // 
            this.labelPatientErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatientErr.AutoSize = true;
            this.labelPatientErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientErr.ForeColor = System.Drawing.Color.Red;
            this.labelPatientErr.Location = new System.Drawing.Point(153, 165);
            this.labelPatientErr.Name = "labelPatientErr";
            this.labelPatientErr.Size = new System.Drawing.Size(95, 12);
            this.labelPatientErr.TabIndex = 63;
            this.labelPatientErr.Text = "Field cannot be empty";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.ForeColor = System.Drawing.Color.Black;
            this.textBoxFname.Location = new System.Drawing.Point(153, 85);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(296, 19);
            this.textBoxFname.TabIndex = 46;
            // 
            // labelDoctorErr
            // 
            this.labelDoctorErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoctorErr.AutoSize = true;
            this.labelDoctorErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorErr.ForeColor = System.Drawing.Color.Red;
            this.labelDoctorErr.Location = new System.Drawing.Point(153, 107);
            this.labelDoctorErr.Name = "labelDoctorErr";
            this.labelDoctorErr.Size = new System.Drawing.Size(95, 12);
            this.labelDoctorErr.TabIndex = 62;
            this.labelDoctorErr.Text = "Field cannot be empty";
            // 
            // labelDateErr
            // 
            this.labelDateErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateErr.AutoSize = true;
            this.labelDateErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateErr.ForeColor = System.Drawing.Color.Red;
            this.labelDateErr.Location = new System.Drawing.Point(152, 223);
            this.labelDateErr.Name = "labelDateErr";
            this.labelDateErr.Size = new System.Drawing.Size(95, 12);
            this.labelDateErr.TabIndex = 64;
            this.labelDateErr.Text = "Field cannot be empty";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(156, 11);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(291, 33);
            this.labelMain.TabIndex = 61;
            this.labelMain.Text = "Create Appointment";
            this.labelMain.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(152, 185);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 13);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "Date *";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonCreate.FlatAppearance.BorderSize = 0;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCreate.Location = new System.Drawing.Point(250, 495);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 38);
            this.buttonCreate.TabIndex = 70;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Visible = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(155, 201);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(294, 20);
            this.appointmentDatePicker.TabIndex = 71;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelPatient);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.labelPatientErr);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelDoctorErr);
            this.Controls.Add(this.labelDateErr);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAppointment";
            this.Text = "CreateAppointment";
            this.Load += new System.EventHandler(this.CreateAppointment_Load);
            this.Resize += new System.EventHandler(this.CreateAppointment_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label labelPatientErr;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label labelDoctorErr;
        private System.Windows.Forms.Label labelDateErr;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
    }
}