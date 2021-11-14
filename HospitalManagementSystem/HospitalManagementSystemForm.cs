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

namespace HospitalManagementSystem
{
    public partial class HospitalManagementSystemForm : Form
    {
        private HospitalManSystemContext context;
        private DatabaseManager databaseManager;
        private LoginSystem loginSystem;

        public HospitalManagementSystemForm()
        {
            InitializeComponent();
        }

        private void HospitalManagementSystemForm_Load(object sender, EventArgs e)
        {
            context = new HospitalManSystemContext();
            databaseManager = new DatabaseManager(context);
            loginSystem = new LoginSystem(databaseManager);
        }

        private void RegisterAsPatient(object sender, EventArgs e)
        {
            // Load register patient form
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
    }
}
