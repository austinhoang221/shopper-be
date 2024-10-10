namespace Paris.RMS.ServiceDefaults.Abstractions;

public static class ProblemDetailsUtilities
{
    /// <summary>
    /// Create ProblemDetails for Result pattern
    /// </summary>
    /// <param name="title">See also: <see cref="ProblemDetails.Title"/></param>
    /// <param name="status">See also: <see cref="ProblemDetails.Status"/></param>
    /// <param name="error">See also: <see cref="ProblemDetails.Detail"/></param>
    /// <param name="errors">See also: <see cref="ProblemDetails.Extensions"/></param>
    /// <param name="context">See also: <see cref="HttpContext"/></param>
    /// <returns></returns>
    public static ProblemDetails CreateProblemDetails
    (
        string title,
        int status,
        Error error,
        Error[]? errors = null,
        HttpContext? context = null
    )
    {
        var problemDetails = new ProblemDetails()
        {
            Type = error.Code,
            Title = title,
            Detail = error.Message,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };

        if (context is not null)
        {
            problemDetails.Extensions.Add(RequestId, context.TraceIdentifier);
            problemDetails.Instance = context.Request.Path;
        }

        return problemDetails;
    }

    /// <summary>
    /// Create ProblemDetails for Result pattern
    /// </summary>
    /// <param name="title">See also: <see cref="ProblemDetails.Title"/></param>
    /// <param name="status">See also: <see cref="ProblemDetails.Status"/></param>
    /// <param name="errors">See also: <see cref="ProblemDetails.Extensions"/></param>
    /// <returns></returns>
    public static ProblemDetails CreateProblemDetails
    (
        string type,
        string title,
        int status,
        IList<string> errors
    )
    {
        var problemDetails = new ProblemDetails()
        {
            Type = type,
            Title = title,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };

        return problemDetails;
    }

    /// <summary>
    /// Create ProblemDetails for ExceptionHandler
    /// </summary>
    /// <param name="title">See also: <see cref="ProblemDetails.Title"/></param>
    /// <param name="message">See also: <see cref="ProblemDetails.Detail"/></param>
    /// <param name="type">See also: <see cref="ProblemDetails.Type"/></param>
    /// <param name="status">See also: <see cref="ProblemDetails.Status"/></param>
    /// <param name="errors">See also: <see cref="ProblemDetails.Extensions"/></param>
    /// <param name="context">See also: <see cref="HttpContext"/></param>
    /// <returns></returns>
    public static ProblemDetails CreateProblemDetails
    (
        string title,
        string message,
        string type,
        int status,
        Error[]? errors = null,
        HttpContext? context = null
    )
    {
        var problemDetails = new ProblemDetails()
        {
            Title = title,
            Type = type,
            Detail = message,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };

        if (context is not null)
        {
            problemDetails.Extensions.Add(RequestId, context.TraceIdentifier);
            problemDetails.Instance = context.Request.Path;
        }

        return problemDetails;
    }
}
