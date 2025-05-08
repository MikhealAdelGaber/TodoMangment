using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMangment.BLL.DTOs;
using TodoMangment.DAL.Entite;

namespace TodoMangment.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoCreateDto, Todo>();
            CreateMap<TodoUpdateDTO, Todo>();
        }
    }
}
