using Paris.RMS.UseCases.Users.Login;

namespace Paris.RMS.API.Users;

[ApiVersion("1.0")]
public class UsersController(IMediator mediator) : ApiController(mediator)
{
    /// <summary>
    /// The user login to the system
    /// </summary>
    /// <param name="command"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>The token of the user</returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the token</response>
    /// <response code="400">Return the list of errors</response>
    [HttpPost("[action]")]
    [ProducesResponseType<UserLoginResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Login([FromBody] UserLoginCommand command, CancellationToken cancellationToken)
        => await Result.Success(command)
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(Ok, BadRequest);
}
