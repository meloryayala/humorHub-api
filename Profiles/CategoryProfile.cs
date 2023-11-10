using AutoMapper;
using HumorHub.Data.Dtos;
using HumorHub.Models;
using Microsoft.AspNetCore.WebUtilities;

namespace HumorHub.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, ReadCategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();
    }
}