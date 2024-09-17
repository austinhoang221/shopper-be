namespace Paris.RMS.Persistences.UnitOfWorks;

public static class UnitOfWorkExtensions
{
    public static IServiceCollection AddUnitOfWorks(this IServiceCollection services)
    {

        return services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
    }
}
