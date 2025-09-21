using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_assignment_3.Models;

namespace EntityFramework_assignment_3.Context
{
    public class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=Company_DB;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=True;").UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
