namespace Paris.RMS.Infrastructures.Services;

public static class ServicesExtensions
{
    internal static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        //Services
        services.AddScoped<IUserContextService, UserContextService>();
        return services;
    }
}
