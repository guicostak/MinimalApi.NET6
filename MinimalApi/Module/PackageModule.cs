using Carter;
namespace MinimalApi.Module;

public class PackageModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/packages", () => "Teste");
    }
}

