using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Employment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Doctor Doctor { get;  set; }
        public string Position { get; set; }
        public string JobDescription { get;  set; }
        public string WorkPlace { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }


        public override string ToString()
        {
            return $"Position: {Position}\nJob Description:{JobDescription}\n" +
                $"Work Place: {WorkPlace}\nYear of Experience: {StartingDate.ToShortDateString()} - {EndingDate.ToShortDateString()}";
        }
    }
}
