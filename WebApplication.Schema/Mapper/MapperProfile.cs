
using AutoMapper;
using System.Security.Principal;
using WebApplication.Data;
using WebApplication.Data.Domain;
using WebApplication.Schema.Product;

namespace WebApplication.Schema.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Category, CategoryResponse>();
        CreateMap<CategoryRequest, Category>();

        CreateMap<Data.Domain.Product, ProductResponse>();
        CreateMap<ProductRequest, Data.Domain.Product>();

        CreateMap<User, UserResponse>();
        CreateMap<UserRequest, User>();

        
    }


}

