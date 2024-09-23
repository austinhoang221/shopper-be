namespace Paris.RMS.Persistences.Pipelines;

internal static class PipelineExtensions
{
    internal static IServiceCollection RegisterPipelines(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.AddOpenBehavior(typeof(CommandTransactionPipeline<,>));
            configuration.AddOpenBehavior(typeof(CommandWithResponseTransactionPipeline<,>));
        });

        return services;
    }
}
