using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoctorRepo : IDoctorRepo
    {
        private readonly HMSContext _context;
        public DoctorRepo(HMSContext context)
        {
            _context = context;
        }
        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
        }

        public Doctor GetDoctor(int Id)
        {
            return _context.Doctors.Find(Id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
