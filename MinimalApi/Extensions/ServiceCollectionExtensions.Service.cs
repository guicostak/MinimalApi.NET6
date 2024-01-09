namespace MinimalApi.Extensions;

public static partial class ServiceCollectionExtensions
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors();
            
        return builder;
    }

    public static IApplicationBuilder UseServices(this IApplicationBuilder app) 
    { 
        app.UseCors(c =>
        {
        c.AllowAnyMethod();
        c.AllowAnyHeader();
        c.AllowCredentials();
        c.SetIsOriginAllowed((host) => true);
        });

        return app;
    }
}

