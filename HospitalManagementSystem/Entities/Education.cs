using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;  set; }
        public Doctor Doctor { get; set; }
        public string University { get;  set; }
        public string Department { get; set; }
        public DateTime StartingDate { get;  set; }
        public DateTime EndingDate { get;  set; }


        public override string ToString()
        {
            return $"University: {University}\nDepartment: {Department} \nStartingDate: {StartingDate.ToShortDateString()} \nEndingDate: {EndingDate}";
        }
    }
}
