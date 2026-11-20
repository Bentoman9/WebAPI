using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class CursoPerfil : Profile
    {
        public CursoPerfil()
        {
            CreateMap<Curso, CursoDto>();
            CreateMap<CursoDto, Curso>();
        }
    }
}
