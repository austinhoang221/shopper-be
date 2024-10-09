namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.OffsetPages;

public interface IOffsetPage : IPage
{
    int PageNumber { get; init; }
}
