namespace Paris.RMS.ServiceDefaults;

public static class VersioningExtensions
{
    public static IApiVersioningBuilder AddDefaultVersioning(this IServiceCollection services)
    {
        return services.AddApiVersioning(o =>
        {
            o.AssumeDefaultVersionWhenUnspecified = true;
            o.DefaultApiVersion = new ApiVersion(1, 0);
            o.ReportApiVersions = true;
            o.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("api-version"),
                new HeaderApiVersionReader("X-Version"),
                new MediaTypeApiVersionReader("ver"));
        });
    }
}
