using Microsoft.AspNetCore.Diagnostics;
using Serilog;
using WebApplication.Base;
using WebApplication.Data.Uow;
using WebApplication.Service.RestExtension;
using System.Net;
using WebApplication.Base.Jwt;
using WebApplication.Base.Response;
using WebApplication.Data.UnitOfWork;

namespace WebApplication.Service;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    public static JwtConfig JwtConfig { get; private set; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        JwtConfig = Configuration.GetSection("JwtConfig").Get<JwtConfig>();
        services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));

        services.AddCustomSwaggerExtension();
        services.AddDbContextExtension(Configuration);
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddMapperExtension();
        services.AddRepositoryExtension();
        services.AddServiceExtension();
        services.AddJwtExtension();

    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

        }

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.DefaultModelsExpandDepth(-1);
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proje");
            c.DocumentTitle = "Proje";
        });


        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    Log.Fatal(
                        $"MethodName={contextFeature.Endpoint} || " +
                        $"Path={contextFeature.Path} || " +
                        $"Exception={contextFeature.Error}"
                        );
                    await context.Response.WriteAsync(new ApiResponse("Internal Server Error.").ToString());
                }
            });
        });

        app.Use((context, next) =>
        {

            if (!string.IsNullOrEmpty(context.Request.Path) && context.Request.Path.Value.Contains("favicon"))
            {
                return next();
            }
           

            return next();
        });

       


        app.UseHttpsRedirection();

        // add auth 
        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
