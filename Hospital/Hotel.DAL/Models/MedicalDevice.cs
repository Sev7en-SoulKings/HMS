using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicalDevice
    {
        /*
         * ⮚ MedicalDevice
● Id: Integer (PK)
● Model: String (Required, Max 100)

         */
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100, ErrorMessage ="Model must be less than 100 characters")]
        public string Name { get; set; }
        public int? Patient_Id { get; set; }
        [ForeignKey("Patient_Id")]
        public Patient? Patient { get; set; }
    }
}
