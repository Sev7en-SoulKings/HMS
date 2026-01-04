using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PatientWriteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public new List<int> Doctor_Id { get; set; }
        public MedicalDeviceWriteDto Medical { get; set; }
    }
}
