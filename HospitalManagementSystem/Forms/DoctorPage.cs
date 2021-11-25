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
    public partial class DoctorPage : Form
    {
        private Doctor currentDoctor;

        public Button LogoutButton => logoutButton;

        public DoctorPage()
        {
            InitializeComponent();
            var dbManager = DatabaseManager.Instance();
            var partialDoctor = LoginSystem.LoggedUser as Doctor;
            currentDoctor = dbManager.GetDoctorByEmail(partialDoctor.Email);
        }

        private void MyProfileButton_Click(object sender, EventArgs e)
        {
            DoctorDetail doctorDetail = new DoctorDetail(currentDoctor);
            doctorDetail.MakeReservationButton.Hide();
            doctorDetail.Show();
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {
            labelFullName.Text = currentDoctor.FullName;
        }

        public void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private  List<ListItem> FilterReservationsBy(Func<Reservation,bool> func)
        {
            var resList = currentDoctor.Reservations.Where(func).ToList();
            var controlList = new List<ListItem>(resList.Count);

            foreach (var reservation in resList)
            {
                ListItem item = new ListItem();
                item.Title = reservation.Patient.FullName;
                item.SubTitle = reservation.Description;
                item.Icon = FileUtility.ByteArrayToImage(reservation.Patient.Image);
                item.Reservation = reservation;
                controlList.Add(item);
            }

            return controlList;
        }

        private void acceptedReservationsButton_Click(object sender, EventArgs e)
        {
            var listItem = FilterReservationsBy(res => res.Status == "Accepted");

            foreach(var item in listItem)
            {
                item.Click += (_sender, _eArgs) =>
                {
                    ReservationInfo reservationInfo = new ReservationInfo(item.Reservation);
                    reservationInfo.AcceptButton.Hide();
                    reservationInfo.DeclineButton.Hide();
                    reservationInfo.ShowDialog();
                };
            }

            ReservationListPage listPage = new ReservationListPage(listItem);
            listPage.ShowDialog();
        }

        private void requestedReversationsButton_Click(object sender, EventArgs e)
        {
            var listItem = FilterReservationsBy(res => res.Status == "Pending");


            foreach (var item in listItem)
            {
                item.Click += (_sender, _eArgs) =>
                {
                    ReservationInfo reservationInfo = new ReservationInfo(item.Reservation);
                    reservationInfo.ShowDialog();
                };
            }

            ReservationListPage listPage = new ReservationListPage(listItem);
            listPage.ShowDialog();
        }
    }
}
