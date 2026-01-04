using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPatientRepo
    {
        void AddPatient(Patient patient);
        Patient GetPatient(int id);
        IEnumerable<Patient> GetAll();
        void UpdatePatient(Patient patient);
        void DeletePatient(int id);
        int SaveChanges();
    }
}
