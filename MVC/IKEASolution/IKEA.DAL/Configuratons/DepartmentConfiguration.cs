using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Models.Departmnet;

namespace IKEA.DAL.Configuratons
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.Property(d => d.Id)
                .UseIdentityColumn(10, 10);

            D.Property(d => d.Name)
                .HasColumnType("varchar(20)");


            D.Property(d => d.Code)
                .HasColumnType("varchar(20)");


        

            D.Property(d => d.LastModifedBy)
                .HasComputedColumnSql("GetDate()");
        }
    }
}
