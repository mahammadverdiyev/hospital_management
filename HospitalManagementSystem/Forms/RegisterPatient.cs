using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class RegisterPatient : Form
    {
        private RegisterSystem registerSystem;
        private PatientPage patientPage;
        private Bitmap avatar;
        private LoginPage loginPage;

        public RegisterPatient(LoginPage loginPage)
        {
            this.loginPage = loginPage;
            InitializeComponent();
        }

        private void Register(object sender, EventArgs e)
        {
            if (!registerWorker.IsBusy) registerWorker.RunWorkerAsync();
        }

        private void StartRegisterProcess(object sender, DoWorkEventArgs e)
        {
            registerSystem = new RegisterSystem(DatabaseManager.Instance());

            if (!phoneNumberTextBox.MaskCompleted)
            {
                MessageBox.Show("Provide phone numbe pelase.");
                return;
            }


            string sex = "";

            this.Invoke((MethodInvoker)delegate ()
            {
                sex = sexComboBox.Text;
            });



            if (avatar == null)
            {
                if (sex.Equals("Male"))
                    avatar = HospitalManagementSystem.Properties.Resources.male;
                else
                    avatar = HospitalManagementSystem.Properties.Resources.female;
            }
        
            var registerDetail = new RegisterDetail()
            {
                ImageData = FileUtility.ImageToByteArray(avatar),
                FullName = fullNameTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                Password = passwordTextBox.Text.Trim(),
                ConfirmPassword = confirmPasswordTextBox.Text.Trim(),
                PhoneNumber = phoneNumberTextBox.Text.Trim(),
                BirthDate = birthDatePicker.Value,
                Sex = sex
            };

            avatar = null;

            if (registerDetail.IsThereEmptyField())
            {
                MessageBox.Show("Please provide all information.");
                return;
            }

            string validationString = registerDetail.ValidateFields();

            if(validationString != null)
            {
                MessageBox.Show(validationString, "Registration Error");
                return;
            }

            bool successful = registerSystem.TryRegisterUser(registerDetail);

            if (!successful)
            {
                MessageBox.Show("Registration is failed due to internal error.");
                return;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
                confirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '•';
                confirmPasswordTextBox.PasswordChar = '•';
            }
            
        }

        private void phoneNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            phoneNumberTextBox.SelectionStart = 4;
        }

        private void RegistrationProcessCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(this.registerSystem.RegisteredPatient != null)
            {
                this.patientPage = new PatientPage();
                this.patientPage.Show();

                patientPage.LogoutButton.Click += (_sender, _eArgs) => patientPage.Close();


                patientPage.FormClosing += (_sender, _eArgs) => 
                {
                    LoginSystem.LoggedUser = null;
                    loginPage.Show();  
                };
            }
        }

        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                dialog.Title = "Open Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    avatar = new Bitmap(dialog.FileName);
                }
            }
        }
    }
}
