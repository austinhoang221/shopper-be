﻿namespace Paris.RMS.Contracts.Constants;

public partial class Constants
{
    public static class ProblemDetails
    {
        public const string ValidationError = nameof(ValidationError);
        public const string InvalidRequest = nameof(InvalidRequest);
        public const string ExceptionOccurred = nameof(ExceptionOccurred);
        public const string RequestId = nameof(RequestId);
        public const string InvalidRequestTitle = "Invalid request body or request parameters";
        public const string DomainErrors = "errors";
    }
}
