using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_assignment_2.configurations
{
    public class Course_instConfigurations :IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> CI)
        {
            CI.HasKey(x => new { x.Inst_ID, x.Course_ID });

         
            CI.HasOne(x => x.Instructor)
                .WithMany(x => x.CI)
                .HasForeignKey(x => x.Inst_ID);


            CI.HasOne(x => x.Course)
                .WithMany(x => x.Course_Insts)
                .HasForeignKey(x => x.Course_ID);

        }
    }
}
