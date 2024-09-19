namespace Paris.RMS.API.Products;

public static class ProductApis
{
    public static RouteGroupBuilder MapProductApisV1(this IEndpointRouteBuilder app)
    {
        var apiVersionSet = app.NewApiVersionSet()
            .HasApiVersion(new ApiVersion(1, 0))
            .ReportApiVersions()
            .Build();

        var api = app.MapGroup("api/v{version:apiVersion}/products")
            .WithApiVersionSet(apiVersionSet);

        return api;
    }
}
