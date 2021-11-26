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
    public partial class ReservationInfo : Form
    {
        private readonly Reservation reservation;

        public Button DeclineButton => declineButton;
        public Button AcceptButton => acceptButton;
        
        private ReservationListPage listPage;

        public ReservationInfo(Reservation reservation, ReservationListPage listPage)
        {
            this.reservation = reservation;
            this.listPage = listPage;
            InitializeComponent();
        }

        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            imagePictureBox.Image = FileUtility.ByteArrayToImage(reservation.Patient.Image);
            fullNameLabel.Text = reservation.Patient.FullName;
            phoneNumberLabel.Text = reservation.Patient.PhoneNumber;
            descriptionLabel.Text = reservation.Description;
            dateLabel.Text = reservation.Date.ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var dbManager = DatabaseManager.Instance();
            reservation.Status = "Accepted";
            dbManager.SaveChanges();

            MessageBox.Show("Reservation Accepted!");
            listPage.RemoveReservationItemByPatientEmail(reservation.Patient.Email);
            this.Close();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            var dbManager = DatabaseManager.Instance();
            reservation.Status = "Rejected";
            dbManager.SaveChanges();

            MessageBox.Show("Reservation Declined!");
            listPage.RemoveReservationItemByPatientEmail(reservation.Patient.Email);
            this.Close();
        }
    }
}
