using static Paris.RMS.Domains.Users.Errors.DomainErrors.Email;
using static Paris.RMS.Domains.Users.Errors.DomainErrors.Password;

namespace Paris.RMS.UseCases.Users.Register;

internal sealed class UserRegisterHandler(
    UserManager<ApplicationUser> userManager,
    IJwtTokenProvider tokenProvider,
    ILogger<UserRegisterHandler> logger,
    IValidator validator)
    : ICommandHandler<UserRegisterCommand, UserRegisterResponse>
{
    public async Task<IResult<UserRegisterResponse>> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
    {
        ApplicationUser? existedUser = await userManager.FindByEmailAsync(request.Email);

        validator
            .If(existedUser is null, EmailAlreadyTaken)
            .If(request.ConfirmPassword != request.Password, ConfirmPasswordInvalid);

        if (validator.IsInvalid)
        {
            return validator.Failure<UserRegisterResponse>();
        }

        var user = ApplicationUser.Create(request.Email);

        var result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            logger.LogError("UserRegisterCommand failed: {Errors}", result.Errors);
            var error = result.Errors.Select(e => Error.ApplicationFailure(e.Code, e.Description)).FirstOrDefault();
            return Result.Failure<UserRegisterResponse>(error!);
        }
        string token = tokenProvider.GenerateJwt(user);
        return Result.Success(new UserRegisterResponse(user.Id, token));
    }
}
