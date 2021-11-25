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

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            List<Doctor> doctors = DatabaseManager.Instance().GetAllDoctors();

            foreach (Doctor doctor in doctors)
            {
                ListItem item = new ListItem()
                {
                    Title = doctor.FullName,
                    SubTitle = doctor.Position,
                    Icon = FileUtility.ByteArrayToImage(doctor.Image)
                };

                item.Show();

                flowLayoutPanel.Controls.Add(item);
            }
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new AddDoctorForm();
            addDoctorForm.ShowDialog();
        }
    }
}
