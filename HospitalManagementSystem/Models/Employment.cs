using System;

namespace HospitalManagementSystem.Models
{
    public class Employment
    {
        public int Id { get; set; }
        public Doctor Doctor { get;  set; }
        public string Position { get; set; }
        public string JobDescription { get;  set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
    }
}
