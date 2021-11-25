using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace HospitalManagementSystem.Models
{
    public struct RegisterDetail
    {

        public byte[] ImageData { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Sex { get; set; }

        public string ConfirmPassword { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        private bool IsEmailValid()
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

        public bool IsThereEmptyField()
        {
            string[] fields = { FullName, Email, PhoneNumber };
            return fields.Any(string.IsNullOrEmpty);
        }

        private bool IsFullNameValid()
        {
            string[] splitted = FullName.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            if (splitted.Length <= 1) return false;

            string singleSpaceSeperatedFullName = string.Join(" ", splitted);
            FullName = singleSpaceSeperatedFullName;

            return true;
        }

        private bool IsEmailExist()
        {
            var databaseManager = DatabaseManager.Instance();

            return databaseManager.CheckEmailExist(Email);
        }

        private bool IsBirthDateValid()
        {
            return (DateTime.Now.Year - BirthDate.Year) > 7;
        }

        private bool IsPasswordValid()
        {
            return Password.Length >= 6;
        }


        private bool IsConfirmPassMatch()
        {
            return Password == ConfirmPassword;
        }


        public string ValidateFields()
        {
            List<string> errors = new List<string>(10);

            if (!IsFullNameValid())
                errors.Add("Incorrect Full Name, Please provide Name and Surname respectively.");
            
            if (!IsEmailValid()) 
                errors.Add("Email format is invalid.");

            if(IsEmailExist()) 
                errors.Add("This Email already has been registered.");

            if (!IsBirthDateValid()) 
                errors.Add("Birth Date is invalid");

            if (!IsConfirmPassMatch())
                errors.Add("Confirm Password is not same as provided password");

            if (!IsPasswordValid())
                errors.Add("Password should contain at least 6 character!");

            if (errors.Count == 0) return null;

            return $"{"Registration is unsuccessful due to problems shown below:"}\n\n{string.Join("\n", errors)}";
        }
    }
}
