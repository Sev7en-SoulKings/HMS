using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Doctor
    {
        /*
         ⮚ Doctor
● Id: Integer (PK)
● Name: String (Required, Max 100)
● Email: String (Required, Valid)
● Phone: String (Optional)
         */
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100, ErrorMessage ="Name must be less than 100 characters")]
        public string Name { get; set; }
        [Required, EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
        public int? Department_Id { get; set; }
        [ForeignKey("Department_Id")]
        public Department? Department { get; set; }
    }
}
