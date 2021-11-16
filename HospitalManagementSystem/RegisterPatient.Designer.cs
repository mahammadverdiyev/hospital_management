
namespace HospitalManagementSystem
{
    partial class RegisterPatient
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerWorker = new System.ComponentModel.BackgroundWorker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fullNameTextBox.Location = new System.Drawing.Point(20, 97);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(241, 27);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(335, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailTextBox.Location = new System.Drawing.Point(20, 167);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(241, 27);
            this.emailTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(552, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone number";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(556, 97);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(241, 27);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(556, 178);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(237, 26);
            this.birthDatePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(552, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birth date";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.registerButton.Location = new System.Drawing.Point(359, 453);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 43);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.Register);
            // 
            // registerWorker
            // 
            this.registerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartRegisterProcess);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(16, 243);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(241, 27);
            this.passwordTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(16, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(20, 325);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '•';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(241, 27);
            this.confirmPasswordTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(16, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirm password";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.showPasswordCheckBox.Location = new System.Drawing.Point(112, 370);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(149, 24);
            this.showPasswordCheckBox.TabIndex = 14;
            this.showPasswordCheckBox.Text = "Show password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 532);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterPatient";
            this.Text = "RegisterPatient";
            this.Load += new System.EventHandler(this.RegisterPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerButton;
        private System.ComponentModel.BackgroundWorker registerWorker;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}