namespace Paris.RMS.UseCases.Users.Register;

public sealed class UserRegisterCommand(string email, string password, string confirmPassword)
    : ICommand<UserRegisterResponse>
{
    public string Email { get; } = email;
    public string Password { get; } = password;
    public string ConfirmPassword { get; } = confirmPassword;
}
