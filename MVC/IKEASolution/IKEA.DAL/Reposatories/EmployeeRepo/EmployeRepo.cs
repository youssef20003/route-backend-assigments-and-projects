using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Departmnet;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.GenaricRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Reposatories.EmployeeRepo
{
    public class EmployeRepo : GenaricRepo<Employee>, IEmployeeRepo
    {
        private readonly ApplicationDBContext _context;

        public EmployeRepo(ApplicationDBContext context) : base(context) 
        {
            _context = context;
        }


        public IEnumerable<Employee> GetAll(string? SearchValue)
        {
            if (SearchValue is null)
            {
                return GetAll();
            }
            else
            {
                var result =
                    _context.Employees.Where(e => e.Name.Trim().ToLower().Contains(SearchValue.Trim().ToLower()));
                return result;
            }
        }
    }
}
