using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Departmnet;

namespace IKEA.DAL.Reposatories.DepartmentRepo
{
    public class DepartmentRepostories:IDepartmentReposatery
    {
        private readonly ApplicationDBContext _context;
        public DepartmentRepostories(ApplicationDBContext context)
        {
            _context = context;
        }


        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
            {
                return _context.Departments.ToList();
            }
            else
            {
                return _context.Departments.AsNoTracking().ToList();
            }
        }

        public Department GetById(int id)
        {
            var dep = _context.Departments.Find(id);

            return dep;
        }

        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var dep = _context.Departments.Find(id);
            _context.Departments.Remove(dep);
            return _context.SaveChanges();
        }
    }
}
