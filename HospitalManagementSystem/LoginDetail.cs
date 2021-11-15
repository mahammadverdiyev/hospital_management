using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public struct LoginDetail
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsEmailValid()
        {
            try
            {
                MailAddress m = new MailAddress(Email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AreFieldsEmpty()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return true;

            return false;
        }
    }
}
