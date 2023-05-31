using WebApplication.Operation;

namespace WebApplication.Service.RestExtension;
public static class ServiceExtension
{
    public static void AddServiceExtension(this IServiceCollection services)
    {
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IUserService, UserService>();


        
    }
}
