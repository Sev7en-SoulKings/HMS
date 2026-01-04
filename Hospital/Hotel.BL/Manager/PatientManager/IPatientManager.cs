using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPatientManager
    {
        void AddPatient(PatientWriteDto patient);
        PatientReadDto GetPatient(int id);
        IEnumerable<PatientReadDto> GetAll();
        bool UpdatePatient(PatientUpdateDto dto, int id);
        bool DeletePatient(int id);
    }
}
