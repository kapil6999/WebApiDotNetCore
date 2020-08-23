using AutoMapper;
using Data.Models;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddStudentModel, StudentModel>().ReverseMap();
            CreateMap<StudentModel, Student>().ReverseMap();
        }
          
    }
}
