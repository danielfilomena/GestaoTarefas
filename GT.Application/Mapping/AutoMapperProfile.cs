using AutoMapper;
using GT.Application.Dtos;
using GT.Domain.Entities;

namespace GT.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {


        public AutoMapperProfile()
        {

            CreateMap<UsuarioDto, Usuario>().ReverseMap();
            CreateMap<TarefaDto, Tarefa>().ReverseMap();

        }
        


    }
}
