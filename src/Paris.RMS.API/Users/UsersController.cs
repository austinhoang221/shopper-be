using Paris.RMS.API.Users.ViewModels.V1;
using Paris.RMS.UseCases.Users.Login;
using Paris.RMS.UseCases.Users.Register;

namespace Paris.RMS.API.Users;

[ApiVersion("1.0")]
public class UsersController(IMediator mediator) : ApiController(mediator)
{
    /// <summary>
    /// The user login to the system
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>The access token of the user</returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the access token</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [AllowAnonymous]
    [HttpPost("[action]")]
    [ProducesResponseType<UserLoginResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Login([FromBody] UserLoginRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UserLoginCommand(request.Username, request.Password))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(Ok, BadRequest);

    /// <summary>
    /// The user register to the new account
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>The access token of the user</returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="201">Return the access token</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [AllowAnonymous]
    [HttpPost("[action]")]
    [ProducesResponseType<UserRegisterResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UserRegisterCommand(request.Email, request.Password, request.ConfirmPassword))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, nameof(Register));
}
