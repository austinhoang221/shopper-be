using Paris.RMS.API.Users.ViewModels.V1;
using Paris.RMS.UseCases.Users.Login;
using Paris.RMS.UseCases.Users.Register;

namespace Paris.RMS.API.Users;

[AllowAnonymous]
[ApiVersion("1.0")]
public class UsersController(IMediator mediator) : ApiController(mediator)
{
    /// <summary>
    /// The user login to the system
    /// </summary>
    /// <param name="request"></param>
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
    public async Task<IActionResult> Login([FromBody] UserLoginRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UserLoginCommand(request.Username, request.Password))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(Ok, BadRequest);

    [HttpPost("[action]")]
    [ProducesResponseType<UserRegisterResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UserRegisterCommand(request.Email, request.Password, request.ConfirmPassword))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, nameof(Register));

}
