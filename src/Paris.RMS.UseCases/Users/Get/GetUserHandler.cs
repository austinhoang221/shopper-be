namespace Paris.RMS.UseCases.Users.Get;

public sealed class GetUserHandler(
    UserManager<ApplicationUser> userManager,
    IValidator validator)
    : IQueryHandler<GetUserQuery, GetUserResponse>
{
    public async Task<IResult<GetUserResponse>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.Id);

        validator
            .If(user is null, NotFound(request.Id, nameof(ApplicationUser)));

        if (validator.IsInvalid)
        {
            return validator.Failure<GetUserResponse>();
        }

        return Result.Success(new GetUserResponse(user!.Id, user!.Email!));
    }
}
