namespace PremiereCare_Application
{
    partial class EditCSR
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
            this.csrDOB = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.labelLNameErr = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.labelFNameErr = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSalaryErr = new System.Windows.Forms.Label();
            this.labelPasswordErr = new System.Windows.Forms.Label();
            this.labelUsernameErr = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // csrDOB
            // 
            this.csrDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csrDOB.Location = new System.Drawing.Point(145, 313);
            this.csrDOB.Name = "csrDOB";
            this.csrDOB.Size = new System.Drawing.Size(313, 20);
            this.csrDOB.TabIndex = 92;
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
            this.buttonAdd.Text = "Edit";
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
            this.labelLName.Size = new System.Drawing.Size(65, 13);
            this.labelLName.TabIndex = 88;
            this.labelLName.Text = "Last Name *";
            // 
            // labelFName
            // 
            this.labelFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(145, 62);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(64, 13);
            this.labelFName.TabIndex = 87;
            this.labelFName.Text = "First Name *";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.ForeColor = System.Drawing.Color.Black;
            this.textBoxLname.Location = new System.Drawing.Point(149, 136);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(308, 19);
            this.textBoxLname.TabIndex = 86;
            // 
            // labelLNameErr
            // 
            this.labelLNameErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLNameErr.AutoSize = true;
            this.labelLNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLNameErr.ForeColor = System.Drawing.Color.Red;
            this.labelLNameErr.Location = new System.Drawing.Point(147, 158);
            this.labelLNameErr.Name = "labelLNameErr";
            this.labelLNameErr.Size = new System.Drawing.Size(95, 12);
            this.labelLNameErr.TabIndex = 90;
            this.labelLNameErr.Text = "Field cannot be empty";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.ForeColor = System.Drawing.Color.Black;
            this.textBoxFname.Location = new System.Drawing.Point(147, 78);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(310, 19);
            this.textBoxFname.TabIndex = 85;
            // 
            // labelFNameErr
            // 
            this.labelFNameErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFNameErr.AutoSize = true;
            this.labelFNameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFNameErr.ForeColor = System.Drawing.Color.Red;
            this.labelFNameErr.Location = new System.Drawing.Point(147, 100);
            this.labelFNameErr.Name = "labelFNameErr";
            this.labelFNameErr.Size = new System.Drawing.Size(95, 12);
            this.labelFNameErr.TabIndex = 89;
            this.labelFNameErr.Text = "Field cannot be empty";
            // 
            // labelSex
            // 
            this.labelSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(144, 411);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(32, 13);
            this.labelSex.TabIndex = 84;
            this.labelSex.Text = "Sex *";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSex.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(145, 427);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(313, 24);
            this.comboBoxSex.TabIndex = 83;
            // 
            // labelSalaryErr
            // 
            this.labelSalaryErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalaryErr.AutoSize = true;
            this.labelSalaryErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryErr.ForeColor = System.Drawing.Color.Red;
            this.labelSalaryErr.Location = new System.Drawing.Point(143, 389);
            this.labelSalaryErr.Name = "labelSalaryErr";
            this.labelSalaryErr.Size = new System.Drawing.Size(95, 12);
            this.labelSalaryErr.TabIndex = 82;
            this.labelSalaryErr.Text = "Field cannot be empty";
            // 
            // labelPasswordErr
            // 
            this.labelPasswordErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPasswordErr.AutoSize = true;
            this.labelPasswordErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordErr.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordErr.Location = new System.Drawing.Point(144, 275);
            this.labelPasswordErr.Name = "labelPasswordErr";
            this.labelPasswordErr.Size = new System.Drawing.Size(95, 12);
            this.labelPasswordErr.TabIndex = 81;
            this.labelPasswordErr.Text = "Field cannot be empty";
            // 
            // labelUsernameErr
            // 
            this.labelUsernameErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsernameErr.AutoSize = true;
            this.labelUsernameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameErr.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameErr.Location = new System.Drawing.Point(144, 217);
            this.labelUsernameErr.Name = "labelUsernameErr";
            this.labelUsernameErr.Size = new System.Drawing.Size(95, 12);
            this.labelUsernameErr.TabIndex = 80;
            this.labelUsernameErr.Text = "Field cannot be empty";
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.labelMain.Location = new System.Drawing.Point(225, 20);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(142, 33);
            this.labelMain.TabIndex = 79;
            this.labelMain.Text = "Edit CSR";
            this.labelMain.Visible = false;
            // 
            // labelSalary
            // 
            this.labelSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(143, 351);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(43, 13);
            this.labelSalary.TabIndex = 78;
            this.labelSalary.Text = "Salary *";
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(144, 296);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(66, 13);
            this.labelDOB.TabIndex = 77;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(144, 237);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 13);
            this.labelPassword.TabIndex = 76;
            this.labelPassword.Text = "Password *";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(144, 179);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(62, 13);
            this.labelUsername.TabIndex = 75;
            this.labelUsername.Text = "Username *";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.ForeColor = System.Drawing.Color.Black;
            this.textBoxSalary.Location = new System.Drawing.Point(146, 367);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(311, 19);
            this.textBoxSalary.TabIndex = 74;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(147, 253);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(311, 19);
            this.textBoxPassword.TabIndex = 73;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(147, 195);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(311, 19);
            this.textBoxUsername.TabIndex = 72;
            // 
            // EditCSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.csrDOB);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.labelLNameErr);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelFNameErr);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.labelSalaryErr);
            this.Controls.Add(this.labelPasswordErr);
            this.Controls.Add(this.labelUsernameErr);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCSR";
            this.Text = "EditCSR";
            this.Load += new System.EventHandler(this.EditCSR_Load);
            this.Resize += new System.EventHandler(this.EditCSR_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker csrDOB;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label labelLNameErr;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label labelFNameErr;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelSalaryErr;
        private System.Windows.Forms.Label labelPasswordErr;
        private System.Windows.Forms.Label labelUsernameErr;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}