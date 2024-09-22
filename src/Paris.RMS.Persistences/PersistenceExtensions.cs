namespace Paris.RMS.Persistences;

public static class PersistenceExtensions
{
    public static IServiceCollection RegisterPersistenceLayer(this IServiceCollection services, IHostEnvironment environment)
    {
        //Identity
        services.AddIdentityCore<ApplicationUser>(options =>
        {
            options.Password.RequireNonAlphanumeric = false;
        })
            .AddRoles<IdentityRole>()
            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddSignInManager<SignInManager<ApplicationUser>>()
            .AddRoleValidator<RoleValidator<IdentityRole>>()
            .AddEntityFrameworkStores<ParisRmsDbContext>();

        services
            .RegisterDatabaseContext(environment)
            .RegisterUnitOfWorks()
            .RegisterRepository()
            ;

        return services;
    }
}
