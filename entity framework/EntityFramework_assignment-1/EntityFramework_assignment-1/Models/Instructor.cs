using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_1.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
    }
}
