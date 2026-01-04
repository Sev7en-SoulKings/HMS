using DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PatientManager : IPatientManager
    {
        private readonly IPatientRepo _context;
        private readonly IDoctorRepo _dRepo;
        public PatientManager(IPatientRepo context, IDoctorRepo dRepo)
        {
            _context = context;
            _dRepo = dRepo;
        }
        public void AddPatient(PatientWriteDto patient)
        {
            var patient1 = new Patient()
            {
                Name = patient.Name,
                Email = patient.Email,
                MedicalDevice = new MedicalDevice { Name = patient.Medical.Name }
            };
            var doctors = new List<Doctor>();
            if (patient.Doctor_Id != null && patient.Doctor_Id.Any())
            {
                foreach (var docId in patient.Doctor_Id)
                {
                    var doctor = _dRepo.GetDoctor(docId);
                    if (doctor != null)
                    {
                        doctors.Add(doctor);
                    }
                }
            }
            patient1.Doctors = doctors;
            _context.AddPatient(patient1);
            _context.SaveChanges();
        }
        public bool DeletePatient(int id) 
        { 
            var patient = _context.GetPatient(id); 
            if (patient == null) 
                return false;
            _context.DeletePatient(id); 
            _context.SaveChanges(); 
            return true; 
        }

        public IEnumerable<PatientReadDto> GetAll() 
        { 
            return _context.GetAll().Select(
                p => new PatientReadDto { Name = p.Name, Email = p.Email, MedicalDevice = p.MedicalDevice, Doctors = p.Doctors?
                .Select(d => new DoctorReadDto { Id = d.Id, Name = d.Name, Email = d.Email, Phone = d.Phone 
                }).ToList()
                }); 
        }

        public PatientReadDto GetPatient(int id) 
        { 
            var patient = _context.GetPatient(id); 
            if (patient == null)
                return null;
            return new PatientReadDto 
            {
                Name = patient.Name, 
                Email = patient.Email,
                MedicalDevice = patient.MedicalDevice, 
                Doctors = patient.Doctors?.Select(d => new DoctorReadDto 
                {
                    Id = d.Id, 
                    Name = d.Name, 
                    Email = d.Email, 
                    Phone = d.Phone 
                }).ToList() }; }

        public bool UpdatePatient(PatientUpdateDto dto, int id) 
        {
            var patient = _context.GetPatient(dto.Id); 
            if (patient == null) 
                return false; 
            patient.Name = dto.Name; 
            patient.Email = dto.Email;
            patient.MedicalDevice =new MedicalDevice()
             { 
                Name = dto.MedicalDevice.Name
             }
                ;
            if (dto.Doctor_Id != null && dto.Doctor_Id.Any()) 
            {
                patient.Doctors = dto.Doctor_Id
                    .Select(id => _dRepo.GetDoctor(id)).Where(d => d != null).ToList(); 
            }
            _context.UpdatePatient(patient);
            _context.SaveChanges(); 
            return true; 
        }
    }
}
