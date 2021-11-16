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
        private User LoggedUser;

        public User GetLoggedUser => LoggedUser;

        public LoginSystem(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        private bool DoesPasswordMatch(User user, LoginDetail loginDetail)
        {
            if (loginDetail.Password != Decryptor.Decrypt(user.Password,Container.PASS))
               return false;

            return true;
        }

        public void TryLogUser(LoginDetail loginDetail)
        {
            bool isEmailValid = loginDetail.IsEmailValid();

            if (!isEmailValid)
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
                    LoggedUser = null;
                    return;
                }
                else
                {
                    if (!DoesPasswordMatch(user,loginDetail))
                    {
                        MessageBox.Show("Incorrect password.");
                        LoggedUser = null;
                        return;
                    }

                    LoggedUser = user;
                }
            }
        }
    }
}
