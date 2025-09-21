using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_assignment_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework_assignment_3.Configs
{
    public class EmployeeConfig: IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            E.OwnsOne(e => e.EmpAddress);
        }
    }
}
