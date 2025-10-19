using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dtos.DepartmentDtos
{
    public class DepartmantDetailsDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifedBy { get; set; }
        public DateTime LastModifedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
