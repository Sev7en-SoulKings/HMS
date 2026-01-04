using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PatientRepo : IPatientRepo
    {
        private readonly HMSContext _context;
        public PatientRepo(HMSContext context)
        {
            _context = context;
        }
        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
        }

        public void DeletePatient(int id)
        {
            var patient = GetPatient(id);
            _context.Patients.Remove(patient);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients.Include(d => d.Doctors).Include(m => m.MedicalDevice);
        }

        public Patient GetPatient(int id)
        {
            return _context.Patients.Find(id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            _context.Patients.Update(patient);
        }
    }
}
