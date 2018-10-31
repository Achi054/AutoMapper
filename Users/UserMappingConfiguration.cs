using System;
using AutoMapper;
using Users.Dto;
using Users.Entities;

namespace Users
{
    internal class UserMappingConfiguration : Profile
    {       
        public UserMappingConfiguration()
        {
            CreateMap<EmployeeType, EmployeeTypeDto>().ConvertUsing(MapEmployeeType);
            CreateMap<EmployeeTypeDto, EmployeeType>().ConvertUsing(MapEmployeeTypeDto);

            CreateMap<Employee, EmployeeDto>()
            .ForMember(desc => desc.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(desc => desc.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(desc => desc.Salary, opt => opt.MapFrom(src => src.Salary));

            CreateMap<EmployeeDto, Employee>()
            .ConstructUsing(src => new Employee(src.Id, src.Name, null, null, src.Salary, MapEmployeeTypeDto(src.Type)))
            .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }

        static EmployeeType MapEmployeeTypeDto(EmployeeTypeDto type)
        {
            switch (type)
            {
                case EmployeeTypeDto.Contract:
                    return EmployeeType.Contract;
                case EmployeeTypeDto.Permanent:
                    return EmployeeType.Permanent;
                default:
                    throw new NotSupportedException("Employee type is not support.");
            }
        }

        static EmployeeTypeDto MapEmployeeType(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Contract:
                    return EmployeeTypeDto.Contract;
                case EmployeeType.Permanent:
                    return EmployeeTypeDto.Permanent;
                default:
                    throw new NotSupportedException("Employee type is not support.");
            }
        }
    }
}