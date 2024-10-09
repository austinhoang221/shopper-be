namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

public interface ICursorPage : IPage
{
    Ulid Cursor { get; init; }
}
