namespace Paris.RMS.UseCases.Users.Login;

public sealed record UserLoginResponse(Ulid Id, string AccessToken) : IResponse;
