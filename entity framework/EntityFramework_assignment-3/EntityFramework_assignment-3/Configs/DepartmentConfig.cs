using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_assignment_3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_assignment_3.Configs
{
    public class DepartmentConfig: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.Property(d => d.Id)
                 .UseIdentityColumn( 10,  10);
            D.HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
