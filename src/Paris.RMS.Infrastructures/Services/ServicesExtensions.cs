namespace Paris.RMS.Infrastructures.Services;

public static class ServicesExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        //Services
        services.AddScoped<IUserContextService, UserContextService>();
        services.AddScoped<IJwtTokenProvider, JwtTokenProvider>();

        // JWT Token
        services.ConfigureOptions<AuthenticationOptionsSetup>();
        services.ConfigureOptions<BearerAuthenticationOptionsSetup>();
        return services;
    }
}
