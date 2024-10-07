using Paris.RMS.Domains.Systems.Repositories;
using Paris.RMS.Persistences.Repositories.Systems;

namespace Paris.RMS.Persistences.Repositories;

public static class RepositoryExtensions
{
    public static IServiceCollection RegisterRepository(this IServiceCollection services)
    {
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductTagRepository, ProductTagRepository>();
        services.AddScoped<IAllCodeRepository, AllCodeRepository>();

        return services;
    }
}
