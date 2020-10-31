namespace PremiereCare_Application
{
    partial class CustomMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseMessageBox = new System.Windows.Forms.Button();
            this.labelCustomMessageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 5);
            this.panel1.TabIndex = 0;
            // 
            // buttonCloseMessageBox
            // 
            this.buttonCloseMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
            this.buttonCloseMessageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseMessageBox.FlatAppearance.BorderSize = 0;
            this.buttonCloseMessageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseMessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.buttonCloseMessageBox.Location = new System.Drawing.Point(110, 85);
            this.buttonCloseMessageBox.Name = "buttonCloseMessageBox";
            this.buttonCloseMessageBox.Size = new System.Drawing.Size(93, 36);
            this.buttonCloseMessageBox.TabIndex = 1;
            this.buttonCloseMessageBox.Text = "Close";
            this.buttonCloseMessageBox.UseVisualStyleBackColor = false;
            this.buttonCloseMessageBox.Click += new System.EventHandler(this.buttonCloseMessageBox_Click);
            // 
            // labelCustomMessageBox
            // 
            this.labelCustomMessageBox.AutoSize = true;
            this.labelCustomMessageBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomMessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            this.labelCustomMessageBox.Location = new System.Drawing.Point(31, 35);
            this.labelCustomMessageBox.MaximumSize = new System.Drawing.Size(250, 0);
            this.labelCustomMessageBox.MinimumSize = new System.Drawing.Size(250, 0);
            this.labelCustomMessageBox.Name = "labelCustomMessageBox";
            this.labelCustomMessageBox.Size = new System.Drawing.Size(250, 19);
            this.labelCustomMessageBox.TabIndex = 2;
            this.labelCustomMessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(312, 139);
            this.Controls.Add(this.labelCustomMessageBox);
            this.Controls.Add(this.buttonCloseMessageBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseMessageBox;
        private System.Windows.Forms.Label labelCustomMessageBox;
    }
}