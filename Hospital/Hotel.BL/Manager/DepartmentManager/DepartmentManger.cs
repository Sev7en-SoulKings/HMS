using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DepartmentManger : IDepartmentManager
    {
        private readonly IDepartmentRepo _context;
        public DepartmentManger(IDepartmentRepo context)
        {
            _context = context;
        }
        public void AddDepartment(DepartmentWriteDto department)
        {
            var Dep = new Department()
            {
                Name = department.Name,
                Description = department.Description,
            };
            _context.AddDepartment(Dep);
            _context.SaveChanges();
        }
    }
}
