using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

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

        public static DatabaseManager Instance()
        {
            if (instance is null) instance = new DatabaseManager(new HospitalManSystemContext());

            return instance;
        }

        public bool DoctorExists(string email)
        {
            Doctor doctor = context.Doctors.FirstOrDefault(d => d.Email.Equals(email));

            return doctor != null;
        }

        public void RemoveDoctor(Doctor doctor)
        {
            context.Doctors.Remove(doctor);
        }

        public void RemovePatient(Patient patient)
        {
            context.Patients.Remove(patient);
        }
        public void AddEducations(List<Education> educations)
        {
            educations.ForEach(e => context.Educations.Add(e));
        }

        public void AddEmployments(List<Employment> employments)
        {
            employments.ForEach(e => context.Employments.Add(e));
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
        }

        public Doctor GetDoctorByEmail(string email)
        {
            return GetAllDoctors().FirstOrDefault(doctor => doctor.Email == email);
        }

        public List<Doctor>  GetAllDoctors()
        {

            var allDoctors = context.Doctors
                                    .Include("Employments")
                                    .Include("Educations")
                                    .Include("Reservations")
                                    .Include(doctor => doctor.Reservations.Select(res => res.Patient))
                                    .ToList();

            return allDoctors;
        }

        public List<Patient> GetAllPatients()
        {
            return context.Patients
                .ToList();
        }

        public Patient GetPatientFullyByEmail(string email)
        {
            return context.Patients
                .Where(patient => patient.Email == email)
                .Include("Reservations")
                .Include(patient => patient.Reservations.Select(res => res.Doctor))
                .FirstOrDefault();
        }

        public Doctor GetDoctorFullyByEmail(string email)
        {
            return context.Doctors
                .Where(doctor => doctor.Email == email)
                .Include("Reservations")
                .Include(doctor => doctor.Reservations.Select(res => res.Patient))
                .FirstOrDefault();
        }

        public Patient RegisterPatient(RegisterDetail registerDetail)
        {
            string hashedPassword = Encryptor.Encrypt(registerDetail.Password,Container.PASS);

            Patient patient = new Patient()
            {
                Image = registerDetail.ImageData,
                FullName = registerDetail.FullName,
                Email = registerDetail.Email,
                Password = hashedPassword,
                BirthDate = registerDetail.BirthDate,
                PhoneNumber = registerDetail.PhoneNumber,
                Sex = registerDetail.Sex,
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

        public void AddReservation(Reservation reservation)
        {
            context.Reservations.Add(reservation);
        }

        public void AddDoctor(Doctor newDoctor)
        {
            context.Doctors.Add(newDoctor);
        }
        public void AddAdmin(Admin admin)
        {
            context.Admins.Add(admin);
        }
    }
}
