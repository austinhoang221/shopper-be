using static Paris.RMS.Domains.Users.Errors.DomainErrors.User;

namespace Paris.RMS.UseCases.Users.Login;

internal sealed class UserLoginHandler(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    IJwtTokenProvider tokenProvider,
    IValidator validator)
    : ICommandHandler<UserLoginCommand, UserLoginResponse>
{
    public async Task<IResult<UserLoginResponse>> Handle(UserLoginCommand request, CancellationToken cancellationToken)
    {
        ApplicationUser? user = await userManager.FindByNameAsync(request.Username);

        validator
            .If(user is null, InvalidEmail);

        if (validator.IsInvalid)
        {
            return validator.Failure<UserLoginResponse>();
        }

        var result = await signInManager
            .CheckPasswordSignInAsync(user!, request.Password, false);

        validator
            .If(!result.Succeeded, InvalidPassword);

        if (validator.IsInvalid)
        {
            return validator.Failure<UserLoginResponse>();
        }

        string token = tokenProvider.GenerateJwt(user!);

        return Result.Success(new UserLoginResponse(user!.Id, token));
    }
}
