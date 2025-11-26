using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.GenaricRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Reposatories.EmployeeRepo
{
    public interface IEmployeeRepo : IGenaricRepo <Employee>
    {
        public IEnumerable<Employee> GetAll(string? SearchValue);
    }
}
