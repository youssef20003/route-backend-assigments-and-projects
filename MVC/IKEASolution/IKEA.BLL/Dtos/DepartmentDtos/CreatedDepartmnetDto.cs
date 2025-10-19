using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dtos.DepartmentDtos
{
    public class CreatedDepartmnetDto
    {
        [Required(ErrorMessage ="Name is Required") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is Required")]
        public string Code { get; set; }
       
        public string Description { get; set; }
    }
}
