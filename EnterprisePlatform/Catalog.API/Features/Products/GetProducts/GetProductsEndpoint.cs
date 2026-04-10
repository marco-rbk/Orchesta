using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Catalog.API.Features.Products.GetProducts;

public static class GetProductsEndpoint
{
    public static void MapGetProductsEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/products", () =>
        {
            CatalogMetrics.ProductsRetrievedCounter.Add(1);

            return new[]
            {
                new ProductDto(1, "Enterprise Product A", 99.99m),
                new ProductDto(2, "Enterprise Product B", 149.50m)
            };
        })
        .WithName("GetProducts")
        .WithTags("Products");
    }
}
