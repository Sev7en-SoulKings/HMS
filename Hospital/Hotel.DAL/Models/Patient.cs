using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Patient
    {
        /*
         * ⮚ Patient
● Id: Integer (PK)
● Name: String (Required, Max 100)
● Email: String (Required, Valid)

         */
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100, ErrorMessage ="Name must be less that 100 characters")]
        public string Name { get; set; }
        [Required, EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
        public int? MedicalDevice_Id { get; set; }
        [ForeignKey("MedicalDevice_Id")]
        public MedicalDevice? MedicalDevice { get; set; }
    }
}
