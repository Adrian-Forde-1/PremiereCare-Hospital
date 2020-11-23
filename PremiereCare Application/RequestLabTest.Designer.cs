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
            this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
            this.labelServices = new System.Windows.Forms.Label();
            this.labelServiceErr = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.premiereCareHospitalDataSet = new PremiereCare_Application.PremiereCareHospitalDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.premiereCareHospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(202, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(260, 33);
            this.labelMain.TabIndex = 12;
            this.labelMain.Text = "Request Lab Test";
            // 
            // checkedListBoxServices
            // 
            this.checkedListBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxServices.CheckOnClick = true;
            this.checkedListBoxServices.FormattingEnabled = true;
            this.checkedListBoxServices.Location = new System.Drawing.Point(263, 101);
            this.checkedListBoxServices.Name = "checkedListBoxServices";
            this.checkedListBoxServices.ScrollAlwaysVisible = true;
            this.checkedListBoxServices.Size = new System.Drawing.Size(155, 289);
            this.checkedListBoxServices.TabIndex = 24;
            this.checkedListBoxServices.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxServices_SelectedIndexChanged);
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(260, 85);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(55, 13);
            this.labelServices.TabIndex = 25;
            this.labelServices.Text = "Services *";
            // 
            // labelServiceErr
            // 
            this.labelServiceErr.AutoSize = true;
            this.labelServiceErr.ForeColor = System.Drawing.Color.DarkRed;
            this.labelServiceErr.Location = new System.Drawing.Point(260, 404);
            this.labelServiceErr.Name = "labelServiceErr";
            this.labelServiceErr.Size = new System.Drawing.Size(155, 13);
            this.labelServiceErr.TabIndex = 26;
            this.labelServiceErr.Text = "Must select atleast one Service";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonAdd.Location = new System.Drawing.Point(291, 436);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(125, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 26);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Request ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // premiereCareHospitalDataSet
            // 
            this.premiereCareHospitalDataSet.DataSetName = "PremiereCareHospitalDataSet";
            this.premiereCareHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RequestLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelServiceErr);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.checkedListBoxServices);
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
        private System.Windows.Forms.CheckedListBox checkedListBoxServices;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelServiceErr;
        private System.Windows.Forms.Button buttonAdd;
        private PremiereCareHospitalDataSet premiereCareHospitalDataSet;
    }
}