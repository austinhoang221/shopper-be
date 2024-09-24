namespace Paris.RMS.Contracts.BuildingBlocks.Validators;

public sealed class Validator : IValidator
{
    private readonly List<Error> _errors = [];
    public bool IsValid => _errors.IsNullOrEmpty();
    public bool IsInvalid => !IsValid;

    public IValidator If(bool condition, Error thenError)
    {
        if (condition is true)
        {
            _errors.Add(thenError);
        }

        return this;
    }

    public IValidator IfNull<TObject>(TObject? instance, Error thenError)
        where TObject : class, IEntityBase
    {
        if (instance is null)
        {
            _errors.Add(thenError);
        }

        return this;
    }

    public IValidator Validate<TValueObject>(Result<TValueObject> result)
        where TValueObject : ValueObject
    {
        if (result.IsFailure)
        {
            _errors.Add(result.Error);
        }

        return this;
    }

    public IValidator Validate<TValueObject>(ValidationResult<TValueObject> validationResult)
        where TValueObject : ValueObject
    {
        if (validationResult.IsFailure)
        {
            _errors.AddRange(validationResult.ValidationErrors);
        }

        return this;
    }

    public ValidationResult<TResponse> Failure<TResponse>()
        where TResponse : IResponse
    {
        if (IsValid)
        {
            throw new InvalidOperationException("Validation was successful, but Failure was called");
        }

        return ValidationResult<TResponse>.WithErrors([.. _errors]);
    }

    /// <summary>
    /// Builds the failure validation result with errors
    /// </summary>
    /// <typeparam name="TResponse">Type of response</typeparam>
    /// <returns>ValidationResult with errors</returns>
    /// <exception cref="InvalidOperationException">If validator error list is null or empty, throw exception</exception>
    public ValidationResult Failure()
    {
        if (IsValid)
        {
            throw new InvalidOperationException("Validation was successful, but Failure was called");
        }

        return ValidationResult.WithErrors([.. _errors]);
    }
}
