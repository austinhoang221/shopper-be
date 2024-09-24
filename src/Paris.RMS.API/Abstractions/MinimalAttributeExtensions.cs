namespace Paris.RMS.API.Abstractions;

public static class MinimalAttributeExtensions
{
    public static RouteHandlerBuilder AllowAnonymous(this RouteHandlerBuilder endpoint)
    {
        endpoint.WithMetadata(new AllowAnonymousAttribute());
        return endpoint;
    }
    public static RouteHandlerBuilder Authorize(this RouteHandlerBuilder endpoint, string? policy = null, string[]? roles = null, params string[] schemes)
    {
        var authorizeAttribute = new AuthorizeAttribute();

        if (!string.IsNullOrWhiteSpace(policy))
        {
            authorizeAttribute.Policy = policy;
        }

        if (roles != null && roles.Length != 0)
        {
            authorizeAttribute.Roles = string.Join(',', roles);
        }

        if (schemes != null && schemes.Length != 0)
        {
            authorizeAttribute.AuthenticationSchemes = string.Join(',', schemes);
        }

        endpoint.WithMetadata(authorizeAttribute);

        return endpoint;
    }
    public static RouteHandlerBuilder AddMetaData<T>(this RouteHandlerBuilder endpoint, string tag, string? summary = null, string? description = null)
    {
        endpoint.WithTags(tag);

        endpoint.WithMetadata(new SwaggerOperationAttribute(summary, description));

        endpoint.WithMetadata(new SwaggerResponseAttribute(200, type: typeof(T)))
                .WithMetadata(new SwaggerResponseAttribute(500, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(400, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(404, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(422, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(304, type: typeof(ProblemHttpResult)));

        return endpoint;
    }
    public static RouteHandlerBuilder AddMetaData(this RouteHandlerBuilder endpoint, string tag, string? summary = null, string? description = null)
    {
        endpoint.WithTags(tag);

        endpoint.WithMetadata(new SwaggerOperationAttribute(summary, description));

        endpoint.WithMetadata(new SwaggerResponseAttribute(500, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(400, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(404, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(422, type: typeof(ProblemHttpResult)))
                .WithMetadata(new SwaggerResponseAttribute(304, type: typeof(ProblemHttpResult)));

        return endpoint;
    }
}
