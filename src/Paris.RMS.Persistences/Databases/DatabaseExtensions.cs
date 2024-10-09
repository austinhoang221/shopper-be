namespace Paris.RMS.Persistences.Databases;

internal static class DatabaseExtensions
{
    internal static IServiceCollection RegisterDatabaseContext(this IServiceCollection services, IHostEnvironment environment)
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

            optionsBuilder.UseMySql(connectionStringOptions.ParisRmsConnection,
                ServerVersion.AutoDetect(connectionStringOptions.ParisRmsConnection),
                options =>
                {
                    options.CommandTimeout(databaseOptions.CommandTimeout);

                    options.EnableRetryOnFailure(
                        databaseOptions.MaxRetryCount,
                        TimeSpan.FromSeconds(databaseOptions.MaxRetryDelay),
                        []);
                }
            );

            if (environment.IsDevelopment())
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

        if (environment.IsDevelopment())
        {
            // Apply database migration automatically. Note that this approach is not
            // recommended for production scenarios. Consider generating SQL scripts from
            // migrations instead.
            services.AddMigration<ParisRmsDbContext, UsersSeed>();
        }

        services.AddIdentity<ApplicationUser, IdentityRole<Ulid>>()
            .AddEntityFrameworkStores<ParisRmsDbContext>()
            .AddDefaultTokenProviders();

        services.AddScoped<IDbContext, ParisRmsDbContext>();

        return services;
    }
}
