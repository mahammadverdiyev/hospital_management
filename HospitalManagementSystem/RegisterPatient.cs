using HospitalManagementSystem.Models;
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

        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void Register(object sender, EventArgs e)
        {
            if (!registerWorker.IsBusy) registerWorker.RunWorkerAsync();
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
        }

        private void StartRegisterProcess(object sender, DoWorkEventArgs e)
        {
            registerSystem = new RegisterSystem(DatabaseManager.Instance());

            if (!phoneNumberTextBox.MaskCompleted)
            {
                MessageBox.Show("Provide phone numbe pelase.");
                return;
            }
            var registerDetail = new RegisterDetail()
            {
                FullName = fullNameTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                Password = passwordTextBox.Text.Trim(),
                ConfirmPassword = confirmPasswordTextBox.Text.Trim(),
                PhoneNumber = phoneNumberTextBox.Text.Trim(),
                BirthDate = birthDatePicker.Value
            };

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

            }
        }
    }
}
