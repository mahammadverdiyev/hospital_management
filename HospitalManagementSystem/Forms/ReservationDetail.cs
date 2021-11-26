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

namespace HospitalManagementSystem.Forms
{
    public partial class ReservationDetail : Form
    {
        private Doctor doctor;

        public ReservationDetail(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsTimeValid()
        {
            if (datePicker.Value.Day == DateTime.Now.Day)
            {
                if (timePicker.Value.Hour == DateTime.Now.Hour)
                {
                    if (timePicker.Value.Minute < DateTime.Now.Minute)
                    {
                        return false;
                    }
                }
                else if (timePicker.Value.Hour < DateTime.Now.Hour)
                {
                    return false;
                }
            }
            else if (datePicker.Value < DateTime.Now)
            {
                return false;
            }

            return true;
        }

        private bool IsDoctorAtWork()
        {
            string dayOfWeek = datePicker.Value.DayOfWeek.ToString();

            if (dayOfWeek.Equals("Saturday") || dayOfWeek.Equals("Sunday"))
                return false;

            if (timePicker.Value.Hour < 9 || timePicker.Value.Hour > 18)
                return false;
             
            return true;
        }

        private int ToMinutes(DateTime time)
        {
            return time.Hour * 60 + time.Minute;
        }
        private bool DoesReservationCollideWithOthers()
        {
            var reservations = this.doctor.Reservations;

            foreach(var reservation in reservations)
            {
                if(reservation.Date.Day == datePicker.Value.Day)
                {
                    if(Math.Abs(ToMinutes(timePicker.Value) - ToMinutes(reservation.Date)) <= 40)
                    {
                        if (reservation.Status != "Rejected")
                         return true;
                    }
                }
            }

            return false;
        }


        private void SetReservation(object sender, EventArgs e)
        {
            if (!IsTimeValid())
            {
                MessageBox.Show("Invalid Time!");
                return;
            }

            if (!IsDoctorAtWork())
            {
                MessageBox.Show("This time is out of reservation.");
                return;
            }

            if (DoesReservationCollideWithOthers())
            {
                MessageBox.Show("This time is already reserved.");
                return;
            }

            DateTime date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            
            Reservation reservation = new Reservation()
            {
                Status = "Pending",
                Date = date,
                Description = descriptionTextBox.Text,
                Doctor = doctor,
                Patient = LoginSystem.LoggedUser as Patient,
            };

            var dbManager = DatabaseManager.Instance();
            dbManager.AddReservation(reservation);
            dbManager.SaveChanges();

            MessageBox.Show("Success!");
            this.Close();
        }

    }
}
