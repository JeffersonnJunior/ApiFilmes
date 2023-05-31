using ApiFilmes.Data.Dtos;
using ApiFilmes.Models;
using AutoMapper;
//teste
namespace ApiFilmes.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }   

    }
}
