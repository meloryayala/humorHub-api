using AutoMapper;
using HumorHub.Data.Dtos;
using HumorHub.Models;

namespace HumorHub.Profiles;

public class JokeProfile : Profile
{
    public JokeProfile()
    {
        CreateMap<Joke, ReadJokeDto>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
        CreateMap<CreateJokeDto, Joke>();
        CreateMap<UpdateJokeDto, Joke>();
    }
}