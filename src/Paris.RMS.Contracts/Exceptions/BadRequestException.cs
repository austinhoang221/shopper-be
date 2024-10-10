namespace Paris.RMS.Contracts.Exceptions;

public class BadRequestException(string message, Error[]? errors = null) : Exception(message)
{
    public Error[] Errors { get; } = errors ?? [];
}
