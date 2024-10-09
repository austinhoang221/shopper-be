namespace Paris.RMS.Contracts.BuildingBlocks.DDD.Specifications;

public sealed record SortByEntry
{
    public required string PropertyName { get; init; }
    public required SortDirection SortDirection { get; init; }
    public required int SortPriority { get; init; }
}
