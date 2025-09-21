using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_3.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
       

        public virtual ICollection<Stud_Course> StudCourses { get; set; }

       

        public override string ToString()
        {
            return $"Course: {ID} - {Name}, Duration: {Duration}";
        }

    }
}
