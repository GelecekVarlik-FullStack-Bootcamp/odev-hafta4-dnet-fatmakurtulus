using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManSys.Entity.Dto;
using WorkManSys.Entity.Models;

namespace WorkManSys.Entity.Mapper
{
    public class MappingProfile :Profile

    {
        public MappingProfile()
        {
            CreateMap<Personal, DtoPersonal>().ReverseMap();
            CreateMap<Departmant, DtoDepartmant>().ReverseMap();
            CreateMap<Request, DtoRequest>().ReverseMap();
            CreateMap<Subject, DtoSubject>().ReverseMap();
            CreateMap<Role, DtoRole>().ReverseMap();
            CreateMap<Status, DtoStatus>().ReverseMap();
        }
    }
}
