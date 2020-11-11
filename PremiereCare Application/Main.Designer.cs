namespace PremiereCare_Application
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelChildFormContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPrescriptions = new System.Windows.Forms.Button();
            this.panelNotesDropdown = new System.Windows.Forms.Panel();
            this.buttonViewNotes = new System.Windows.Forms.Button();
            this.buttonCreateNotes = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.panel_LabTestDropdown = new System.Windows.Forms.Panel();
            this.buttonViewLabTest = new System.Windows.Forms.Button();
            this.buttonRequestLabTest = new System.Windows.Forms.Button();
            this.buttonLabTest = new System.Windows.Forms.Button();
            this.buttonAppointments = new System.Windows.Forms.Button();
            this.panelDrugDropdown = new System.Windows.Forms.Panel();
            this.buttonEditDrug = new System.Windows.Forms.Button();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.buttonDrug = new System.Windows.Forms.Button();
            this.panelCSRDropdown = new System.Windows.Forms.Panel();
            this.buttonAddCSR = new System.Windows.Forms.Button();
            this.buttonCSR = new System.Windows.Forms.Button();
            this.panelTechnicianDropdown = new System.Windows.Forms.Panel();
            this.buttonAddTechnician = new System.Windows.Forms.Button();
            this.buttonTechnician = new System.Windows.Forms.Button();
            this.panelDoctorDropdown = new System.Windows.Forms.Panel();
            this.buttonAllDoctors = new System.Windows.Forms.Button();
            this.buttonAddDoctor = new System.Windows.Forms.Button();
            this.buttonDoctor = new System.Windows.Forms.Button();
            this.panelAppointmentDropdown = new System.Windows.Forms.Panel();
            this.buttonAllAppointments = new System.Windows.Forms.Button();
            this.buttonCreateAppointment = new System.Windows.Forms.Button();
            this.buttonAllDrugs = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelNotesDropdown.SuspendLayout();
            this.panel_LabTestDropdown.SuspendLayout();
            this.panelDrugDropdown.SuspendLayout();
            this.panelCSRDropdown.SuspendLayout();
            this.panelTechnicianDropdown.SuspendLayout();
            this.panelDoctorDropdown.SuspendLayout();
            this.panelAppointmentDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildFormContainer
            // 
            this.panelChildFormContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildFormContainer.BackColor = System.Drawing.Color.White;
            this.panelChildFormContainer.Location = new System.Drawing.Point(206, 0);
            this.panelChildFormContainer.Name = "panelChildFormContainer";
            this.panelChildFormContainer.Size = new System.Drawing.Size(655, 551);
            this.panelChildFormContainer.TabIndex = 2;
            this.panelChildFormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildFormContainer_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 551);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonPrescriptions);
            this.panel3.Controls.Add(this.panelNotesDropdown);
            this.panel3.Controls.Add(this.buttonNotes);
            this.panel3.Controls.Add(this.panel_LabTestDropdown);
            this.panel3.Controls.Add(this.buttonLabTest);
            this.panel3.Controls.Add(this.panelAppointmentDropdown);
            this.panel3.Controls.Add(this.buttonAppointments);
            this.panel3.Controls.Add(this.panelDrugDropdown);
            this.panel3.Controls.Add(this.buttonDrug);
            this.panel3.Controls.Add(this.panelCSRDropdown);
            this.panel3.Controls.Add(this.buttonCSR);
            this.panel3.Controls.Add(this.panelTechnicianDropdown);
            this.panel3.Controls.Add(this.buttonTechnician);
            this.panel3.Controls.Add(this.panelDoctorDropdown);
            this.panel3.Controls.Add(this.buttonDoctor);
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 963);
            this.panel3.TabIndex = 7;
            // 
            // buttonPrescriptions
            // 
            this.buttonPrescriptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrescriptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrescriptions.FlatAppearance.BorderSize = 0;
            this.buttonPrescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrescriptions.ForeColor = System.Drawing.Color.White;
            this.buttonPrescriptions.Location = new System.Drawing.Point(0, 727);
            this.buttonPrescriptions.Name = "buttonPrescriptions";
            this.buttonPrescriptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPrescriptions.Size = new System.Drawing.Size(200, 36);
            this.buttonPrescriptions.TabIndex = 21;
            this.buttonPrescriptions.Text = "Prescriptions";
            this.buttonPrescriptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrescriptions.UseVisualStyleBackColor = true;
            this.buttonPrescriptions.Click += new System.EventHandler(this.buttonPrescriptions_Click);
            // 
            // panelNotesDropdown
            // 
            this.panelNotesDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelNotesDropdown.Controls.Add(this.buttonViewNotes);
            this.panelNotesDropdown.Controls.Add(this.buttonCreateNotes);
            this.panelNotesDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNotesDropdown.Location = new System.Drawing.Point(0, 655);
            this.panelNotesDropdown.Name = "panelNotesDropdown";
            this.panelNotesDropdown.Size = new System.Drawing.Size(200, 72);
            this.panelNotesDropdown.TabIndex = 13;
            // 
            // buttonViewNotes
            // 
            this.buttonViewNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViewNotes.FlatAppearance.BorderSize = 0;
            this.buttonViewNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewNotes.ForeColor = System.Drawing.Color.White;
            this.buttonViewNotes.Location = new System.Drawing.Point(0, 36);
            this.buttonViewNotes.Name = "buttonViewNotes";
            this.buttonViewNotes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonViewNotes.Size = new System.Drawing.Size(200, 36);
            this.buttonViewNotes.TabIndex = 22;
            this.buttonViewNotes.Text = "View Notes";
            this.buttonViewNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewNotes.UseVisualStyleBackColor = true;
            this.buttonViewNotes.Click += new System.EventHandler(this.buttonViewNotes_Click);
            // 
            // buttonCreateNotes
            // 
            this.buttonCreateNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateNotes.FlatAppearance.BorderSize = 0;
            this.buttonCreateNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNotes.ForeColor = System.Drawing.Color.White;
            this.buttonCreateNotes.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateNotes.Name = "buttonCreateNotes";
            this.buttonCreateNotes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonCreateNotes.Size = new System.Drawing.Size(200, 36);
            this.buttonCreateNotes.TabIndex = 21;
            this.buttonCreateNotes.Text = "Create Notes";
            this.buttonCreateNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateNotes.UseVisualStyleBackColor = true;
            this.buttonCreateNotes.Click += new System.EventHandler(this.buttonCreateNotes_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotes.FlatAppearance.BorderSize = 0;
            this.buttonNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotes.ForeColor = System.Drawing.Color.White;
            this.buttonNotes.Location = new System.Drawing.Point(0, 619);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonNotes.Size = new System.Drawing.Size(200, 36);
            this.buttonNotes.TabIndex = 19;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // panel_LabTestDropdown
            // 
            this.panel_LabTestDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panel_LabTestDropdown.Controls.Add(this.buttonViewLabTest);
            this.panel_LabTestDropdown.Controls.Add(this.buttonRequestLabTest);
            this.panel_LabTestDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LabTestDropdown.Location = new System.Drawing.Point(0, 547);
            this.panel_LabTestDropdown.Name = "panel_LabTestDropdown";
            this.panel_LabTestDropdown.Size = new System.Drawing.Size(200, 72);
            this.panel_LabTestDropdown.TabIndex = 13;
            // 
            // buttonViewLabTest
            // 
            this.buttonViewLabTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewLabTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViewLabTest.FlatAppearance.BorderSize = 0;
            this.buttonViewLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewLabTest.ForeColor = System.Drawing.Color.White;
            this.buttonViewLabTest.Location = new System.Drawing.Point(0, 36);
            this.buttonViewLabTest.Name = "buttonViewLabTest";
            this.buttonViewLabTest.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonViewLabTest.Size = new System.Drawing.Size(200, 36);
            this.buttonViewLabTest.TabIndex = 20;
            this.buttonViewLabTest.Text = "View Lab Test";
            this.buttonViewLabTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewLabTest.UseVisualStyleBackColor = true;
            this.buttonViewLabTest.Click += new System.EventHandler(this.buttonViewLabTest_Click_1);
            // 
            // buttonRequestLabTest
            // 
            this.buttonRequestLabTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRequestLabTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequestLabTest.FlatAppearance.BorderSize = 0;
            this.buttonRequestLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequestLabTest.ForeColor = System.Drawing.Color.White;
            this.buttonRequestLabTest.Location = new System.Drawing.Point(0, 0);
            this.buttonRequestLabTest.Name = "buttonRequestLabTest";
            this.buttonRequestLabTest.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonRequestLabTest.Size = new System.Drawing.Size(200, 36);
            this.buttonRequestLabTest.TabIndex = 19;
            this.buttonRequestLabTest.Text = "Request Lab Test";
            this.buttonRequestLabTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestLabTest.UseVisualStyleBackColor = true;
            this.buttonRequestLabTest.Click += new System.EventHandler(this.buttonRequestLabTest_Click_1);
            // 
            // buttonLabTest
            // 
            this.buttonLabTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLabTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLabTest.FlatAppearance.BorderSize = 0;
            this.buttonLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLabTest.ForeColor = System.Drawing.Color.White;
            this.buttonLabTest.Location = new System.Drawing.Point(0, 511);
            this.buttonLabTest.Name = "buttonLabTest";
            this.buttonLabTest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLabTest.Size = new System.Drawing.Size(200, 36);
            this.buttonLabTest.TabIndex = 18;
            this.buttonLabTest.Text = "Lab Test";
            this.buttonLabTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLabTest.UseVisualStyleBackColor = true;
            this.buttonLabTest.Click += new System.EventHandler(this.buttonLabTest_Click_1);
            // 
            // buttonAppointments
            // 
            this.buttonAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAppointments.FlatAppearance.BorderSize = 0;
            this.buttonAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppointments.ForeColor = System.Drawing.Color.White;
            this.buttonAppointments.Location = new System.Drawing.Point(0, 403);
            this.buttonAppointments.Name = "buttonAppointments";
            this.buttonAppointments.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAppointments.Size = new System.Drawing.Size(200, 36);
            this.buttonAppointments.TabIndex = 16;
            this.buttonAppointments.Text = "Appointments";
            this.buttonAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAppointments.UseVisualStyleBackColor = true;
            this.buttonAppointments.Click += new System.EventHandler(this.buttonAppointments_Click);
            // 
            // panelDrugDropdown
            // 
            this.panelDrugDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelDrugDropdown.Controls.Add(this.buttonEditDrug);
            this.panelDrugDropdown.Controls.Add(this.buttonAddDrug);
            this.panelDrugDropdown.Controls.Add(this.buttonAllDrugs);
            this.panelDrugDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrugDropdown.Location = new System.Drawing.Point(0, 291);
            this.panelDrugDropdown.Name = "panelDrugDropdown";
            this.panelDrugDropdown.Size = new System.Drawing.Size(200, 112);
            this.panelDrugDropdown.TabIndex = 12;
            // 
            // buttonEditDrug
            // 
            this.buttonEditDrug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonEditDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditDrug.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditDrug.FlatAppearance.BorderSize = 0;
            this.buttonEditDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDrug.ForeColor = System.Drawing.Color.White;
            this.buttonEditDrug.Location = new System.Drawing.Point(0, 72);
            this.buttonEditDrug.Name = "buttonEditDrug";
            this.buttonEditDrug.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonEditDrug.Size = new System.Drawing.Size(200, 36);
            this.buttonEditDrug.TabIndex = 10;
            this.buttonEditDrug.Text = "Edit Drug";
            this.buttonEditDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditDrug.UseVisualStyleBackColor = false;
            this.buttonEditDrug.Click += new System.EventHandler(this.buttonEditDrug_Click_1);
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAddDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddDrug.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddDrug.FlatAppearance.BorderSize = 0;
            this.buttonAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDrug.ForeColor = System.Drawing.Color.White;
            this.buttonAddDrug.Location = new System.Drawing.Point(0, 36);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddDrug.Size = new System.Drawing.Size(200, 36);
            this.buttonAddDrug.TabIndex = 9;
            this.buttonAddDrug.Text = "Add Drug";
            this.buttonAddDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDrug.UseVisualStyleBackColor = false;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // buttonDrug
            // 
            this.buttonDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDrug.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrug.FlatAppearance.BorderSize = 0;
            this.buttonDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrug.ForeColor = System.Drawing.Color.White;
            this.buttonDrug.Location = new System.Drawing.Point(0, 255);
            this.buttonDrug.Name = "buttonDrug";
            this.buttonDrug.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDrug.Size = new System.Drawing.Size(200, 36);
            this.buttonDrug.TabIndex = 11;
            this.buttonDrug.Text = "Drug";
            this.buttonDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrug.UseVisualStyleBackColor = true;
            this.buttonDrug.Click += new System.EventHandler(this.buttonDrug_Click);
            // 
            // panelCSRDropdown
            // 
            this.panelCSRDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelCSRDropdown.Controls.Add(this.buttonAddCSR);
            this.panelCSRDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCSRDropdown.Location = new System.Drawing.Point(0, 219);
            this.panelCSRDropdown.Name = "panelCSRDropdown";
            this.panelCSRDropdown.Size = new System.Drawing.Size(200, 36);
            this.panelCSRDropdown.TabIndex = 9;
            // 
            // buttonAddCSR
            // 
            this.buttonAddCSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAddCSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddCSR.FlatAppearance.BorderSize = 0;
            this.buttonAddCSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCSR.ForeColor = System.Drawing.Color.White;
            this.buttonAddCSR.Location = new System.Drawing.Point(0, 0);
            this.buttonAddCSR.Name = "buttonAddCSR";
            this.buttonAddCSR.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddCSR.Size = new System.Drawing.Size(200, 36);
            this.buttonAddCSR.TabIndex = 7;
            this.buttonAddCSR.Text = "Add CSR";
            this.buttonAddCSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCSR.UseVisualStyleBackColor = false;
            this.buttonAddCSR.Click += new System.EventHandler(this.buttonAddCSR_Click);
            // 
            // buttonCSR
            // 
            this.buttonCSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCSR.FlatAppearance.BorderSize = 0;
            this.buttonCSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSR.ForeColor = System.Drawing.Color.White;
            this.buttonCSR.Location = new System.Drawing.Point(0, 183);
            this.buttonCSR.Name = "buttonCSR";
            this.buttonCSR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCSR.Size = new System.Drawing.Size(200, 36);
            this.buttonCSR.TabIndex = 5;
            this.buttonCSR.Text = "CSR";
            this.buttonCSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCSR.UseVisualStyleBackColor = true;
            this.buttonCSR.Click += new System.EventHandler(this.buttonCSR_Click);
            // 
            // panelTechnicianDropdown
            // 
            this.panelTechnicianDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelTechnicianDropdown.Controls.Add(this.buttonAddTechnician);
            this.panelTechnicianDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTechnicianDropdown.Location = new System.Drawing.Point(0, 147);
            this.panelTechnicianDropdown.Name = "panelTechnicianDropdown";
            this.panelTechnicianDropdown.Size = new System.Drawing.Size(200, 36);
            this.panelTechnicianDropdown.TabIndex = 8;
            // 
            // buttonAddTechnician
            // 
            this.buttonAddTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAddTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTechnician.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTechnician.FlatAppearance.BorderSize = 0;
            this.buttonAddTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTechnician.ForeColor = System.Drawing.Color.White;
            this.buttonAddTechnician.Location = new System.Drawing.Point(0, 0);
            this.buttonAddTechnician.Name = "buttonAddTechnician";
            this.buttonAddTechnician.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddTechnician.Size = new System.Drawing.Size(200, 36);
            this.buttonAddTechnician.TabIndex = 7;
            this.buttonAddTechnician.Text = "Add Technician";
            this.buttonAddTechnician.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTechnician.UseVisualStyleBackColor = false;
            this.buttonAddTechnician.Click += new System.EventHandler(this.buttonAddTechnician_Click);
            // 
            // buttonTechnician
            // 
            this.buttonTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTechnician.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTechnician.FlatAppearance.BorderSize = 0;
            this.buttonTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTechnician.ForeColor = System.Drawing.Color.White;
            this.buttonTechnician.Location = new System.Drawing.Point(0, 111);
            this.buttonTechnician.Name = "buttonTechnician";
            this.buttonTechnician.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTechnician.Size = new System.Drawing.Size(200, 36);
            this.buttonTechnician.TabIndex = 4;
            this.buttonTechnician.Text = "Technician";
            this.buttonTechnician.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTechnician.UseVisualStyleBackColor = true;
            this.buttonTechnician.Click += new System.EventHandler(this.buttonTechnician_Click);
            // 
            // panelDoctorDropdown
            // 
            this.panelDoctorDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelDoctorDropdown.Controls.Add(this.buttonAllDoctors);
            this.panelDoctorDropdown.Controls.Add(this.buttonAddDoctor);
            this.panelDoctorDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorDropdown.Location = new System.Drawing.Point(0, 36);
            this.panelDoctorDropdown.Name = "panelDoctorDropdown";
            this.panelDoctorDropdown.Size = new System.Drawing.Size(200, 75);
            this.panelDoctorDropdown.TabIndex = 6;
            // 
            // buttonAllDoctors
            // 
            this.buttonAllDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAllDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllDoctors.FlatAppearance.BorderSize = 0;
            this.buttonAllDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllDoctors.ForeColor = System.Drawing.Color.White;
            this.buttonAllDoctors.Location = new System.Drawing.Point(0, 36);
            this.buttonAllDoctors.Name = "buttonAllDoctors";
            this.buttonAllDoctors.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAllDoctors.Size = new System.Drawing.Size(200, 39);
            this.buttonAllDoctors.TabIndex = 8;
            this.buttonAllDoctors.Text = "View Doctors";
            this.buttonAllDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllDoctors.UseVisualStyleBackColor = false;
            this.buttonAllDoctors.Click += new System.EventHandler(this.buttonAllDoctors_Click);
            // 
            // buttonAddDoctor
            // 
            this.buttonAddDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAddDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddDoctor.FlatAppearance.BorderSize = 0;
            this.buttonAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonAddDoctor.Location = new System.Drawing.Point(0, 0);
            this.buttonAddDoctor.Name = "buttonAddDoctor";
            this.buttonAddDoctor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddDoctor.Size = new System.Drawing.Size(200, 36);
            this.buttonAddDoctor.TabIndex = 7;
            this.buttonAddDoctor.Text = "Add Doctor";
            this.buttonAddDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDoctor.UseVisualStyleBackColor = false;
            this.buttonAddDoctor.Click += new System.EventHandler(this.buttonAddDoctor_Click);
            // 
            // buttonDoctor
            // 
            this.buttonDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDoctor.FlatAppearance.BorderSize = 0;
            this.buttonDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoctor.ForeColor = System.Drawing.Color.White;
            this.buttonDoctor.Location = new System.Drawing.Point(0, 0);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDoctor.Size = new System.Drawing.Size(200, 36);
            this.buttonDoctor.TabIndex = 3;
            this.buttonDoctor.Text = "Doctor";
            this.buttonDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoctor.UseVisualStyleBackColor = true;
            this.buttonDoctor.Click += new System.EventHandler(this.buttonDoctor_Click);
            // 
            // panelAppointmentDropdown
            // 
            this.panelAppointmentDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panelAppointmentDropdown.Controls.Add(this.buttonCreateAppointment);
            this.panelAppointmentDropdown.Controls.Add(this.buttonAllAppointments);
            this.panelAppointmentDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppointmentDropdown.Location = new System.Drawing.Point(0, 439);
            this.panelAppointmentDropdown.Name = "panelAppointmentDropdown";
            this.panelAppointmentDropdown.Size = new System.Drawing.Size(200, 72);
            this.panelAppointmentDropdown.TabIndex = 21;
            // 
            // buttonAllAppointments
            // 
            this.buttonAllAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllAppointments.FlatAppearance.BorderSize = 0;
            this.buttonAllAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllAppointments.ForeColor = System.Drawing.Color.White;
            this.buttonAllAppointments.Location = new System.Drawing.Point(0, 0);
            this.buttonAllAppointments.Name = "buttonAllAppointments";
            this.buttonAllAppointments.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAllAppointments.Size = new System.Drawing.Size(200, 36);
            this.buttonAllAppointments.TabIndex = 20;
            this.buttonAllAppointments.Text = "All Appointments";
            this.buttonAllAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllAppointments.UseVisualStyleBackColor = true;
            this.buttonAllAppointments.Click += new System.EventHandler(this.buttonAllAppointments_Click);
            // 
            // buttonCreateAppointment
            // 
            this.buttonCreateAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateAppointment.FlatAppearance.BorderSize = 0;
            this.buttonCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAppointment.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAppointment.Location = new System.Drawing.Point(0, 36);
            this.buttonCreateAppointment.Name = "buttonCreateAppointment";
            this.buttonCreateAppointment.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonCreateAppointment.Size = new System.Drawing.Size(200, 36);
            this.buttonCreateAppointment.TabIndex = 19;
            this.buttonCreateAppointment.Text = "Create Appointment";
            this.buttonCreateAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateAppointment.UseVisualStyleBackColor = true;
            this.buttonCreateAppointment.Click += new System.EventHandler(this.buttonCreateAppointment_Click);
            // 
            // buttonAllDrugs
            // 
            this.buttonAllDrugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.buttonAllDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllDrugs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAllDrugs.FlatAppearance.BorderSize = 0;
            this.buttonAllDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllDrugs.ForeColor = System.Drawing.Color.White;
            this.buttonAllDrugs.Location = new System.Drawing.Point(0, 0);
            this.buttonAllDrugs.Name = "buttonAllDrugs";
            this.buttonAllDrugs.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAllDrugs.Size = new System.Drawing.Size(200, 36);
            this.buttonAllDrugs.TabIndex = 11;
            this.buttonAllDrugs.Text = "All Drugs";
            this.buttonAllDrugs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllDrugs.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 551);
            this.Controls.Add(this.panelChildFormContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelNotesDropdown.ResumeLayout(false);
            this.panel_LabTestDropdown.ResumeLayout(false);
            this.panelDrugDropdown.ResumeLayout(false);
            this.panelCSRDropdown.ResumeLayout(false);
            this.panelTechnicianDropdown.ResumeLayout(false);
            this.panelDoctorDropdown.ResumeLayout(false);
            this.panelAppointmentDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChildFormContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDrugDropdown;
        private System.Windows.Forms.Button buttonDrug;
        private System.Windows.Forms.Panel panelCSRDropdown;
        private System.Windows.Forms.Button buttonAddCSR;
        private System.Windows.Forms.Button buttonCSR;
        private System.Windows.Forms.Panel panelTechnicianDropdown;
        private System.Windows.Forms.Button buttonAddTechnician;
        private System.Windows.Forms.Button buttonTechnician;
        private System.Windows.Forms.Panel panelDoctorDropdown;
        private System.Windows.Forms.Button buttonAllDoctors;
        private System.Windows.Forms.Button buttonAddDoctor;
        private System.Windows.Forms.Button buttonAppointments;
        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Panel panel_LabTestDropdown;
        private System.Windows.Forms.Button buttonViewLabTest;
        private System.Windows.Forms.Button buttonRequestLabTest;
        private System.Windows.Forms.Button buttonLabTest;
        private System.Windows.Forms.Panel panelNotesDropdown;
        private System.Windows.Forms.Button buttonViewNotes;
        private System.Windows.Forms.Button buttonCreateNotes;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonEditDrug;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.Button buttonPrescriptions;
        private System.Windows.Forms.Panel panelAppointmentDropdown;
        private System.Windows.Forms.Button buttonAllAppointments;
        private System.Windows.Forms.Button buttonCreateAppointment;
        private System.Windows.Forms.Button buttonAllDrugs;
    }
}