namespace PremiereCare_Application
{
    partial class PrescribeMedication
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDrug = new System.Windows.Forms.Label();
            this.textBoxLabPrescriptionNo = new System.Windows.Forms.TextBox();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.textBoxRequestedBy = new System.Windows.Forms.TextBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.textBoxAppointment = new System.Windows.Forms.TextBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.comboBoxDrug = new System.Windows.Forms.ComboBox();
            this.comboBoxDosage = new System.Windows.Forms.ComboBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.labelPrescriptionNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(68, 227);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(30, 13);
            this.lblDrug.TabIndex = 47;
            this.lblDrug.Text = "Drug";
            // 
            // textBoxLabPrescriptionNo
            // 
            this.textBoxLabPrescriptionNo.Location = new System.Drawing.Point(20, 340);
            this.textBoxLabPrescriptionNo.Name = "textBoxLabPrescriptionNo";
            this.textBoxLabPrescriptionNo.Size = new System.Drawing.Size(127, 20);
            this.textBoxLabPrescriptionNo.TabIndex = 46;
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(46, 126);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(74, 13);
            this.lblRequestedBy.TabIndex = 45;
            this.lblRequestedBy.Text = "Requested By";
            // 
            // textBoxRequestedBy
            // 
            this.textBoxRequestedBy.Location = new System.Drawing.Point(20, 142);
            this.textBoxRequestedBy.Name = "textBoxRequestedBy";
            this.textBoxRequestedBy.Size = new System.Drawing.Size(127, 20);
            this.textBoxRequestedBy.TabIndex = 44;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(50, 74);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(66, 13);
            this.lblAppointment.TabIndex = 43;
            this.lblAppointment.Text = "Appointment";
            // 
            // textBoxAppointment
            // 
            this.textBoxAppointment.Location = new System.Drawing.Point(20, 90);
            this.textBoxAppointment.Name = "textBoxAppointment";
            this.textBoxAppointment.Size = new System.Drawing.Size(127, 20);
            this.textBoxAppointment.TabIndex = 42;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(63, 176);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 41;
            this.lblPatient.Text = "Patient";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(20, 192);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPatient.TabIndex = 40;
            // 
            // lblPrescription
            // 
            this.lblPrescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblPrescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.lblPrescription.Location = new System.Drawing.Point(228, 13);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(182, 33);
            this.lblPrescription.TabIndex = 49;
            this.lblPrescription.Text = "Prescription";
            // 
            // comboBoxDrug
            // 
            this.comboBoxDrug.FormattingEnabled = true;
            this.comboBoxDrug.Location = new System.Drawing.Point(20, 243);
            this.comboBoxDrug.Name = "comboBoxDrug";
            this.comboBoxDrug.Size = new System.Drawing.Size(127, 21);
            this.comboBoxDrug.TabIndex = 50;
            // 
            // comboBoxDosage
            // 
            this.comboBoxDosage.FormattingEnabled = true;
            this.comboBoxDosage.Location = new System.Drawing.Point(20, 293);
            this.comboBoxDosage.Name = "comboBoxDosage";
            this.comboBoxDosage.Size = new System.Drawing.Size(127, 21);
            this.comboBoxDosage.TabIndex = 52;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(61, 277);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(44, 13);
            this.lblDosage.TabIndex = 51;
            this.lblDosage.Text = "Dosage";
            // 
            // labelPrescriptionNo
            // 
            this.labelPrescriptionNo.AutoSize = true;
            this.labelPrescriptionNo.Location = new System.Drawing.Point(42, 324);
            this.labelPrescriptionNo.Name = "labelPrescriptionNo";
            this.labelPrescriptionNo.Size = new System.Drawing.Size(82, 13);
            this.labelPrescriptionNo.TabIndex = 53;
            this.labelPrescriptionNo.Text = "Prescription .No";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.button1.Location = new System.Drawing.Point(49, 448);
            this.button1.MaximumSize = new System.Drawing.Size(125, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 57;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancle.AutoSize = true;
            this.buttonCancle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancle.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonCancle.Location = new System.Drawing.Point(355, 448);
            this.buttonCancle.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(66, 26);
            this.buttonCancle.TabIndex = 60;
            this.buttonCancle.Text = "Cancel";
            this.buttonCancle.UseVisualStyleBackColor = false;
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.AutoSize = true;
            this.buttonChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChange.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonChange.Location = new System.Drawing.Point(263, 448);
            this.buttonChange.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(71, 26);
            this.buttonChange.TabIndex = 59;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonSearch.Location = new System.Drawing.Point(177, 448);
            this.buttonSearch.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(67, 26);
            this.buttonSearch.TabIndex = 58;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // PrescribeMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrescriptionNo);
            this.Controls.Add(this.comboBoxDosage);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.comboBoxDrug);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.textBoxLabPrescriptionNo);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.textBoxRequestedBy);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.textBoxAppointment);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrescribeMedication";
            this.Text = "PrescribeMedication";
            this.Load += new System.EventHandler(this.PrescribeMedication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.TextBox textBoxLabPrescriptionNo;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.TextBox textBoxRequestedBy;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.TextBox textBoxAppointment;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.ComboBox comboBoxDrug;
        private System.Windows.Forms.ComboBox comboBoxDosage;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label labelPrescriptionNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSearch;
    }
}