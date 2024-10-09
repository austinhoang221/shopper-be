namespace Paris.RMS.Contracts.Exceptions;

public sealed class BadRequestException(string message) : Exception(message);
