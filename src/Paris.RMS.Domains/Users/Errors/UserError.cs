namespace Paris.RMS.Domains.Users.Errors;

public sealed class UserError
{
    /// <summary>
    /// Create an Error describing that an email are invalid
    /// </summary>
    public static readonly Error InvalidEmail =
        Error.New($"{nameof(ApplicationUser)}.{nameof(InvalidEmail)}", $"Invalid email.");

    /// <summary>
    /// Create an Error describing that a password are invalid
    /// </summary>
    public static readonly Error InvalidPassword =
        Error.New($"{nameof(ApplicationUser)}.{nameof(InvalidPassword)}", $"Invalid password.");
}
