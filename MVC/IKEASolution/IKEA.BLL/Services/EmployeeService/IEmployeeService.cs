using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.BLL.Dtos.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        public IEnumerable<EmployeeDto> GetAllEmployees();
        public IEnumerable<EmployeeDto> GetSearchedEmployees(string? searchValue);
        public EmployeeDetailsDto GetById(int id);
        public int AddEmployee(CreatedEmployeeDto CreatedEmployee);
        public int UpdateEmployee(UpdatedEmployeeDto dto);
        public int DeleteEmployeet(int? id);
    }
}
