using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using HospitalManagementSystem.Implementations;

namespace HospitalManagementSystem
{
    public partial class LoginPage : Form
    {
        private DatabaseManager databaseManager;
        private LoginSystem loginSystem;
        private RegisterPatient registerForm;
        private DoctorPage doctorPage;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void HospitalManagementSystemForm_Load(object sender, EventArgs e)
        {
            InitializeCriticalInstances();
            CheckForInitialLoginDetails();
        }

        private void CheckForInitialLoginDetails()
        {
            IniSetting<bool> iniSetting = new IniSetting<bool>();
            if (iniSetting.KeyExists("SaveLoginDetails"))
            {
                bool IsSaved = iniSetting.Read("SaveLoginDetails");

                if (IsSaved)
                {
                    LoginDetailIniSetting loginIni = new LoginDetailIniSetting();
                    string email = loginIni.Read("Email","LoginDetail");
                    string password = loginIni.Read("Password", "LoginDetail");

                    userEmail.Text = email;
                    userPassword.Text = password;

                    saveDetailsCheckbox.Checked = true;
                }
            }
        }

        private void InitializeCriticalInstances()
        {
            databaseManager = DatabaseManager.Instance();
            loginSystem = new LoginSystem(databaseManager);
        }

        private void RegisterAsPatient(object sender, EventArgs e)
        {

            registerForm = new RegisterPatient();
            this.Hide();

            registerForm.FormClosed += (s, eArg) => this.Show();

            registerForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!loginWorker.IsBusy) loginWorker.RunWorkerAsync();
        }
        private void StartLoginProcess(object sender, DoWorkEventArgs e)
        {
            LoginDetail loginDetail = new LoginDetail()
            {
                Email = userEmail.Text.Trim(),
                Password = userPassword.Text.Trim(),
            };

            if (loginDetail.AreFieldsEmpty())
            {
                MessageBox.Show("Provide login details please");
                return;
            }

            loginSystem.TryLogUser(loginDetail);
        }

        private void SaveDetailsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoginDetailIniSetting loginDetailIni = new LoginDetailIniSetting();
            IniSetting<bool> iniSetting = new IniSetting<bool>();

            if (saveDetailsCheckbox.Checked)
            {
                string email = userEmail.Text.Trim();
                string password = userPassword.Text.Trim();

                if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password)) return;

                loginDetailIni.Write("Email", email,"LoginDetail");
                loginDetailIni.Write("Password", password, "LoginDetail");

                iniSetting.Write("SaveLoginDetails", true);
            }
            else
            {
                loginDetailIni.RemoveSection("Logindetail");
                iniSetting.Write("SaveLoginDetails", false);
            }
        }

        private void LoginWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            User loggedUser = loginSystem.GetLoggedUser;

            if (loggedUser != null)
            {
                doctorPage = new DoctorPage();
                doctorPage.Show();
            }
        }
    }
}
