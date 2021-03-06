﻿namespace PremiereCare_Application
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
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelDoctorErr = new System.Windows.Forms.Label();
            this.labelDateErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDoctor
            // 
            this.labelDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(147, 75);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(46, 13);
            this.labelDoctor.TabIndex = 52;
            this.labelDoctor.Text = "Doctor *";
            // 
            // labelDoctorErr
            // 
            this.labelDoctorErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoctorErr.AutoSize = true;
            this.labelDoctorErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorErr.ForeColor = System.Drawing.Color.Red;
            this.labelDoctorErr.Location = new System.Drawing.Point(149, 113);
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
            this.labelDateErr.Location = new System.Drawing.Point(148, 181);
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
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
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
            this.labelDate.Location = new System.Drawing.Point(148, 143);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 13);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "Date *";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDatePicker.Location = new System.Drawing.Point(151, 159);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(294, 20);
            this.appointmentDatePicker.TabIndex = 71;
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDoctors.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxDoctors.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(150, 89);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(295, 21);
            this.comboBoxDoctors.TabIndex = 72;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(250, 491);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxDoctors);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.labelDoctor);
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
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelDoctorErr;
        private System.Windows.Forms.Label labelDateErr;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private System.Windows.Forms.Button buttonAdd;
    }
}