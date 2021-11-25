using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Patient : User
    {
        public string PhoneNumber { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
