using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_4.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        [Column("Address")]                    
        [MaxLength(200)]
        public string Adress { get; set; }
        
        [Range(0, double.MaxValue)]
        public decimal HourRate { get; set; }
        [ForeignKey("Department")]
        public int Dept_ID { get; set; }

        public Department Department { get; set; }

        public ICollection<Course_Inst> CI { get; set; }

        public override string ToString()
        {
            return $"Instructor: {ID} - {Name}, Salary: {Salary}, Bonus: {Bouns}, Dept: {Dept_ID}";
        }


    }
}
