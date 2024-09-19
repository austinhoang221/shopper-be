namespace Paris.RMS.UseCases.Users.Login;

public sealed record UserLoginResponse(string Id, string AccessToken) : IResponse;
