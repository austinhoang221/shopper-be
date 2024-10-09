namespace Paris.RMS.UseCases.Users.Register;

public sealed class UserRegisterResponse(Ulid id, string accessToken)
    : ICreatedResponse
{
    public Ulid Id { get; } = id;
    public string AccessToken { get; } = accessToken;
}
