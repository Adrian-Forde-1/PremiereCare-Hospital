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
            this.lblDrug = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.chkListBoxDrug = new System.Windows.Forms.CheckedListBox();
            this.labelDrugErr = new System.Windows.Forms.Label();
            this.labelDosageErr = new System.Windows.Forms.Label();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(298, 93);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(30, 13);
            this.lblDrug.TabIndex = 47;
            this.lblDrug.Text = "Drug";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(222, 13);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(182, 33);
            this.labelMain.TabIndex = 49;
            this.labelMain.Text = "Prescription";
            this.labelMain.Resize += new System.EventHandler(this.labelMain_Resize);
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Location = new System.Drawing.Point(291, 322);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(44, 13);
            this.labelDosage.TabIndex = 51;
            this.labelDosage.Text = "Dosage";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonAdd.Location = new System.Drawing.Point(281, 445);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 26);
            this.buttonAdd.TabIndex = 57;
            this.buttonAdd.Text = "Create";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // chkListBoxDrug
            // 
            this.chkListBoxDrug.FormattingEnabled = true;
            this.chkListBoxDrug.Location = new System.Drawing.Point(250, 115);
            this.chkListBoxDrug.Name = "chkListBoxDrug";
            this.chkListBoxDrug.Size = new System.Drawing.Size(127, 169);
            this.chkListBoxDrug.TabIndex = 61;
            // 
            // labelDrugErr
            // 
            this.labelDrugErr.AutoSize = true;
            this.labelDrugErr.ForeColor = System.Drawing.Color.Red;
            this.labelDrugErr.Location = new System.Drawing.Point(255, 288);
            this.labelDrugErr.Name = "labelDrugErr";
            this.labelDrugErr.Size = new System.Drawing.Size(117, 13);
            this.labelDrugErr.TabIndex = 63;
            this.labelDrugErr.Text = "Please select a  Drug!  ";
            // 
            // labelDosageErr
            // 
            this.labelDosageErr.AutoSize = true;
            this.labelDosageErr.ForeColor = System.Drawing.Color.Red;
            this.labelDosageErr.Location = new System.Drawing.Point(249, 362);
            this.labelDosageErr.Name = "labelDosageErr";
            this.labelDosageErr.Size = new System.Drawing.Size(125, 13);
            this.labelDosageErr.TabIndex = 64;
            this.labelDosageErr.Text = "Please enter  a dosage!  ";
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(250, 339);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(128, 20);
            this.textBoxDosage.TabIndex = 65;
            // 
            // PrescribeMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.labelDosageErr);
            this.Controls.Add(this.labelDrugErr);
            this.Controls.Add(this.chkListBoxDrug);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.lblDrug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrescribeMedication";
            this.Text = "PrescribeMedication";
            this.Load += new System.EventHandler(this.PrescribeMedication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckedListBox chkListBoxDrug;
        private System.Windows.Forms.Label labelDrugErr;
        private System.Windows.Forms.Label labelDosageErr;
        private System.Windows.Forms.TextBox textBoxDosage;
    }
}