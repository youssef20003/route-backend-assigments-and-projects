using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_assignment_3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public  string PhoneNumber { get; set; }
        public EmpAddress EmpAddress { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }



        public override string ToString()
        {
            return $"Employee: {Id} {EmpName}, Age: {Age}, Salary: {Salary}, " +
                   $"Email: {Email}, Phone: {PhoneNumber}, " +
                   $"Address: {EmpAddress?.Street}, {EmpAddress?.City}, {EmpAddress?.Country}, " +
                   $"DepartmentId: {DepartmentId}";
        }
    }
}
