using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Models.Shared;

namespace IKEA.DAL.Configuratons
{
    public class EmployeeConfigurations:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(d => d.Name)
                .HasColumnType("varchar(50)");
            builder.Property(d => d.Address)
                .HasColumnType("varchar(150)");
            builder.Property(d => d.Salary)
                .HasColumnType("decimal(10,3)");
            builder.Property(d => d.Gender)
                .HasConversion((empgender) => empgender.ToString(),
                    (gender) => (Gender)Enum.Parse(typeof(Gender), gender));
            builder.Property(d => d.EmployeeType)
                .HasConversion((emptype) => emptype.ToString(),
                    (type) => (EmployeeType)Enum.Parse(typeof(EmployeeType), type));
        }
    }
}
