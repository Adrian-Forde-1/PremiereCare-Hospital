namespace PremiereCare_Application
{
    partial class ViewNotes
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
            this.lblViewNotes = new System.Windows.Forms.Label();
            this.buttnViewNotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.dataGridViewCreateNote = new System.Windows.Forms.DataGridView();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtBoxPatient = new System.Windows.Forms.TextBox();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.textBoxDoc_ID = new System.Windows.Forms.TextBox();
            this.textBoxAppointment_ID = new System.Windows.Forms.TextBox();
            this.dateTimePickerNote = new System.Windows.Forms.DateTimePicker();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateNote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewNotes
            // 
            this.lblViewNotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblViewNotes.AutoSize = true;
            this.lblViewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblViewNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lblViewNotes.Location = new System.Drawing.Point(242, 9);
            this.lblViewNotes.Name = "lblViewNotes";
            this.lblViewNotes.Size = new System.Drawing.Size(172, 33);
            this.lblViewNotes.TabIndex = 8;
            this.lblViewNotes.Text = "View Notes";
            // 
            // buttnViewNotes
            // 
            this.buttnViewNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttnViewNotes.AutoSize = true;
            this.buttnViewNotes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttnViewNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttnViewNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttnViewNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttnViewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttnViewNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttnViewNotes.Location = new System.Drawing.Point(217, 455);
            this.buttnViewNotes.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttnViewNotes.Name = "buttnViewNotes";
            this.buttnViewNotes.Size = new System.Drawing.Size(96, 26);
            this.buttnViewNotes.TabIndex = 9;
            this.buttnViewNotes.Text = "View Notes";
            this.buttnViewNotes.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(342, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(136, 20);
            this.textBoxSearch.TabIndex = 39;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNote.Location = new System.Drawing.Point(21, 284);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(239, 126);
            this.txtBoxNote.TabIndex = 38;
            // 
            // dataGridViewCreateNote
            // 
            this.dataGridViewCreateNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCreateNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreateNote.Location = new System.Drawing.Point(284, 113);
            this.dataGridViewCreateNote.Name = "dataGridViewCreateNote";
            this.dataGridViewCreateNote.Size = new System.Drawing.Size(354, 297);
            this.dataGridViewCreateNote.TabIndex = 36;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(18, 217);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 35;
            this.lblPatient.Text = "Patient";
            // 
            // txtBoxPatient
            // 
            this.txtBoxPatient.Location = new System.Drawing.Point(21, 234);
            this.txtBoxPatient.Name = "txtBoxPatient";
            this.txtBoxPatient.Size = new System.Drawing.Size(127, 20);
            this.txtBoxPatient.TabIndex = 34;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(18, 118);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(66, 13);
            this.lblAppointment.TabIndex = 33;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Date";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(18, 167);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 13);
            this.lblDoctor.TabIndex = 31;
            this.lblDoctor.Text = "Create By";
            // 
            // textBoxDoc_ID
            // 
            this.textBoxDoc_ID.Location = new System.Drawing.Point(21, 184);
            this.textBoxDoc_ID.Name = "textBoxDoc_ID";
            this.textBoxDoc_ID.Size = new System.Drawing.Size(127, 20);
            this.textBoxDoc_ID.TabIndex = 30;
            // 
            // textBoxAppointment_ID
            // 
            this.textBoxAppointment_ID.Location = new System.Drawing.Point(21, 135);
            this.textBoxAppointment_ID.Name = "textBoxAppointment_ID";
            this.textBoxAppointment_ID.Size = new System.Drawing.Size(127, 20);
            this.textBoxAppointment_ID.TabIndex = 29;
            // 
            // dateTimePickerNote
            // 
            this.dateTimePickerNote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNote.Location = new System.Drawing.Point(21, 85);
            this.dateTimePickerNote.Name = "dateTimePickerNote";
            this.dateTimePickerNote.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerNote.TabIndex = 28;
            // 
            // labelNote
            // 
            this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(18, 268);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 27;
            this.labelNote.Text = "Note";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonClear.Location = new System.Drawing.Point(330, 455);
            this.buttonClear.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(55, 26);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // ViewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.dataGridViewCreateNote);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtBoxPatient);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.textBoxDoc_ID);
            this.Controls.Add(this.textBoxAppointment_ID);
            this.Controls.Add(this.dateTimePickerNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttnViewNotes);
            this.Controls.Add(this.lblViewNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewNotes";
            this.Text = "ViewNotes";
            this.Load += new System.EventHandler(this.ViewNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblViewNotes;
        private System.Windows.Forms.Button buttnViewNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.DataGridView dataGridViewCreateNote;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtBoxPatient;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox textBoxDoc_ID;
        private System.Windows.Forms.TextBox textBoxAppointment_ID;
        private System.Windows.Forms.DateTimePicker dateTimePickerNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonClear;
    }
}