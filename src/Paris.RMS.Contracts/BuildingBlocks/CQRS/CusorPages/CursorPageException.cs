namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

public sealed class CursorPageException(Ulid currentCursor, Ulid nextCursor)
    : BadRequestException($"Selected cursor '{currentCursor}' is greater than next cursor '{nextCursor}'")
{
}
