using System;

namespace HospitalManagementSystem.Models
{
    public class Education
    {
        public int Id { get;  set; }
        public Doctor Doctor { get; set; }
        public string University { get;  set; }
        public string Department { get; set; }
        public DateTime StartingDate { get;  set; }
        public DateTime EndingDate { get;  set; }
      }
}
