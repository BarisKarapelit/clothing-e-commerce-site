using AutoMapper;
using WebApplication.Schema.Mapper;

namespace WebApplication.Service.RestExtension;

public static class MapperExtension //kk
{
    public static void AddMapperExtension(this IServiceCollection services)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MapperProfile());
        });
        services.AddSingleton(config.CreateMapper());
    }
}
