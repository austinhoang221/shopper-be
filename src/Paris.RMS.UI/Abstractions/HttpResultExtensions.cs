using Microsoft.AspNetCore.Http;

namespace Paris.RMS.UI.Abstractions;

public static class HttpResultExtensions
{
    public static async Task<IHttpResult> HandleCreated<TResponse>(this Task<IResult<TResponse>> resultTask, string routeName)
        where TResponse : IResponse
    {
        var result = await resultTask;

        return result.IsSuccess ? result.ToCreated(routeName) : result.ToBadRequest();
    }

    public static async Task<IHttpResult> HandleGet<TResponse>(this Task<IResult<TResponse>> resultTask)
        where TResponse : IResponse
    {
        var result = await resultTask;

        return result.IsSuccess ? result.ToOk() : result.ToNotFound();
    }

    public static async Task<IHttpResult> HandleNotCreated<TResponse>(this Task<IResult<TResponse>> resultTask)
        where TResponse : IResponse
    {
        var result = await resultTask;

        return result.IsSuccess ? result.ToOk() : result.ToBadRequest();
    }

    public static ProblemHttpResult ToBadRequest<TResponse>(this IResult<TResponse> result)
    {
        return result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException("Result was successful"),

            IValidationResult validationResult =>
                TypedResults
                    .Problem(title: ValidationError,
                        statusCode: StatusCodes.Status400BadRequest,
                        type: result.Error.Code,
                        detail: result.Error.Message,
                        extensions: validationResult.ToDictionary()
                    ),

            _ => TypedResults
                .Problem(title: InvalidRequest,
                    statusCode: StatusCodes.Status400BadRequest,
                    type: result.Error.Code
            )
        };
    }

    public static Ok<TResponse> ToOk<TResponse>(this IResult<TResponse> result)
        where TResponse : IResponse
    {
        return TypedResults.Ok(result.Value);
    }

    public static ProblemHttpResult ToNotFound<TResponse>(this IResult<TResponse> result)
    {
        return result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException("Result was successful"),

            IValidationResult validationResult =>
                TypedResults
                    .Problem(title: ValidationError,
                        statusCode: StatusCodes.Status404NotFound,
                        type: result.Error.Code,
                        detail: result.Error.Message,
                        extensions: validationResult.ToDictionary()
                    ),

            _ => TypedResults
                .Problem(title: InvalidRequest,
                    statusCode: StatusCodes.Status404NotFound,
                    type: result.Error.Code
            )
        };
    }

    public static Created<TResponse> ToCreated<TResponse>(this IResult<TResponse> result, string? routeName = null)
        where TResponse : IResponse
    {
        return TypedResults.Created($"{routeName}/{result.Value.Id}", result.Value);
    }
}
