using AutoMapper;
using IKEA.BLL.Dtos.EmployeeDtos;
using IKEA.DAL.Models.Employee;
using IKEA.DAL.Reposatories.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.BLL.Common.Services.Attachments;
using IKEA.BLL.Services.EmployeeServices;
using IKEA.DAL.UOW;

namespace IKEA.BLL.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
      
        private readonly IUOW _unitOfWork;
        private readonly IMapper mapper;
        private readonly IAttachmentService _attachmentService;

        public EmployeeService(IUOW UnitOfWork , IMapper mapper , IAttachmentService attachmentService )
        {
           
            _unitOfWork = UnitOfWork;
            this.mapper = mapper;
            _attachmentService = attachmentService;
        }
        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var emps = _unitOfWork.EmployeeRepo.GetAll();
            var MappedEmps = mapper.Map<IEnumerable<EmployeeDto>>(emps);
            return MappedEmps;
        }

        public IEnumerable<EmployeeDto> GetSearchedEmployees(string? searchValue)
        {
            var emps = _unitOfWork.EmployeeRepo.GetAll(searchValue);
            var MappedEmps = mapper.Map<IEnumerable<EmployeeDto>>(emps);
            return MappedEmps;
        }

        public EmployeeDetailsDto GetById(int id)
        {
            var emp  = _unitOfWork.EmployeeRepo.GetById(id);
            var MappedEmp = mapper.Map<EmployeeDetailsDto>(emp);
            return MappedEmp;

        }

        public int AddEmployee(CreatedEmployeeDto CreatedEmployee)
        {
           var emp = mapper.Map<CreatedEmployeeDto , DAL.Models.Employee.Employee>(CreatedEmployee);

           if (CreatedEmployee.Image is not null)
           {
               emp.ImageName = _attachmentService.UploadImage(CreatedEmployee.Image, "Images");
           }
           emp.CreatedBy = 1;
           emp.CreatedOn = DateTime.Now;
           emp.LastModifedBy = 1;
           emp.LastModifedOn= DateTime.Now;
           _unitOfWork.EmployeeRepo.Add(emp);
           return _unitOfWork.Complete();
        }
        public int UpdateEmployee(UpdatedEmployeeDto dto)
        {
            var emp = mapper.Map<UpdatedEmployeeDto, DAL.Models.Employee.Employee>(dto);
            emp.LastModifedBy = 1;
            emp.LastModifedOn = DateTime.Now;

            if (dto.Image is not null)
            {
                if (emp.ImageName is not null)
                {
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", "Images", emp.ImageName);
                    _attachmentService.DeleteImage(filepath);
                }

                emp.ImageName = _attachmentService.UploadImage(dto.Image, "Images");
            }

            _unitOfWork.EmployeeRepo.Update(emp);
             return _unitOfWork.Complete();
        }

        public int DeleteEmployeet(int? id)
        {
            var emp = _unitOfWork.EmployeeRepo.GetById(id.Value);
            if (emp is not null)
            {
                if (emp.ImageName is not null)
                {
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", "Images" , emp.ImageName);
                    _attachmentService.DeleteImage(filepath);
                } 
                _unitOfWork.EmployeeRepo.Delete(id.Value);
                 return _unitOfWork.Complete();
            }
            else
            {
                return 0;
            }
        }
    }
}
