using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorManager _context;
        public DoctorController(IDoctorManager context)
        {
            _context = context;
        }
        [HttpPost] 
        public ActionResult AddDoctor(DoctorWriteDto doctor)
        {
            if (doctor == null) 
                return BadRequest("Invalid doctor data");
            _context.AddDoctor(doctor); 
            return Ok("Doctor added successfully"); 
        }
        [HttpGet("{id}")]
        public ActionResult<DoctorReadDto> GetDoctor(int id)
        {
            var doctor = _context.GetDoctor(id);
            if (doctor == null)
                return NotFound("Doctor not found"); 
            return Ok(doctor); 
        }
    }
}
