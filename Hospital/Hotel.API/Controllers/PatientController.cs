using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientManager _context;
        public PatientController(IPatientManager context)
        {
            _context = context;
        }
        [HttpPost] 
        public ActionResult AddPatient(PatientWriteDto patient) 
        {
            if (patient == null) 
                return BadRequest("Invalid patient data");
            _context.AddPatient(patient); 
            return Ok("Patient added successfully"); 
        }
        [HttpGet("{id}")]
        public ActionResult<PatientReadDto> GetPatientById(int id) 
        { 
            var patient = _context.GetPatient(id); 
            if (patient == null) 
                return NotFound("Patient not found"); 
            return Ok(patient); 
        }
        [HttpGet] 
        public ActionResult<IEnumerable<PatientReadDto>> GetAllPatients() 
        {
            var patients = _context.GetAll();
            return Ok(patients); }
        [HttpPut("{id}")]
        public ActionResult UpdatePatient(int id, PatientUpdateDto dto)
        {
            if (id != dto.Id)
                return BadRequest("ID mismatch");
            var updated = _context.UpdatePatient(dto, id); 
            if (!updated)
                return NotFound("Patient not found"); 
            return Ok("Patient updated successfully"); 
        }
        [HttpDelete("{id}")]
        public ActionResult DeletePatient(int id)
        {
            var deleted = _context.DeletePatient(id);
            if (!deleted) 
                return NotFound("Patient not found"); 
            return Ok("Patient deleted successfully"); 
        }

    }

}
