using Microsoft.Extensions.DependencyInjection;

namespace Paris.RMS.UseCases;

public static class UseCasesExtensions
{
    internal static IServiceCollection RegisterMediator(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(AssemblyReference.Assembly);
        });

        return services;
    }

    public static IServiceCollection RegisterUseCasesLayer(this IServiceCollection services)
    {

        services
            .RegisterMediator();

        return services;
    }
}
