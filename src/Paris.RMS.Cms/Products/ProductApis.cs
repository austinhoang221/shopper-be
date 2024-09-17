namespace Paris.RMS.Cms.Products;

public static class ProductApis
{
    public static RouteGroupBuilder MapProductApisV1(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("api/products").HasApiVersion(1.0);

        return api;
    }
}
