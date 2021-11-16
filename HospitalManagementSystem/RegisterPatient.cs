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
            registerSystem = new RegisterSystem(DatabaseManager.Instance());
        }

        private void StartRegisterProcess(object sender, DoWorkEventArgs e)
        {
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
    }
}
