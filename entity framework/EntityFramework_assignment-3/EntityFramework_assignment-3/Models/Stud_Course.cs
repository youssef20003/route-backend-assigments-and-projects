using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_3.Models
{
    public class Stud_Course
    {
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public override string ToString()
        {
            return $"Stud_Course: Student {Student_ID}, Course {Course_ID}, Grade: {Grade}";
        }

    }
}
