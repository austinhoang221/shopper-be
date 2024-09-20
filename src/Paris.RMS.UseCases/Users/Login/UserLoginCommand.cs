namespace Paris.RMS.UseCases.Users.Login;

public sealed class UserLoginCommand(string username, string password) : ICommand<UserLoginResponse>
{
    public string Username { get; } = username;

    public string Password { get; } = password;
}

