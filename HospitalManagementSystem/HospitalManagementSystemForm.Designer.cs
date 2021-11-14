﻿
namespace HospitalManagementSystem
{
    partial class HospitalManagementSystemForm
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
            this.SuspendLayout();
            // 
            // registerAsPatient
            // 
            this.registerAsPatient.AutoSize = true;
            this.registerAsPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerAsPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.registerAsPatient.Location = new System.Drawing.Point(252, 400);
            this.registerAsPatient.Name = "registerAsPatient";
            this.registerAsPatient.Size = new System.Drawing.Size(227, 29);
            this.registerAsPatient.TabIndex = 4;
            this.registerAsPatient.Text = "Register as Patient";
            this.registerAsPatient.Click += new System.EventHandler(this.RegisterAsPatient);
            // 
            // userEmail
            // 
            this.userEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.userEmail.Location = new System.Drawing.Point(258, 85);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(268, 32);
            this.userEmail.TabIndex = 5;
            // 
            // userPassword
            // 
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.userPassword.Location = new System.Drawing.Point(257, 163);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(269, 32);
            this.userPassword.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.loginButton.Location = new System.Drawing.Point(302, 246);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1.Location = new System.Drawing.Point(257, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(257, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // loginWorker
            // 
            this.loginWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartLoginProcess);
            // 
            // HospitalManagementSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.registerAsPatient);
            this.Name = "HospitalManagementSystemForm";
            this.Text = "HospitalManagementSystemForm";
            this.Load += new System.EventHandler(this.HospitalManagementSystemForm_Load);
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
    }
}