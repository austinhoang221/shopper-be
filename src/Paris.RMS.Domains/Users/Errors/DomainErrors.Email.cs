namespace Paris.RMS.Domains.Users.Errors;

public static partial class DomainErrors
{
    public static class Email
    {
        public static readonly Error Empty = Error.New(
            $"Email.{nameof(Empty)}",
            $"Email is empty.");

        public static readonly Error TooLong = Error.New(
            $"Email.{nameof(TooLong)}",
            $"Email must be at most 40 characters long.");

        public static readonly Error Invalid = Error.New(
            $"Email.{nameof(Invalid)}",
            $"Email must start from a letter, contain '@' and after that '.'.");

        public static readonly Error EmailAlreadyTaken = Error.New(
            $"Email.{nameof(EmailAlreadyTaken)}",
             $"Email is already taken.");
    }
}
