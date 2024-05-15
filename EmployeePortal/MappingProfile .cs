using AutoMapper;
using EmployeePortal.DTOs;
using EmployeePortal.Models;

namespace EmployeePortal
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeCreateDto>().ReverseMap(); ;
            CreateMap<Employee,EmployeeUpdateDto>().ReverseMap(); ;
        }

    }
}
