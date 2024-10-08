namespace Paris.RMS.Cms.Users.ViewModels.V1;

public sealed class UserRegisterRequest(string email, string password, string confirmPassword)
{
    public string Email { get; } = email;
    public string Password { get; } = password;
    public string ConfirmPassword { get; } = confirmPassword;
}
