
namespace HospitalManagementSystem
{
    partial class LoginPage
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
            this.registerAsPatient = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginWorker = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.saveDetailsCheckbox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerAsPatient
            // 
            this.registerAsPatient.AutoSize = true;
            this.registerAsPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerAsPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerAsPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.registerAsPatient.Location = new System.Drawing.Point(579, 485);
            this.registerAsPatient.Name = "registerAsPatient";
            this.registerAsPatient.Size = new System.Drawing.Size(109, 31);
            this.registerAsPatient.TabIndex = 4;
            this.registerAsPatient.Text = "Register";
            this.registerAsPatient.Click += new System.EventHandler(this.RegisterAsPatient);
            // 
            // userEmail
            // 
            this.userEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.userEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.userEmail.Location = new System.Drawing.Point(12, 10);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(332, 21);
            this.userEmail.TabIndex = 5;
            // 
            // userPassword
            // 
            this.userPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.userPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.userPassword.Location = new System.Drawing.Point(16, 10);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '•';
            this.userPassword.Size = new System.Drawing.Size(328, 21);
            this.userPassword.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.loginButton.Location = new System.Drawing.Point(433, 408);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(149, 45);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(324, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // loginWorker
            // 
            this.loginWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartLoginProcess);
            this.loginWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.LoginWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label3.Location = new System.Drawing.Point(447, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // saveDetailsCheckbox
            // 
            this.saveDetailsCheckbox.AutoSize = true;
            this.saveDetailsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.saveDetailsCheckbox.Location = new System.Drawing.Point(547, 323);
            this.saveDetailsCheckbox.Name = "saveDetailsCheckbox";
            this.saveDetailsCheckbox.Size = new System.Drawing.Size(141, 24);
            this.saveDetailsCheckbox.TabIndex = 12;
            this.saveDetailsCheckbox.Text = "Remember me";
            this.saveDetailsCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.userEmail);
            this.panel2.Location = new System.Drawing.Point(329, 184);
            this.panel2.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 39);
            this.panel2.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.userPassword);
            this.panel1.Location = new System.Drawing.Point(329, 279);
            this.panel1.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 39);
            this.panel1.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 36);
            this.panel3.TabIndex = 101;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 36);
            this.panel4.TabIndex = 102;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 592);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveDetailsCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerAsPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.HospitalManagementSystemForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label registerAsPatient;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker loginWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox saveDetailsCheckbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}