namespace PremiereCare_Application
{
    partial class EditLabService
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
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCostErr = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.labelSericeErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(144, 125);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 13);
            this.labelCost.TabIndex = 101;
            this.labelCost.Text = "Cost *";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.ForeColor = System.Drawing.Color.Black;
            this.textBoxCost.Location = new System.Drawing.Point(146, 141);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(310, 19);
            this.textBoxCost.TabIndex = 100;
            // 
            // labelCostErr
            // 
            this.labelCostErr.AutoSize = true;
            this.labelCostErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostErr.ForeColor = System.Drawing.Color.Red;
            this.labelCostErr.Location = new System.Drawing.Point(146, 163);
            this.labelCostErr.Name = "labelCostErr";
            this.labelCostErr.Size = new System.Drawing.Size(95, 12);
            this.labelCostErr.TabIndex = 102;
            this.labelCostErr.Text = "Field cannot be empty";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Location = new System.Drawing.Point(249, 486);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonAdd.TabIndex = 99;
            this.buttonAdd.Text = "Edit";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(144, 62);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(50, 13);
            this.labelService.TabIndex = 97;
            this.labelService.Text = "Service *";
            // 
            // textBoxService
            // 
            this.textBoxService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxService.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxService.ForeColor = System.Drawing.Color.Black;
            this.textBoxService.Location = new System.Drawing.Point(146, 78);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(310, 19);
            this.textBoxService.TabIndex = 96;
            // 
            // labelSericeErr
            // 
            this.labelSericeErr.AutoSize = true;
            this.labelSericeErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSericeErr.ForeColor = System.Drawing.Color.Red;
            this.labelSericeErr.Location = new System.Drawing.Point(146, 100);
            this.labelSericeErr.Name = "labelSericeErr";
            this.labelSericeErr.Size = new System.Drawing.Size(95, 12);
            this.labelSericeErr.TabIndex = 98;
            this.labelSericeErr.Text = "Field cannot be empty";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.labelMain.Location = new System.Drawing.Point(224, 20);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(183, 33);
            this.labelMain.TabIndex = 95;
            this.labelMain.Text = "Edit Service";
            this.labelMain.Visible = false;
            // 
            // EditLabService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCostErr);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.labelSericeErr);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLabService";
            this.Text = "EditLabService";
            this.Load += new System.EventHandler(this.EditLabService_Load);
            this.Resize += new System.EventHandler(this.EditLabService_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCostErr;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Label labelSericeErr;
        private System.Windows.Forms.Label labelMain;
    }
}