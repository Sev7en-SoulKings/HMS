using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly HMSContext _context;
        public DepartmentRepo(HMSContext context)
        {
            _context = context;
        }
        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
