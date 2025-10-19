using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_4.Models
{
    public class Topic
    {


        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

        public override string ToString()
        {
            return $"Topic: {ID} - {Name}";
        }

    }
}
