namespace Paris.RMS.Contracts.BuildingBlocks.Errors;

public sealed partial class Error
{
    public static Error NotFound<TEntity>(int id)
        where TEntity : EntityBase
    {
        return New($"{typeof(TEntity).Name}.{nameof(NotFound)}", $"{typeof(TEntity).Name} with id '{id}' was not found.");
    }

    public static Error NotFound<TEntity>(string uniqueValue)
        where TEntity : EntityBase
    {
        return New($"{typeof(TEntity).Name}.{nameof(NotFound)}", $"{typeof(TEntity).Name} for '{uniqueValue}' was not found.");
    }

    public static Error NotFound(string subjectToFind, string uniqueValue, string additionalMessage)
    {
        return New($"{subjectToFind}.{nameof(NotFound)}", $"{subjectToFind} for '{uniqueValue}' was not found. {additionalMessage}");
    }

    public static Error AlreadyExists<TUniqueKey>(TUniqueKey key)
        where TUniqueKey : class
    {
        return New($"{typeof(TUniqueKey).Name}.{nameof(AlreadyExists)}", $"{typeof(TUniqueKey).Name} '{key}' already exists.");
    }

    public static Error AlreadyExists(string subject, string key)
    {
        return New($"{subject}.{nameof(AlreadyExists)}", $"{subject} '{key}' already exists.");
    }

    public static Error AlreadyExists<TEntity>(string uniqueValue)
        where TEntity : EntityBase
    {
        return New($"{typeof(TEntity).Name}.{nameof(AlreadyExists)}", $"The {typeof(TEntity).Name} have '{uniqueValue}' already exists.");
    }

    public static Error NullOrEmpty(string collectionName)
    {
        return New($"{collectionName}.{nameof(NullOrEmpty)}", $"{collectionName} is null or empty.");
    }

    public static Error InvalidBatchCommand(string batchCommand)
    {
        return New($"{batchCommand}.{nameof(InvalidBatchCommand)}", $"{batchCommand} is invalid.");
    }

    public static Error InvalidOperation(string message)
    {
        return New($"{nameof(InvalidOperation)}", message);
    }

    public static Error Exception(string exceptionMessage)
    {
        return New($"{nameof(Exception)}", exceptionMessage);
    }

    public static Error ParseFailure<ParseType>(string valueParsedName)
    {
        return New($"{nameof(ParseFailure)}", $"Parsing '{valueParsedName}' to type '{nameof(ParseType)}' failed.");
    }

    public static Error ApplicationFailure(string code, string message)
    {
        return New(code, message);
    }
}
