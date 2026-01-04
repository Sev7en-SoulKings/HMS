using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PatientReadDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
         public new List<DoctorReadDto> Doctors { get; set; }
            public MedicalDevice? MedicalDevice { get; set; }
    }
}
