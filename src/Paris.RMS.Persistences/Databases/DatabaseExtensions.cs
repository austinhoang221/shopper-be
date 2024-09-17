namespace Paris.RMS.Persistences.Databases;

internal static class DatabaseExtensions
{
    internal static IServiceCollection RegisterDatabaseContext(this IServiceCollection services, bool isDevelopment)
    {
        services
            .AddOptions<DatabaseOptions>()
            .BindConfiguration(DatabaseOptions.Name)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddOptions<ConnectionStringOptions>()
            .BindConfiguration(ConnectionStringOptions.Name)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services.AddSingleton<IValidateOptions<DatabaseOptions>, DatabaseOptionsValidator>();

        services.AddDbContextPool<ParisRmsDbContext>((serviceProvider, optionsBuilder) =>
        {
            var databaseOptions = services.GetOptions<DatabaseOptions>();
            var connectionStringOptions = services.GetOptions<ConnectionStringOptions>();

            optionsBuilder.UseMySql(connectionStringOptions.AdminParisRmsConnection,
                ServerVersion.AutoDetect(connectionStringOptions.AdminParisRmsConnection),
                options =>
                {
                    options.CommandTimeout(databaseOptions.CommandTimeout);

                    options.EnableRetryOnFailure(
                        databaseOptions.MaxRetryCount,
                        TimeSpan.FromSeconds(databaseOptions.MaxRetryDelay),
                        Array.Empty<int>());
                }
            );

            if (isDevelopment)
            {
                //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Debug);
                optionsBuilder.EnableDetailedErrors();
                optionsBuilder.EnableSensitiveDataLogging(); //DO NOT USE THIS IN PRODUCTION! Used to get parameter values. DO NOT USE THIS IN PRODUCTION!
                optionsBuilder.ConfigureWarnings(warningAction =>
                {
                    warningAction.Log(new EventId[]
                    {
                    CoreEventId.FirstWithoutOrderByAndFilterWarning,
                    CoreEventId.RowLimitingOperationWithoutOrderByWarning
                    });
                });


            }
        });

        if (isDevelopment)
        {
            // Apply database migration automatically. Note that this approach is not
            // recommended for production scenarios. Consider generating SQL scripts from
            // migrations instead.
            services.AddMigration<ParisRmsDbContext, UsersSeed>();
        }

        return services;
    }
}
