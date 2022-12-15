using AutoMapper;
using Domain.DataTransferObject;
using Domain.DataTransferObject.AddDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lwa7dyProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DepertmentDTO, Depertment>().ReverseMap();
            CreateMap<Depertment, DepertmentAddDTO>().ReverseMap();

            CreateMap<EmployeeDto, Employee>().ReverseMap();
        }
    }
}