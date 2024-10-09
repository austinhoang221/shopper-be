namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.OffsetPages;

public sealed record OffsetPage : IOffsetPage
{
    public required int PageSize { get; init; }
    public required int PageNumber { get; init; }
}
