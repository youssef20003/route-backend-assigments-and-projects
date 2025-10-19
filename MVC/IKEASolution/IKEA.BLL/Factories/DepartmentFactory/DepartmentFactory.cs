using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.DAL.Models.Departmnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Factories.DepartmentFactory
{
    public static class DepartmentFactory
    {
        public static DepartmentDto toDepartmentDto(this Department d)
        {
            return new DepartmentDto()
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                code = d.Code
            };
        }

        public static Department ToDepartment(this CreatedDepartmnetDto dto)
        {
            return new Department()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedBy =1 ,
                LastModifedBy =1 ,
                CreatedOn = DateTime.Now,
                LastModifedOn = DateTime.Now,
                IsDeleted = false ,

            };
        }

        public static Department fromUpdatedDepartment(this UpdatedDepartmentDto dto)
        {
            return new Department()
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedBy = 1,
                LastModifedBy = 1,
                LastModifedOn = DateTime.Now,
                IsDeleted = false,

            };
        }

    }
}
