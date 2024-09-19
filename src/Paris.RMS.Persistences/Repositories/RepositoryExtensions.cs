namespace Paris.RMS.Persistences.Repositories;

public static class RepositoryExtensions
{
    public static IServiceCollection RegisterRepository(this IServiceCollection services)
        => services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
}
