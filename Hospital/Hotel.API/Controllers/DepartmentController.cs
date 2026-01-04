using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _context;
        public DepartmentController(IDepartmentManager context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult AddDepartment(DepartmentWriteDto dto) 
        {
             _context.AddDepartment(dto);
            if (dto != null) 
            {
                return Ok("Department Created");
            }
            return BadRequest("Error Occured");
        }
    }
}
