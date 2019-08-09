using AutoMapper;
using WebAPITest.Entities;
using WebAPITest.Models;

namespace WebAPITest
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorDTO, Autor>().ReverseMap();
            CreateMap<LibroDTO, Libro>();
            CreateMap<AutorCreacionDTO, Autor>().ReverseMap();
        }
    }
}