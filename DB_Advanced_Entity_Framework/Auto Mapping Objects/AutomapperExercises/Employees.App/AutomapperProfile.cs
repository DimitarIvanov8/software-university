﻿using AutoMapper;
using Employees.Models;
using Employees.DtoModels;

namespace Employees.App
{
    class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeePersonalDto>();
        }
    }
}
