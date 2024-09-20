namespace Paris.RMS.API.Abstractions;

[Authorize]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[Produces("application/json")]
public abstract class ApiController(IMediator mediator) : ControllerBase
{
    protected readonly IMediator Mediator = mediator;

    protected IActionResult Ok<TResponse>(IResult<TResponse> result)
        where TResponse : IResponse
        => base.Ok(result.Value);

    protected IActionResult NotFound(IResult result)
    {
        return result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException("Result was successful"),

            IValidationResult validationResult => base.NotFound
            (
                CreateProblemDetails
                (
                    ValidationError,
                    StatusCodes.Status404NotFound,
                    result.Error,
                    validationResult.ValidationErrors
                )
            ),

            _ => base.NotFound
            (
                CreateProblemDetails
                (
                    InvalidRequest,
                    StatusCodes.Status404NotFound,
                    result.Error
                )
            )
        };
    }

    protected IActionResult BadRequest(IResult result)
    {
        return result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException("Result was successful"),

            IValidationResult validationResult => base.BadRequest
            (
                CreateProblemDetails
                (
                    ValidationError,
                    StatusCodes.Status400BadRequest,
                    result.Error,
                    validationResult.ValidationErrors
                )
            ),

            _ => base.BadRequest
            (
                CreateProblemDetails
                (
                    InvalidRequest,
                    StatusCodes.Status400BadRequest,
                    result.Error
                )
            )
        };
    }

    protected IActionResult CreatedAtAction<TResponse>(IResult<TResponse> result, string? actionName)
        where TResponse : IResponse
    {
        return base.CreatedAtAction
        (
            actionName,
            new { id = result.Value.Id },
            result.Value
        );
    }
}
