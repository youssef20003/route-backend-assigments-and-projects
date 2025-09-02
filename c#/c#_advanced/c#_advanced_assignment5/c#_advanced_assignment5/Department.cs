using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment5
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff; 
        }
        ///CallBackMethod
        public void RemoveStaff(object sender,  EmployeeLayOffEventArgs e)
        {
           Employee emp = sender as Employee;

            if (emp != null)
            {
                Staff.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Department due to {e.Cause}");
            }
        }

        public void ShowStaff()
        {
            Console.WriteLine($"Department {DeptName} Staff:");
            foreach (var e in Staff)
            {
                Console.WriteLine($" - Employee {e.EmployeeID}");
            }
        }
    }
}
