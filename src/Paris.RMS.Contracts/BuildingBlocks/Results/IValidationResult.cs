namespace Paris.RMS.Contracts.BuildingBlocks.Results;

public interface IValidationResult
{
    Error[] ValidationErrors { get; }
}
