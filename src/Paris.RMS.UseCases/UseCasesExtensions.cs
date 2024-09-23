namespace Paris.RMS.UseCases;

public static class UseCasesExtensions
{
    public static IServiceCollection RegisterUseCasesLayer(this IServiceCollection services)
    {

        services
            .RegisterMediator();

        return services;
    }

    internal static IServiceCollection RegisterMediator(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(AssemblyReference.Assembly);
            configuration.RegisterServicesFromAssembly(Domains.AssemblyReference.Assembly);
        });

        return services;
    }
}
