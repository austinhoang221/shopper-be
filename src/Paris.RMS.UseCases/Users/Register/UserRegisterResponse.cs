namespace Paris.RMS.UseCases.Users.Register;

public sealed class UserRegisterResponse(string id, string accessToken)
    : ICreatedResponse
{
    public string Id { get; } = id;
    public string AccessToken { get; } = accessToken;
}
