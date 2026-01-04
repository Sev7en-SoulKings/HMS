using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HMSContext : DbContext
    {
        public HMSContext(DbContextOptions<HMSContext> options) : base(options) { }
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<MedicalDevice> MedicalDevices => Set<MedicalDevice>();
        public DbSet<Department> Departments => Set<Department>();
    }
}
