using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DepartmentReadDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
