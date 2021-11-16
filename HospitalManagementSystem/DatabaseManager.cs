using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;

        private HospitalManSystemContext context;

        private DatabaseManager(HospitalManSystemContext context)
        {
            this.context = context;
        }

        public static  DatabaseManager Instance()
        {
            if (instance is null) instance = new DatabaseManager(new HospitalManSystemContext());

            return instance;
        }

        public Patient RegisterPatient(RegisterDetail registerDetail)
        {
            string hashedPassword = Encryptor.Encrypt(registerDetail.Password,Container.PASS);

            Patient patient = new Patient()
            {
                FullName = registerDetail.FullName,
                Email = registerDetail.Email,
                Password = hashedPassword,
                BirthDate = registerDetail.BirthDate,
                PhoneNumber = registerDetail.PhoneNumber,
                Reservations = new List<Reservation>(),
            };

            context.Patients.Add(patient);

            context.SaveChanges();
            return patient;
        }

        public User TryFindUser(LoginDetail loginDetail)
        {
            User targetUser = context.Users.FirstOrDefault(user => user.Email == loginDetail.Email);

            return targetUser;
        }

        public  bool CheckEmailExist(string email)
        {
            return context.Users.Any(user => user.Email == email);
        }

        public bool CheckEmailExist(RegisterDetail registerDetail)
        {
            return CheckEmailExist(registerDetail.Email);
        }

        public bool CheckEmailExist(LoginDetail loginDetail)
        {
            return CheckEmailExist(loginDetail.Email);
        }
    }
}
