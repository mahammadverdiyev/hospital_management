using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        public Button LogoutButton => logoutButton;

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count > 0) flowLayoutPanel.Controls.Clear();

            List<Doctor> doctors = DatabaseManager.Instance().GetAllDoctors();

            foreach (Doctor doctor in doctors)
            {
                ListItem item = new ListItem()
                {
                    Title = doctor.FullName,
                    SubTitle = doctor.Position,
                    Icon = FileUtility.ByteArrayToImage(doctor.Image)
                };

                item.MakeButtonVisible();

                item.RemoveButton.Click += (_sender, _eArgs) => 
                {
                    var dialogResult = MessageBox.Show("Are you sure you want to remove doctor?", "Remove doctor",MessageBoxButtons.OKCancel);
              
                    if(dialogResult == DialogResult.OK)
                    {
                        flowLayoutPanel.Controls.Remove(item);
                        DatabaseManager.Instance().RemoveDoctor(doctor);
                        DatabaseManager.Instance().SaveChanges();
                    }
                };

                flowLayoutPanel.Controls.Add(item);
            }
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count > 0) flowLayoutPanel.Controls.Clear();

            List<Patient> patients = DatabaseManager.Instance().GetAllPatients();

            foreach (Patient patient in patients)
            {
                ListItem item = new ListItem()
                {
                    Title = patient.FullName,
                    SubTitle = patient.Email,
                    ThirdTitle = patient.PhoneNumber,
                    Icon = FileUtility.ByteArrayToImage(patient.Image)
                };

                item.MakeButtonVisible();

                item.RemoveButton.Click += (_sender, _eArgs) =>
                {
                    var dialogResult = MessageBox.Show("Are you sure you want to remove doctor?", "Remove doctor", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        flowLayoutPanel.Controls.Remove(item);
                        DatabaseManager.Instance().RemovePatient(patient);
                        DatabaseManager.Instance().SaveChanges();
                    }
                };

                flowLayoutPanel.Controls.Add(item);
            }
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new AddDoctorForm();
            addDoctorForm.ShowDialog();
        }
    }
}
