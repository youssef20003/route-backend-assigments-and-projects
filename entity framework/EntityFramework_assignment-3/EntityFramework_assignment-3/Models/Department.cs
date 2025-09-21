using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_3.Models
{
    public class Department
    {
        public Department(string Name)
        {
            this.Name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public override string ToString()
        {
            return $"Department Id: {Id}, Name: {Name}";
        }
    }
}
