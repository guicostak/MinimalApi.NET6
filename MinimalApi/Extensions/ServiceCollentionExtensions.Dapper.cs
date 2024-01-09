using System.Data.SqlClient;
namespace MinimalApi.Extensions;

public static partial class ServiceCollentionExtensions
{
    public static WebApplicationBuilder AddDapper(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(_ => new SqlConnection(builder.Configuration.GetConnectionString("Postgre")));
        return builder;
    }
}
