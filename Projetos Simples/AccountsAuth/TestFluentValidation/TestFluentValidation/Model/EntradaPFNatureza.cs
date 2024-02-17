using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace TestFluentValidation.Model
{
    public class EntradaPFNatureza
    {

        public string CPF { get; set; }
        public string Token { get; set; }
    }


public static class EntradaPFNaturezaEndpoints
{
	public static void MapEntradaPFNaturezaEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/EntradaPFNatureza").WithTags(nameof(EntradaPFNatureza));

        group.MapGet("/", () =>
        {
            return new [] { new EntradaPFNatureza() };
        })
        .WithName("GetAllEntradaPFNaturezas")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new EntradaPFNatureza { ID = id };
        })
        .WithName("GetEntradaPFNaturezaById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, EntradaPFNatureza input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateEntradaPFNatureza")
        .WithOpenApi();

        group.MapPost("/", (EntradaPFNatureza model) =>
        {
            //return TypedResults.Created($"/api/EntradaPFNaturezas/{model.ID}", model);
        })
        .WithName("CreateEntradaPFNatureza")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new EntradaPFNatureza { ID = id });
        })
        .WithName("DeleteEntradaPFNatureza")
        .WithOpenApi();
    }
}}
