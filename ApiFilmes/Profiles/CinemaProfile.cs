using ApiFilmes.Data.Dtos;
using ApiFilmes.Models;
using AutoMapper;

namespace ApiFilmes.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.ReadEnderecoDto, opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
