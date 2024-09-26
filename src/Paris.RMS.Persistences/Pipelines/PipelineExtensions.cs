namespace Paris.RMS.Persistences.Pipelines;

internal static class PipelineExtensions
{
    internal static IServiceCollection RegisterPipelines(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(UseCases.AssemblyReference.Assembly);
            configuration.AddOpenBehavior(typeof(CommandTransactionPipeline<,>));
            configuration.AddOpenBehavior(typeof(CommandWithResponseTransactionPipeline<,>));
            //configuration.AddOpenBehavior(typeof(QueryTransactionPipeline<,>));
        });

        return services;
    }
}
