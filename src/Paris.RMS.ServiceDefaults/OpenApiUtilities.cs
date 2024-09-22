namespace Paris.RMS.ServiceDefaults;

public static class OpenApiUtilities
{
    private const string JwtAuthorizationHeader = "Authorization";
    private const string ApiKeyAuthorizationHeader = "x-api-key";
    private const string JwtAuthorizationSecurityName = "oauth2";
    private const string Jwt = nameof(Jwt);
    private const string ApiKeyScheme = nameof(ApiKeyScheme);
    private const string Bearer = nameof(Bearer);
    private const string ApiKey = nameof(ApiKey);

    public static void AddJwtAuthorization(this SwaggerGenOptions options)
    {
        options.AddSecurityDefinition(JwtAuthorizationSecurityName, new OpenApiSecurityScheme
        {
            Description = $"Bearer authorization. Input: \"{{token}}\"",
            In = ParameterLocation.Header,
            Name = JwtAuthorizationHeader,
            Type = SecuritySchemeType.Http,
            BearerFormat = Jwt,
            Scheme = Bearer
        });

        //options.ConfigureRequirement(Bearer);
    }

    public static void AddApiKeyAuthorization(this SwaggerGenOptions options)
    {
        options.AddSecurityDefinition(ApiKey, new OpenApiSecurityScheme
        {
            Description = $"ApiKey authorization. Input: \"{{apikey}}\"",
            In = ParameterLocation.Header,
            Name = ApiKeyAuthorizationHeader,
            Type = SecuritySchemeType.ApiKey,
            Scheme = ApiKeyScheme
        });

        options.ConfigureRequirement(ApiKey);
    }

    private static void ConfigureRequirement(this SwaggerGenOptions options, string referenceId)
    {
        options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = referenceId
                },
                In = ParameterLocation.Header
            },
            []
        }
    });
    }
}
