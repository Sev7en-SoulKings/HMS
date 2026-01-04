using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IDoctorManager
    {
        void AddDoctor(DoctorWriteDto doctor);
        DoctorReadDto GetDoctor(int Id);
    }
}
