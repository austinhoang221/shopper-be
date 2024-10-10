namespace Paris.RMS.ServiceDefaults;

internal sealed class ExceptionHandler(ILogger<ExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        var problemDetails = exception switch
        {
            BadRequestException br => CreateProblemDetails(
                title: "BadRequest",
                message: br.Message,
                type: "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1",
                status: StatusCodes.Status400BadRequest,
                errors: br.Errors,
                context: httpContext
            ),
            _ => CreateProblemDetails(
                title: "InternalServerError",
                message: string.Empty,
                type: "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1",
                status: StatusCodes.Status500InternalServerError,
                errors: null,
                context: httpContext
            )
        };

        string url = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString} | {httpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier)}";
        var exceptionHandlerPathFeature = httpContext.Features.Get<IExceptionHandlerPathFeature>();
        logger.LogError(exceptionHandlerPathFeature?.Error, "Error url: {url}", url);

        httpContext.Response.StatusCode = problemDetails.Status!.Value;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
