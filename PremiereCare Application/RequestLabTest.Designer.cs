namespace PremiereCare_Application
{
    partial class RequestLabTest
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
            this.premiereCareHospitalDataSet = new PremiereCare_Application.PremiereCareHospitalDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelServiceErr = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.premiereCareHospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(171, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(260, 33);
            this.labelMain.TabIndex = 12;
            this.labelMain.Text = "Request Lab Test";
            // 
            // premiereCareHospitalDataSet
            // 
            this.premiereCareHospitalDataSet.DataSetName = "PremiereCareHospitalDataSet";
            this.premiereCareHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(250, 484);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Request";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelServiceErr
            // 
            this.labelServiceErr.AutoSize = true;
            this.labelServiceErr.ForeColor = System.Drawing.Color.DarkRed;
            this.labelServiceErr.Location = new System.Drawing.Point(174, 126);
            this.labelServiceErr.Name = "labelServiceErr";
            this.labelServiceErr.Size = new System.Drawing.Size(155, 13);
            this.labelServiceErr.TabIndex = 59;
            this.labelServiceErr.Text = "Must select atleast one Service";
            this.labelServiceErr.Click += new System.EventHandler(this.labelServiceErr_Click_1);
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(174, 88);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(55, 13);
            this.labelServices.TabIndex = 58;
            this.labelServices.Text = "Services *";
            // 
            // checkedListBoxServices
            // 
            this.checkedListBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxServices.CheckOnClick = true;
            this.checkedListBoxServices.FormattingEnabled = true;
            this.checkedListBoxServices.Location = new System.Drawing.Point(177, 104);
            this.checkedListBoxServices.Name = "checkedListBoxServices";
            this.checkedListBoxServices.ScrollAlwaysVisible = true;
            this.checkedListBoxServices.Size = new System.Drawing.Size(254, 19);
            this.checkedListBoxServices.TabIndex = 57;
            // 
            // RequestLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.labelServiceErr);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.checkedListBoxServices);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestLabTest";
            this.Text = "RequestLabTest";
            this.Load += new System.EventHandler(this.RequestLabTest_Load);
            this.Resize += new System.EventHandler(this.RequestLabTest_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.premiereCareHospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMain;
        private PremiereCareHospitalDataSet premiereCareHospitalDataSet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelServiceErr;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.CheckedListBox checkedListBoxServices;
    }
}