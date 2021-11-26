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
    public partial class PatientReservations : Form
    {
        Patient currentPatient;
        public PatientReservations()
        {
            string email = (LoginSystem.LoggedUser as Patient).Email;
            currentPatient = DatabaseManager.Instance().GetPatientFullyByEmail(email);
            InitializeComponent();
        }

        private void PatientReversations_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            var reservations = currentPatient.Reservations;

            Console.WriteLine(reservations.Count);
            foreach(var reservation in reservations)
            {
                ListItem item = new ListItem();
                item.Title = "Dr. " + reservation.Doctor.FullName;
             
                if(reservation.Description.Trim().Count() == 0)
                    item.SubTitle = "No description";
                else
                    item.SubTitle = reservation.Description;

                item.SubTitle += $"\n{reservation.Date}";
                
                item.ThirdTitle = reservation.Status;

                switch (reservation.Status)
                {
                    case "Accepted":
                        item.SetBackColor(Color.Green);
                        break;

                    case "Rejected":
                        item.SetBackColor(Color.Red);
                        break;

                    case "Pending":
                        item.SetBackColor(Color.Orange);
                        break;
                }

                item.Width = flowLayoutPanel.Width;
                flowLayoutPanel.Controls.Add(item);
            }
        }
    }
}
