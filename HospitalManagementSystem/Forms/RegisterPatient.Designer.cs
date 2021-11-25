
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
            this.registerWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSex = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectPictureButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerWorker
            // 
            this.registerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StartRegisterProcess);
            this.registerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RegistrationProcessCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectPictureButton);
            this.panel1.Controls.Add(this.labelSex);
            this.panel1.Controls.Add(this.sexComboBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.showPasswordCheckBox);
            this.panel1.Controls.Add(this.labelConfirmPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.labelBirthDate);
            this.panel1.Controls.Add(this.birthDatePicker);
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Location = new System.Drawing.Point(10, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 565);
            this.panel1.TabIndex = 0;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelSex.Location = new System.Drawing.Point(553, 237);
            this.labelSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(29, 19);
            this.labelSex.TabIndex = 149;
            this.labelSex.Text = "Sex";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(557, 269);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(157, 25);
            this.sexComboBox.TabIndex = 148;
            this.sexComboBox.Text = "Male";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.Controls.Add(this.phoneNumberTextBox);
            this.panel5.Location = new System.Drawing.Point(557, 110);
            this.panel5.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 39);
            this.panel5.TabIndex = 147;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.Culture = new System.Globalization.CultureInfo("az-Latn-AZ");
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.phoneNumberTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(13, 5);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.Mask = "(999) 00-000-00-00";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(222, 26);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.Text = "994";
            this.phoneNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.phoneNumberTextBox_MouseClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.Controls.Add(this.confirmPasswordTextBox);
            this.panel4.Location = new System.Drawing.Point(25, 357);
            this.panel4.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 39);
            this.panel4.TabIndex = 146;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(10, 10);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '•';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(340, 20);
            this.confirmPasswordTextBox.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Location = new System.Drawing.Point(25, 259);
            this.panel3.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 39);
            this.panel3.TabIndex = 145;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(10, 10);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(338, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Location = new System.Drawing.Point(25, 180);
            this.panel2.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 39);
            this.panel2.TabIndex = 144;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailTextBox.Location = new System.Drawing.Point(12, 10);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(338, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel6.Controls.Add(this.fullNameTextBox);
            this.panel6.Location = new System.Drawing.Point(25, 110);
            this.panel6.MaximumSize = new System.Drawing.Size(560, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 39);
            this.panel6.TabIndex = 143;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fullNameTextBox.Location = new System.Drawing.Point(10, 10);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(338, 20);
            this.fullNameTextBox.TabIndex = 0;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.showPasswordCheckBox.Location = new System.Drawing.Point(219, 418);
            this.showPasswordCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(165, 29);
            this.showPasswordCheckBox.TabIndex = 142;
            this.showPasswordCheckBox.Text = "Show password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(20, 320);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(165, 25);
            this.labelConfirmPassword.TabIndex = 141;
            this.labelConfirmPassword.Text = "Confirm password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelPassword.Location = new System.Drawing.Point(20, 231);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 25);
            this.labelPassword.TabIndex = 140;
            this.labelPassword.Text = "Password";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.registerButton.Location = new System.Drawing.Point(448, 486);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(159, 46);
            this.registerButton.TabIndex = 139;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.Register);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelBirthDate.Location = new System.Drawing.Point(552, 163);
            this.labelBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(94, 25);
            this.labelBirthDate.TabIndex = 137;
            this.labelBirthDate.Text = "Birth date";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.birthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.7F);
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDatePicker.Location = new System.Drawing.Point(557, 192);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(237, 33);
            this.birthDatePicker.TabIndex = 138;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelPhoneNumber.Location = new System.Drawing.Point(552, 77);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(137, 25);
            this.labelPhoneNumber.TabIndex = 136;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelEmail.Location = new System.Drawing.Point(20, 152);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 25);
            this.labelEmail.TabIndex = 135;
            this.labelEmail.Text = "Email";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.labelFullName.Location = new System.Drawing.Point(20, 77);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(94, 25);
            this.labelFullName.TabIndex = 134;
            this.labelFullName.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(449, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 105;
            this.label1.Text = "Registration";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(2, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1037, 94);
            this.panel7.TabIndex = 106;
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "openFileDialog1";
            // 
            // selectPictureButton
            // 
            this.selectPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.7F);
            this.selectPictureButton.Location = new System.Drawing.Point(557, 345);
            this.selectPictureButton.Name = "selectPictureButton";
            this.selectPictureButton.Size = new System.Drawing.Size(235, 51);
            this.selectPictureButton.TabIndex = 150;
            this.selectPictureButton.Text = "Select picture";
            this.selectPictureButton.UseVisualStyleBackColor = true;
            this.selectPictureButton.Click += new System.EventHandler(this.selectPictureButton_Click);
            // 
            // RegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 687);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker registerWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Button selectPictureButton;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
    }
}