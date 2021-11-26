using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public abstract class User
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Sex { get; set; }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        public DateTime? BirthDate { get; set; }

        public byte[] Image { get; set; }
    }
}
