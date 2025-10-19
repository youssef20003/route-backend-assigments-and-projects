using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_4.Models
{
    public class Student
    {
       
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }

        public ICollection<Stud_Course> StudCourse { get; set; }

        public Department Department { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {FName} {LName}, Age: {Age}, Address: {Address}, Dep_Id: {Dep_Id}";
        }
    }
}
