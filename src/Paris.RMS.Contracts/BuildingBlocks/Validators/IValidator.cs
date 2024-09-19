namespace Paris.RMS.Contracts.BuildingBlocks.Validators;

public interface IValidator
{
    bool IsValid { get; }
    bool IsInvalid { get; }

    IValidator If(bool condition, Error thenError);

    IValidator Validate<TValueObject>(Result<TValueObject> result)
        where TValueObject : ValueObject;

    IValidator Validate<TValueObject>(ValidationResult<TValueObject> validationResult)
        where TValueObject : ValueObject;

    //IValidator Validate<TInput>(Result<TInput> result);

    //IValidator Validate<TInput>(ValidationResult<TInput> validationResult);

    ValidationResult<TResponse> Failure<TResponse>()
            where TResponse : IResponse;

    ValidationResult Failure();
}
