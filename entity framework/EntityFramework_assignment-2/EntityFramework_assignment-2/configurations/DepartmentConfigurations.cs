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
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
          
            D.HasKey(d => d.ID);

            D.Property(d => d.ID)
                .HasColumnName("DeptId")
                .UseIdentityColumn(10, 10);

            D.Property(d => d.Name)
                .IsRequired(true)
                .HasMaxLength(20)
                .HasColumnName("deptName")
                .HasColumnType("varchar");

            D.HasMany(d => d.Instructors).WithOne(i => i.Department)
                .HasForeignKey(x => x.Dept_ID);



        }
    }
    
}
