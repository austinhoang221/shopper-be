namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

public sealed class CursorPage : ICursorPage
{
    public required int PageSize { get; init; }
    public required Ulid Cursor { get; init; }
}
