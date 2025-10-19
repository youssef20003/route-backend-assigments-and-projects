using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.BLL.Factories.DepartmentFactory;
using IKEA.DAL.Reposatories.DepartmentRepo;

namespace IKEA.BLL.Services
{
    public class DepartmentService:IDepartmentInterface
    {
        private readonly IDepartmentReposatery _repo;
        public DepartmentService(IDepartmentReposatery Repostory)
        {
            _repo = Repostory;
        }

        public IEnumerable<DepartmentDto> GetAllDepartmants()
        {
            var Department = _repo.GetAll();

            //var MappedDepartment = Department.Select(d => new DepartmentDto
            //{
            //    Id = d.Id,
            //    Name = d.Name,
            //    Description = d.Description,
            //    code = d.Code

            //});

            List<DepartmentDto> MappedDepartment = new List<DepartmentDto>();

            foreach (var department in Department) {
                var Mapped = department.toDepartmentDto();
                MappedDepartment.Add(Mapped);
            }
            return MappedDepartment;
        }

        public DepartmantDetailsDto GetById(int id)
        {
            var departmant = _repo.GetById(id);

            if (departmant == null) {
                return null;
            }
            else
            {
                var departmentoreturn = new DepartmantDetailsDto
                {
                    Id = departmant.Id,
                    Name = departmant.Name,
                    Code = departmant.Code,
                    Description = departmant.Description,
                    CreatedOn = departmant.CreatedOn,
                    CreatedBy = departmant.CreatedBy,
                    LastModifedOn = departmant.LastModifedOn,
                    LastModifedBy = departmant.LastModifedBy,
                };
                return departmentoreturn;
            }
        }

        public int AddDepartmant(CreatedDepartmnetDto createdDepartmnet)
        {
            var dept = createdDepartmnet.ToDepartment();

           return _repo.Add(dept);

        }

        public int UpdateDepartment (UpdatedDepartmentDto dto)
        {
            var dept = dto.fromUpdatedDepartment();

            return _repo.Update(dept);
        }

        public int DeleteDepartment(int id) { 
        
          return _repo.Delete(id);
        }

    }
}
