using AutoMapper;
using IKEA.BLL.Dtos.EmployeeDtos;
using IKEA.DAL.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Common.MappingProfiles
{
    public class ProjectMappingProfile:Profile
    {
        public ProjectMappingProfile() 
        {
            // Existing mappings
            CreateMap<Employee, EmployeeDto>()
                .ForMember(d=>d.DepartmentName, options=>options.MapFrom(src=>src.Department!=null ? src.Department.Name : "na"))
                .ReverseMap();
            CreateMap<Employee, EmployeeDetailsDto>()
                .ForMember(d => d.DepartmentName, options => options.MapFrom(src => src.Department != null ? src.Department.Name : "na"))
                .ReverseMap();

            // DTO to DTO (if needed)
            CreateMap<CreatedEmployeeDto, EmployeeDto>().ReverseMap();
            CreateMap<UpdatedEmployeeDto, EmployeeDto>().ReverseMap();

            // **Important: DTO → Entity mapping**
            CreateMap<CreatedEmployeeDto, Employee>();
            CreateMap<UpdatedEmployeeDto, Employee>();

        }
    }
}
