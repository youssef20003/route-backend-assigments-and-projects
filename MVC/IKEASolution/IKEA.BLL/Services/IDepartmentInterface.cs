using IKEA.BLL.Dtos.DepartmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services
{
    public interface IDepartmentInterface
    {

        public IEnumerable<DepartmentDto> GetAllDepartmants();

        public DepartmantDetailsDto GetById(int id);

        public int AddDepartmant(CreatedDepartmnetDto createdDepartmnet);

        public int UpdateDepartment(UpdatedDepartmentDto dto);

        public int DeleteDepartment(int id);
    }
}
