﻿namespace PremiereCare_Application
{
    partial class EditDrug
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCostErr = new System.Windows.Forms.Label();
            this.textBoxDrug = new System.Windows.Forms.TextBox();
            this.labelDrugErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Location = new System.Drawing.Point(249, 484);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 38);
            this.buttonEdit.TabIndex = 99;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelLName
            // 
            this.labelLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(145, 122);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(35, 13);
            this.labelLName.TabIndex = 96;
            this.labelLName.Text = "Cost *";
            // 
            // labelFName
            // 
            this.labelFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(144, 64);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(37, 13);
            this.labelFName.TabIndex = 95;
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
            this.textBoxCost.Location = new System.Drawing.Point(148, 138);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(308, 19);
            this.textBoxCost.TabIndex = 94;
            // 
            // labelCostErr
            // 
            this.labelCostErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCostErr.AutoSize = true;
            this.labelCostErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostErr.ForeColor = System.Drawing.Color.Red;
            this.labelCostErr.Location = new System.Drawing.Point(146, 160);
            this.labelCostErr.Name = "labelCostErr";
            this.labelCostErr.Size = new System.Drawing.Size(95, 12);
            this.labelCostErr.TabIndex = 98;
            this.labelCostErr.Text = "Field cannot be empty";
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
            this.textBoxDrug.Location = new System.Drawing.Point(146, 80);
            this.textBoxDrug.Name = "textBoxDrug";
            this.textBoxDrug.Size = new System.Drawing.Size(310, 19);
            this.textBoxDrug.TabIndex = 93;
            // 
            // labelDrugErr
            // 
            this.labelDrugErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugErr.AutoSize = true;
            this.labelDrugErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrugErr.ForeColor = System.Drawing.Color.Red;
            this.labelDrugErr.Location = new System.Drawing.Point(146, 102);
            this.labelDrugErr.Name = "labelDrugErr";
            this.labelDrugErr.Size = new System.Drawing.Size(95, 12);
            this.labelDrugErr.TabIndex = 97;
            this.labelDrugErr.Text = "Field cannot be empty";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.labelMain.Location = new System.Drawing.Point(224, 22);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(145, 33);
            this.labelMain.TabIndex = 92;
            this.labelMain.Text = "Edit Drug";
            this.labelMain.Visible = false;
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostErr);
            this.Controls.Add(this.textBoxDrug);
            this.Controls.Add(this.labelDrugErr);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDrug";
            this.Text = "EditDrug";
            this.Load += new System.EventHandler(this.EditDrug_Load);
            this.Resize += new System.EventHandler(this.EditDrug_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCostErr;
        private System.Windows.Forms.TextBox textBoxDrug;
        private System.Windows.Forms.Label labelDrugErr;
        private System.Windows.Forms.Label labelMain;
    }
}