using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment5
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();


        public void AddMember(Employee E)
        {
           Members.Add(E);
           E.EmployeeLayOff += RemoveMember;
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee emp = sender as Employee;
            if (emp != null && e.Cause == LayOffCause.VacationStockNegative || emp != null && e.Cause == LayOffCause.AgeAbove60)
            {
                Members.Remove(emp);
                Console.WriteLine($"Employee {emp.EmployeeID} removed from Club due to {e.Cause}");
            }


        }

        public void ShowMembers()
        {
            Console.WriteLine($"Club {ClubName} Members:");
            foreach (var e in Members)
            {
                Console.WriteLine($" - Employee {e.EmployeeID}");
            }
            if (Members.Count == 0) Console.WriteLine(" (No members left)");
        }
    }
}
