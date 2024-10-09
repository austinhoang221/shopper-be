namespace Paris.RMS.UseCases.Users.Get;

public sealed class GetUserResponse(Ulid id, string email)
    : IResponse
{
    public Ulid Id { get; } = id;
    public string Email { get; } = email;
}
