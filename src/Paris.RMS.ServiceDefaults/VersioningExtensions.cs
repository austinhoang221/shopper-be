namespace Paris.RMS.ServiceDefaults;

public static class VersioningExtensions
{
    public static IApiVersioningBuilder AddDefaultVersioning(this IServiceCollection services)
    {
        return services.AddApiVersioning(options =>
        {
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.ReportApiVersions = true;
            options.ApiVersionReader = ApiVersionReader.Default;
            //o.ApiVersionReader = ApiVersionReader.Combine(
            //    new QueryStringApiVersionReader("api-version"),
            //    new HeaderApiVersionReader("X-Version"),
            //    new MediaTypeApiVersionReader("ver"));
        });
    }
}
