using ApiECommerce.Models.Dtos;
using AutoMapper;

namespace ApiECommerce.Mapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
    }
}
