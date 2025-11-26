using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Contexts;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.Reposatories.EmployeeRepo;

namespace IKEA.DAL.UOW
{

    public class UnitOfWork:IUOW
    {
        private readonly ApplicationDBContext _context;
        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            EmployeeRepo = new EmployeRepo(_context);
            DepartmentRepo = new DepartmentRepostories(_context);
        }
        public IEmployeeRepo EmployeeRepo { get; set; }
        public IDepartmentReposatery DepartmentRepo { get; set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
