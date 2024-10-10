namespace Paris.RMS.Contracts.BuildingBlocks.Responses;

public sealed class CursorPageResponse<TValue> : PageResponse<TValue>
    where TValue : IResponse
{
    /// <summary>
    /// Current page cursor. Id from which we query records
    /// </summary>
    public Ulid CurrentCursor { get; private init; }

    /// <summary>
    /// Next page cursor. Id of next record to query or Ulid.Empty if the last record was reached
    /// </summary>
    public Ulid NextCursor { get; private init; }

    public CursorPageResponse(IList<TValue> items, Ulid currentCursor, Ulid nextCursor)
        : base(items)
    {
        var notLastPage = nextCursor != Ulid.Empty;
        var invalidCursor = currentCursor.CompareTo(nextCursor) > 0;

        if (notLastPage && invalidCursor)
        {
            throw new CursorPageException(currentCursor, nextCursor);
        }

        CurrentCursor = currentCursor;
        NextCursor = nextCursor;
    }
}
