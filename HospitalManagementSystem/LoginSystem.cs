using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public class LoginSystem
    {
        private DatabaseManager databaseManager;

        public LoginSystem(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        private bool DoesPasswordMatch(User user, LoginDetail loginDetail)
        {
            if (loginDetail.Password != user.Password)
               return false;

            return true;
        }

        public void TryLogUser(LoginDetail loginDetail)
        {
            bool isValid = loginDetail.IsEmailValid();

            if (!isValid)
            {
                MessageBox.Show("Invalid email!");
                return;
            }

            else
            {
                User user = databaseManager.TryFindUser(loginDetail);

                if (user is null)
                {
                    MessageBox.Show("Email or password is invalid.");
                    return;
                }
                else
                {
                    if (!DoesPasswordMatch(user,loginDetail))
                        MessageBox.Show("Incorrect password.");

                    NavigateCorrespondingPage(user);
                }
            }
        }

        private void NavigateCorrespondingPage(User user)
        {
            if (user is Patient)
            {
                Patient patient = user as Patient;
                // show Patient form
            }
            else if (user is Doctor)
            {
                Doctor doctor = user as Doctor;
                // show Doctor form
            }
            else
            {
                Admin admin = user as Admin;
                // show Admin form
            }
        }
    }
}
