namespace Paris.RMS.Persistences.Repositories;

public static class RepositoryExtensions
{
    public static IServiceCollection RegisterRepository(this IServiceCollection services)
    {
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductTagRepository, ProductTagRepository>();

        return services;
    }
}
