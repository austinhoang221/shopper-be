namespace Paris.RMS.Contracts.BuildingBlocks.Results;

public static class ValidationResultExtensions
{
    public static IDictionary<string, object?> ToDictionary(this IValidationResult validationResult)
    {
        return new Dictionary<string, object?>
        {
            { DomainErrors, validationResult.ValidationErrors }
        };
    }
}
