using HospitalManagementSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public class HospitalManSystemContext : DbContext
    {
        public HospitalManSystemContext() : base("DefaultConnection") {}
        
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Doctors");
            });

            modelBuilder.Entity<Patient>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Patients");
            });

            modelBuilder.Entity<Admin>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Admins");
            });
        }

    }
}
