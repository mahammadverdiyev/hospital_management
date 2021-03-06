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

namespace HospitalManagementSystem.Forms
{
    public partial class DoctorDetail : Form
    {
        private Doctor currentDoctor;

        public Button MakeReservationButton { get => makeReservationButton; }

        public DoctorDetail(Doctor doctor)
        {
            currentDoctor = doctor;
            InitializeComponent();
        }

        private void DoctorDetail_Load(object sender, EventArgs e)
        {
            doctorImage.Image = FileUtility.ByteArrayToImage(currentDoctor.Image);
            doctorFullName.Text = currentDoctor.FullName;
            doctorPhoneNumber.Text = currentDoctor.PhoneNumber;
            doctorPosition.Text = currentDoctor.Position;
            doctorEducations.Text = string.Join(", ", currentDoctor.Educations);
            doctorEmployments.Text = string.Join(", ", currentDoctor.Employments);
        }

        private void SetReservation(object sender, EventArgs e)
        {
            ReservationDetail reservationDetail = new ReservationDetail(currentDoctor);
            reservationDetail.ShowDialog();
        }
    }
}
