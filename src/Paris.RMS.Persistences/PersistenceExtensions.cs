using Paris.RMS.Persistences.Repositories;

namespace Paris.RMS.Persistences;

public static class PersistenceExtensions
{
    public static IServiceCollection RegisterPersistenceLayer(this IServiceCollection services, IHostEnvironment environment)
    {
        services
            .RegisterDatabaseContext(environment)
            .RegisterUnitOfWorks()
            .RegisterRepository()
            ;

        return services;
    }
}
