using Carter;
using Dapper;
using MinimalApi.Dto;
using Npgsql;

namespace MinimalApi.Module;

public class PackageModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/packages", async (NpgsqlConnection db, RegisterPackageDto dto) =>
        {
            var newPackage = await db.QueryFirstOrDefaultAsync<RegisterPackageDto>
            (
                @"INSERT INTO package(code, country, description) 
                  VALUES(@code, @country, @description) 
                  RETURNING *;", dto);
            return Results.Created($"/package/{newPackage.PackageId}", newPackage);
        });
    }
}