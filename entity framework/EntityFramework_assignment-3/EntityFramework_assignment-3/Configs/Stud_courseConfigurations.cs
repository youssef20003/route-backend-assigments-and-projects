using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_assignment_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_assignment_2.configurations
{
    public class Stud_courseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> s)
        {
            s.HasKey(s => new { s.Student_ID, s.Course_ID });

            s.HasOne(s => s.Student)
                .WithMany(s => s.StudCourse)
                .HasForeignKey(s => s.Student_ID);

            s.HasOne(s => s.Course)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(s => s.Course_ID);



        }
    }
}
