namespace Paris.RMS.API.Users.ViewModels.V1;

public sealed class UserLoginRequest(string username, string password)
{
    [Required]
    public string Username { get; } = username;

    [Required]
    public string Password { get; } = password;
}
