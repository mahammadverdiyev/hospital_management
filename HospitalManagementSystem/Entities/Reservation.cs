using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Doctor Doctor { get;  set; }
        public Patient Patient { get; set; }
        public DateTime Date { get;  set;  }
        public string Description { get; set; }

        [Required]
        public bool Approved { get; set; }
    }
}
