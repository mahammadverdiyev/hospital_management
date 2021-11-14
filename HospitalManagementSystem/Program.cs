using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem
{
    public static class Program
    {

        public static void AddData()
        {
            var context = new HospitalManSystemContext();


            Doctor doctor = new Doctor()
            {
                FullName = "Mahammad Verdiyev",
                BirthDay = DateTime.Now,
                Email = "mverdiyev2@std.beu.edu.az",
                PhoneNumber = "+994557148264",
                Position = "Junior Java Developer",
                Password = "12345"
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

        [STAThread]
        public static void Main()
        {
            //AddData();
            //GetDoctor();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HospitalManagementSystemForm());
        }
    }
}
