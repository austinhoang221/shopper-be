namespace Paris.RMS.UseCases.Users.Login;

public sealed class UserLoginCommand(string username, string password) : ICommand<UserLoginResponse>
{
    [Required]
    public string Username { get; } = username;

    [Required]
    public string Password { get; } = password;
}

