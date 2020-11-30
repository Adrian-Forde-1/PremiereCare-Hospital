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
            this.labelMain = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelDosageErr = new System.Windows.Forms.Label();
            this.labelDrugErr = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.checkedListBoxDrugs = new System.Windows.Forms.CheckedListBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.labelMain.Location = new System.Drawing.Point(223, 13);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(182, 33);
            this.labelMain.TabIndex = 49;
            this.labelMain.Text = "Prescription";
            this.labelMain.Resize += new System.EventHandler(this.labelMain_Resize);
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Location = new System.Drawing.Point(153, 153);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(44, 13);
            this.labelDosage.TabIndex = 51;
            this.labelDosage.Text = "Dosage";
            // 
            // labelDosageErr
            // 
            this.labelDosageErr.AutoSize = true;
            this.labelDosageErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.labelDosageErr.ForeColor = System.Drawing.Color.Red;
            this.labelDosageErr.Location = new System.Drawing.Point(153, 298);
            this.labelDosageErr.Name = "labelDosageErr";
            this.labelDosageErr.Size = new System.Drawing.Size(101, 12);
            this.labelDosageErr.TabIndex = 64;
            this.labelDosageErr.Text = "Please enter  a dosage  ";
            // 
            // labelDrugErr
            // 
            this.labelDrugErr.AutoSize = true;
            this.labelDrugErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.labelDrugErr.ForeColor = System.Drawing.Color.Red;
            this.labelDrugErr.Location = new System.Drawing.Point(154, 126);
            this.labelDrugErr.Name = "labelDrugErr";
            this.labelDrugErr.Size = new System.Drawing.Size(125, 12);
            this.labelDrugErr.TabIndex = 68;
            this.labelDrugErr.Text = "Must select at least one Drug";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(153, 92);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(42, 13);
            this.labelServices.TabIndex = 67;
            this.labelServices.Text = "Drugs *";
            // 
            // checkedListBoxDrugs
            // 
            this.checkedListBoxDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDrugs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkedListBoxDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxDrugs.CheckOnClick = true;
            this.checkedListBoxDrugs.FormattingEnabled = true;
            this.checkedListBoxDrugs.Location = new System.Drawing.Point(156, 108);
            this.checkedListBoxDrugs.Name = "checkedListBoxDrugs";
            this.checkedListBoxDrugs.ScrollAlwaysVisible = true;
            this.checkedListBoxDrugs.Size = new System.Drawing.Size(310, 15);
            this.checkedListBoxDrugs.TabIndex = 66;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDosage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDosage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDosage.Location = new System.Drawing.Point(156, 169);
            this.textBoxDosage.Multiline = true;
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(310, 126);
            this.textBoxDosage.TabIndex = 93;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(250, 489);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 94;
            this.buttonAdd.Text = "Prescribe";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PrescribeMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.labelDrugErr);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.checkedListBoxDrugs);
            this.Controls.Add(this.labelDosageErr);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrescribeMedication";
            this.Text = "PrescribeMedication";
            this.Load += new System.EventHandler(this.PrescribeMedication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelDosageErr;
        private System.Windows.Forms.Label labelDrugErr;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.CheckedListBox checkedListBoxDrugs;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.Button buttonAdd;
    }
}