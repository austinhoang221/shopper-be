namespace Paris.RMS.Domains.Users.Errors;

public static partial class DomainErrors
{
    public static class Password
    {
        public static readonly Error Empty = Error.New(
            $"{nameof(Password)}.{nameof(Empty)}",
            $"{nameof(Password)} is empty.");

        public static readonly Error TooShort = Error.New(
            $"{nameof(Password)}.{nameof(TooShort)}",
            $"{nameof(Password)} needs to be at least 9 characters long.");

        public static readonly Error TooLong = Error.New(
            $"{nameof(Password)}.{nameof(TooLong)}",
            $"{nameof(Password)} needs to be at most 30 characters long.");

        public static readonly Error Invalid = Error.New(
            $"{nameof(Password)}.{nameof(Invalid)}",
            $"{nameof(Password)} needs to contain at least one digit, one small letter, one capital letter and one special character.");

        public static readonly Error ConfirmPasswordInvalid = Error.New(
            $"ConfirmPassword.{nameof(Invalid)}",
            $"ConfirmPassword not match to {nameof(Password)}.");
    }
}
