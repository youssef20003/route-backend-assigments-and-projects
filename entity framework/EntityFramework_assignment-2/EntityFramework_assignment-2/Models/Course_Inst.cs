using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_2.Models
{
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }

        public override string ToString()
        {
            return $"Course_Inst: Instructor {Inst_ID}, Course {Course_ID}, Evaluate: {evaluate}";
        }

    }
}
