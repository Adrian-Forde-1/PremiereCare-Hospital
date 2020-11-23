namespace PremiereCare_Application
{
    partial class AddDrug
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
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxDrug = new System.Windows.Forms.TextBox();
            this.labelDrugErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelCostErr = new System.Windows.Forms.Label();
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
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLName
            // 
            this.labelLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(146, 120);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(35, 13);
            this.labelLName.TabIndex = 88;
            this.labelLName.Text = "Cost *";
            // 
            // labelFName
            // 
            this.labelFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(145, 62);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(37, 13);
            this.labelFName.TabIndex = 87;
            this.labelFName.Text = "Drug *";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxCost.Location = new System.Drawing.Point(149, 136);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(308, 19);
            this.textBoxCost.TabIndex = 86;
            // 
            // textBoxDrug
            // 
            this.textBoxDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrug.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDrug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrug.ForeColor = System.Drawing.Color.Black;
            this.textBoxDrug.Location = new System.Drawing.Point(147, 78);
            this.textBoxDrug.Name = "textBoxDrug";
            this.textBoxDrug.Size = new System.Drawing.Size(310, 19);
            this.textBoxDrug.TabIndex = 85;
            // 
            // labelDrugErr
            // 
            this.labelDrugErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugErr.AutoSize = true;
            this.labelDrugErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrugErr.ForeColor = System.Drawing.Color.Red;
            this.labelDrugErr.Location = new System.Drawing.Point(147, 100);
            this.labelDrugErr.Name = "labelDrugErr";
            this.labelDrugErr.Size = new System.Drawing.Size(95, 12);
            this.labelDrugErr.TabIndex = 89;
            this.labelDrugErr.Text = "Field cannot be empty";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.labelMain.Location = new System.Drawing.Point(225, 20);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(145, 33);
            this.labelMain.TabIndex = 79;
            this.labelMain.Text = "Add Drug";
            this.labelMain.Visible = false;
            // 
            // labelCostErr
            // 
            this.labelCostErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCostErr.AutoSize = true;
            this.labelCostErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostErr.ForeColor = System.Drawing.Color.Red;
            this.labelCostErr.Location = new System.Drawing.Point(147, 158);
            this.labelCostErr.Name = "labelCostErr";
            this.labelCostErr.Size = new System.Drawing.Size(95, 12);
            this.labelCostErr.TabIndex = 90;
            this.labelCostErr.Text = "Field cannot be empty";
            // 
            // AddDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostErr);
            this.Controls.Add(this.textBoxDrug);
            this.Controls.Add(this.labelDrugErr);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDrug";
            this.Text = "AddDrug";
            this.Load += new System.EventHandler(this.AddDrug_Load);
            this.Resize += new System.EventHandler(this.AddDrug_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxDrug;
        private System.Windows.Forms.Label labelDrugErr;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelCostErr;
    }
}