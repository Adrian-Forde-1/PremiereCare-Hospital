namespace PremiereCare_Application
{
    partial class CreateNotes
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
            this.buttnRecordNotes = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.dateTimePickerNote = new System.Windows.Forms.DateTimePicker();
            this.textBoxAppointment_ID = new System.Windows.Forms.TextBox();
            this.textBoxDoc_ID = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblCreateNotes = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtBoxPatient = new System.Windows.Forms.TextBox();
            this.dataGridViewCreateNote = new System.Windows.Forms.DataGridView();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelNoteErr = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateNote)).BeginInit();
            this.SuspendLayout();
            // 
            // buttnRecordNotes
            // 
            this.buttnRecordNotes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttnRecordNotes.AutoSize = true;
            this.buttnRecordNotes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttnRecordNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttnRecordNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttnRecordNotes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttnRecordNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttnRecordNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttnRecordNotes.Location = new System.Drawing.Point(200, 455);
            this.buttnRecordNotes.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttnRecordNotes.Name = "buttnRecordNotes";
            this.buttnRecordNotes.Size = new System.Drawing.Size(114, 26);
            this.buttnRecordNotes.TabIndex = 0;
            this.buttnRecordNotes.Text = "Record Notes";
            this.buttnRecordNotes.UseVisualStyleBackColor = false;
            this.buttnRecordNotes.Click += new System.EventHandler(this.buttnRecordNotes_Click);
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
            this.labelNote.TabIndex = 3;
            this.labelNote.Text = "Note";
            // 
            // dateTimePickerNote
            // 
            this.dateTimePickerNote.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNote.Location = new System.Drawing.Point(21, 85);
            this.dateTimePickerNote.Name = "dateTimePickerNote";
            this.dateTimePickerNote.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerNote.TabIndex = 4;
            // 
            // textBoxAppointment_ID
            // 
            this.textBoxAppointment_ID.Location = new System.Drawing.Point(21, 135);
            this.textBoxAppointment_ID.Name = "textBoxAppointment_ID";
            this.textBoxAppointment_ID.Size = new System.Drawing.Size(127, 20);
            this.textBoxAppointment_ID.TabIndex = 5;
            // 
            // textBoxDoc_ID
            // 
            this.textBoxDoc_ID.Location = new System.Drawing.Point(21, 184);
            this.textBoxDoc_ID.Name = "textBoxDoc_ID";
            this.textBoxDoc_ID.Size = new System.Drawing.Size(127, 20);
            this.textBoxDoc_ID.TabIndex = 6;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(18, 167);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 7;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(18, 68);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Location = new System.Drawing.Point(18, 118);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(66, 13);
            this.lblAppointment.TabIndex = 9;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblCreateNotes
            // 
            this.lblCreateNotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreateNotes.AutoSize = true;
            this.lblCreateNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblCreateNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.lblCreateNotes.Location = new System.Drawing.Point(212, 9);
            this.lblCreateNotes.Name = "lblCreateNotes";
            this.lblCreateNotes.Size = new System.Drawing.Size(198, 33);
            this.lblCreateNotes.TabIndex = 10;
            this.lblCreateNotes.Text = "Create Notes";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(18, 217);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 12;
            this.lblPatient.Text = "Patient";
            // 
            // txtBoxPatient
            // 
            this.txtBoxPatient.Location = new System.Drawing.Point(21, 234);
            this.txtBoxPatient.Name = "txtBoxPatient";
            this.txtBoxPatient.Size = new System.Drawing.Size(127, 20);
            this.txtBoxPatient.TabIndex = 11;
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
            this.dataGridViewCreateNote.TabIndex = 13;
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNote.Location = new System.Drawing.Point(21, 284);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(239, 126);
            this.txtBoxNote.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(342, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(136, 20);
            this.textBoxSearch.TabIndex = 25;
            // 
            // labelNoteErr
            // 
            this.labelNoteErr.AutoSize = true;
            this.labelNoteErr.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoteErr.Location = new System.Drawing.Point(18, 422);
            this.labelNoteErr.Name = "labelNoteErr";
            this.labelNoteErr.Size = new System.Drawing.Size(233, 13);
            this.labelNoteErr.TabIndex = 14;
            this.labelNoteErr.Text = "Error!! Please make sure all fields are populated.";
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
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // CreateNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.labelNoteErr);
            this.Controls.Add(this.dataGridViewCreateNote);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.txtBoxPatient);
            this.Controls.Add(this.lblCreateNotes);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.textBoxDoc_ID);
            this.Controls.Add(this.textBoxAppointment_ID);
            this.Controls.Add(this.dateTimePickerNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttnRecordNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNotes";
            this.Text = "CreateNotes";
            this.Load += new System.EventHandler(this.CreateNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreateNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttnRecordNotes;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerNote;
        private System.Windows.Forms.TextBox textBoxAppointment_ID;
        private System.Windows.Forms.TextBox textBoxDoc_ID;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblCreateNotes;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtBoxPatient;
        private System.Windows.Forms.DataGridView dataGridViewCreateNote;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelNoteErr;
        private System.Windows.Forms.Button buttonClear;
    }
}