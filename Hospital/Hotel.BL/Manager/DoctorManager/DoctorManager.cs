using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorRepo _context;
        public DoctorManager(IDoctorRepo context)
        {
            _context = context;
        }
        public void AddDoctor(DoctorWriteDto doctor) 
        {
            var doc = new Doctor 
            {
                Name = doctor.Name, 
                Email = doctor.Email, 
                Phone = doctor.Phone, 
                Department_Id = doctor.Department_Id 
            }; 
            _context.AddDoctor(doc);
            _context.SaveChanges(); }

        public DoctorReadDto GetDoctor(int id) 
        { 
            var doc = _context.GetDoctor(id);
            if (doc == null) 
                return null; 
            return new DoctorReadDto 
            {
                Id = doc.Id, 
                Name = doc.Name, 
                Email = doc.Email, 
                Phone = doc.Phone, 
                Department_Id = doc.Department_Id 
            };
        }
    }
}
