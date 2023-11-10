using AutoMapper;
using HumorHub.Data.Dtos;
using HumorHub.Models;

namespace HumorHub.Profiles;

public class JokeProfile : Profile
{
    public JokeProfile()
    {
        CreateMap<Joke, ReadJokeDto>();
        CreateMap<CreateJokeDto, Joke>();
        CreateMap<UpdateJokeDto, Joke>();
    }
}