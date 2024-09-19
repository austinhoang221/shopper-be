namespace Paris.RMS.Contracts.BuildingBlocks.Results;

public static class ResultExtensions
{
    public static IResult<T> Ensure<T>(this IResult<T> result, Func<T, bool> predicate, Error error)
    {
        if (result.IsFailure)
        {
            return result;
        }

        return result.IsSuccess && predicate(result.Value) ? result : Result.Failure<T>(error);
    }

    public static IResult<TOut> Map<TIn, TOut>(this IResult<TIn> result, Func<TIn, TOut> func) =>
        result.IsSuccess ? func(result.Value) : Result.Failure<TOut>(result.Error);

    public static async Task<IResult> CallHandler<TIn>(this IResult<TIn> result, Func<TIn, Task<IResult>> func) =>
        result.IsSuccess ? await func(result.Value) : Result.Failure(result.Error);

    public static async Task<IResult<TResponse>> CallHandler<TIn, TResponse>(this IResult<TIn> result, Func<TIn, Task<IResult<TResponse>>> func) =>
        result.IsSuccess ? await func(result.Value) : Result.Failure<TResponse>(result.Error);

    public static async Task<TActionResult> Match<TActionResult>(
        this Task<IResult> resultTask,
        Func<IResult, TActionResult> onSuccess,
        Func<IResult, TActionResult> onFailure)
    {
        IResult result = await resultTask;

        return result.IsSuccess ? onSuccess(result) : onFailure(result);
    }

    public static async Task<TActionResult> Match<TResponse, TActionResult>(
        this Task<IResult<TResponse>> resultTask,
        Func<IResult, TActionResult> onSuccess,
        Func<IResult, TActionResult> onFailure)
    {
        IResult<TResponse> result = await resultTask;

        return result.IsSuccess ? onSuccess(result) : onFailure(result);
    }
}
