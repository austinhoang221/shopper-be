namespace Paris.RMS.Domains.Users.Errors;

public static partial class DomainErrors
{
    public static class User
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

        public static Error NotFound(string id)
            => Error.New($"{typeof(ApplicationUser).Name}.{nameof(NotFound)}", $"{typeof(ApplicationUser).Name} with id '{id}' was not found.");
    }
}
