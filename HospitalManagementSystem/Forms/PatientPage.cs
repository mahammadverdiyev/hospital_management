using HospitalManagementSystem.Forms;
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
    public partial class PatientPage : Form
    {
        List<Doctor> availableDoctors;

        public Button LogoutButton => logoutButton;

        public PatientPage()
        {
            InitializeComponent();
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {
            Patient patient = LoginSystem.LoggedUser as Patient;


            userAvatar.Image = FileUtility.ByteArrayToImage(patient.Image);

            labelFullName.Text = patient.FullName;
            GetAvailableDoctors();
        }


        private void GetAvailableDoctors()
        {
            var dbManager = DatabaseManager.Instance();

            availableDoctors = dbManager.GetAllDoctors();

            for(int i = 0; i < availableDoctors.Count; i++)
            {
                var item = new ListItem();
                item.Title = availableDoctors[i].FullName;
                item.SubTitle = availableDoctors[i].Position;
                item.Width = doctorList.Width;
                var doctor = availableDoctors[i];

                item.Click += (sender, eArgs) =>
                {
                    DoctorDetail detailPage = new DoctorDetail(doctor);
                    detailPage.ShowDialog();
                };

                doctorList.Controls.Add(item);
            }
        }

        public  void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            PatientReservations patientReservations = new PatientReservations();
            patientReservations.ShowDialog();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
