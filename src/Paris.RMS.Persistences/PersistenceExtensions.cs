using Paris.RMS.Persistences.Pipelines;

namespace Paris.RMS.Persistences;

public static class PersistenceExtensions
{
    public static IServiceCollection RegisterPersistenceLayer(this IServiceCollection services, IHostEnvironment environment)
    {

        services
            .RegisterDatabaseContext(environment)
            .RegisterUnitOfWorks()
            .RegisterRepository()
            .RegisterPipelines()
            ;

        return services;
    }
}
