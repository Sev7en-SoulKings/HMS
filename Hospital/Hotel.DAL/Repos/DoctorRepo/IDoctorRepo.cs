using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDoctorRepo
    {
        void AddDoctor(Doctor doctor);
        Doctor GetDoctor(int Id);
        int SaveChanges();
    }
}
