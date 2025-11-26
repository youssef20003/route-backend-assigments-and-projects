using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.BLL.Factories.DepartmentFactory;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.UOW;

namespace IKEA.BLL.Services.Department
{
    public class DepartmentService:IDepartmentInterface
    {
        private readonly IUOW _unitOfWork;
       
        public DepartmentService(IUOW UnitOfWork)
        {
            _unitOfWork = UnitOfWork;
            
        }

        public IEnumerable<DepartmentDto> GetAllDepartmants()
        {
            var Department = _unitOfWork.DepartmentRepo.GetAll();

            //var MappedDepartment = Department.Select(d => new DepartmentDto
            //{
            //    Id = d.Id,
            //    Name = d.Name,
            //    Description = d.Description,
            //    code = d.Code

            //});

            List<DepartmentDto> MappedDepartment = new List<DepartmentDto>();

            foreach (var department in Department)
            {
                var Mapped = department.toDepartmentDto();
                MappedDepartment.Add(Mapped);
            }
            return MappedDepartment;
        }

        public DepartmantDetailsDto GetById(int id)
        {
            var departmant = _unitOfWork.DepartmentRepo.GetById(id);

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

            _unitOfWork.DepartmentRepo.Add(dept);
            return _unitOfWork.Complete();

        }

        public int UpdateDepartment (UpdatedDepartmentDto dto)
        {
            var dept = dto.fromUpdatedDepartment();

             _unitOfWork.DepartmentRepo.Update(dept);
             return _unitOfWork.Complete();
        }

        public int DeleteDepartment(int id) { 
        
           _unitOfWork.DepartmentRepo.Delete(id);
           return _unitOfWork.Complete();
        }

    }
}
