namespace PremiereCare_Application
{
    partial class CreateVisitNote
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelDateErr = new System.Windows.Forms.Label();
            this.labelNoteErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.noteDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(250, 486);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 91;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(145, 234);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 13);
            this.labelDate.TabIndex = 88;
            this.labelDate.Text = "Date *";
            // 
            // labelNote
            // 
            this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(145, 62);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(37, 13);
            this.labelNote.TabIndex = 87;
            this.labelNote.Text = "Note *";
            // 
            // labelDateErr
            // 
            this.labelDateErr.AutoSize = true;
            this.labelDateErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateErr.ForeColor = System.Drawing.Color.Red;
            this.labelDateErr.Location = new System.Drawing.Point(146, 272);
            this.labelDateErr.Name = "labelDateErr";
            this.labelDateErr.Size = new System.Drawing.Size(95, 12);
            this.labelDateErr.TabIndex = 90;
            this.labelDateErr.Text = "Field cannot be empty";
            // 
            // labelNoteErr
            // 
            this.labelNoteErr.AutoSize = true;
            this.labelNoteErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteErr.ForeColor = System.Drawing.Color.Red;
            this.labelNoteErr.Location = new System.Drawing.Point(146, 207);
            this.labelNoteErr.Name = "labelNoteErr";
            this.labelNoteErr.Size = new System.Drawing.Size(95, 12);
            this.labelNoteErr.TabIndex = 89;
            this.labelNoteErr.Text = "Field cannot be empty";
            this.labelNoteErr.Click += new System.EventHandler(this.labelFNameErr_Click);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(171, 19);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(252, 33);
            this.labelMain.TabIndex = 79;
            this.labelMain.Text = "Create Visit Note";
            this.labelMain.Visible = false;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNote.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNote.Location = new System.Drawing.Point(148, 78);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(310, 126);
            this.textBoxNote.TabIndex = 92;
            // 
            // noteDate
            // 
            this.noteDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteDate.Location = new System.Drawing.Point(148, 251);
            this.noteDate.Name = "noteDate";
            this.noteDate.Size = new System.Drawing.Size(310, 20);
            this.noteDate.TabIndex = 93;
            // 
            // CreateVisitNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.noteDate);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelDateErr);
            this.Controls.Add(this.labelNoteErr);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateVisitNote";
            this.Text = "CreateVisitNote";
            this.Load += new System.EventHandler(this.CreateVisitNote_Load);
            this.Resize += new System.EventHandler(this.CreateVisitNote_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelDateErr;
        private System.Windows.Forms.Label labelNoteErr;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.DateTimePicker noteDate;
    }
}