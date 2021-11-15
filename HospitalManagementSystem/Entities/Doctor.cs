using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Doctor : User
    {
        public string Position { get; set; }
        public ICollection<Employment> Employments { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public string PhoneNumber { get; set; }
    }
}
