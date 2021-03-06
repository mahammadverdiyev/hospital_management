using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Test
    {
        public static void AddData()
        {
            var context = new HospitalManSystemContext();


            Doctor doctor = new Doctor()
            {
                Image = FileUtility.ImageToByteArray(HospitalManagementSystem.Properties.Resources.male),
                Sex = "Male",
                FullName = "Mahammad Verdiyev",
                BirthDate = DateTime.Now,
                Email = "mverdiyev2@std.beu.edu.az",
                PhoneNumber = "+994557148264",
                Position = "Junior Java Developer",
                Password = Encryptor.Encrypt("mahammad2001", Container.PASS),
            };

            List<Education> educations = new List<Education>() {
                    new Education()
                    {
                        University = "BSU",
                        Doctor = doctor,
                        Department = "Engineering",
                        StartingDate = new DateTime(2015,05,20),
                        EndingDate = DateTime.Now,
                    },

                    new Education()
                    {
                        University = "BEU",
                        Doctor = doctor,
                        Department = "C# Development",
                        StartingDate = new DateTime(2018, 07, 2),
                        EndingDate = DateTime.Now,
                    }
            };

            List<Employment> employments = new List<Employment>()
            {
                new Employment()
                {
                        Doctor = doctor,
                        EndingDate = new DateTime(2015,04,15),
                        JobDescription = "Random text",
                        Position =  "Bas hekim",
                        StartingDate = DateTime.Now
                }
            };

            doctor.Educations = educations;
            doctor.Employments = employments;

            //context.Doctors.Add(doctor);
            employments.ForEach(e => context.Employments.Add(e));
            educations.ForEach(e => context.Educations.Add(e));

            context.SaveChanges();
        }
        public static void GetDoctor()
        {
            var context = new HospitalManSystemContext();

            //var employment = context.Employments
            //       .Where(s => s.JobDescription == "Junior Java Developer")
            //       .Include(e => e.Doctor)
            //       .Include(e => e.Doctor)
            //       .FirstOrDefault();

            //var doctor = employment.Doctor;

            //Console.WriteLine(doctor.FullName);
            //Console.WriteLine(doctor.PhoneNumber);
            //Console.WriteLine(doctor.Email);

            var doctor = context.Doctors.Include("Educations").FirstOrDefault();

            if (doctor != null)
            {
                Console.WriteLine(doctor.FullName);

                if (doctor.Educations != null)
                {
                    foreach (var education in doctor.Educations)
                    {
                        Console.WriteLine(education.Department);
                        Console.WriteLine(education.University);
                    }
                }
            }
        }

        public static void AddAdmin()
        {
            Admin admin = new Admin()
            {
                FullName = "Elnur Veliyev",
                BirthDate = DateTime.Now,
                Email = "elnur@gmail.com",
                Password = Encryptor.Encrypt("elnur2001", Container.PASS),
                Image = FileUtility.ImageToByteArray(HospitalManagementSystem.Properties.Resources.male),
                Sex = "Male",
            };

            DatabaseManager.Instance().AddAdmin(admin);
            DatabaseManager.Instance().SaveChanges();
        }

    }
}
