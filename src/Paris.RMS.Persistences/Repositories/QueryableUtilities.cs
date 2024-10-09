namespace Paris.RMS.Persistences.Repositories;

public static partial class QueryableUtilities
{
    private const int AdditionalRecordForCursor = 1;

    public static async Task<(IList<TResponse> Responses, int TotalCount)> PageAsync<TResponse>
    (
        this IQueryable<TResponse> queryable,
        IOffsetPage page,
        CancellationToken cancellationToken
    )
    {
        ArgumentNullException.ThrowIfNull(page);

        var totalCount = await queryable.CountAsync(cancellationToken);

        var responses = await queryable
            .Page(page)
            .ToListAsync(cancellationToken);

        return (responses, totalCount);
    }

    public static async Task<(IList<TResponse> Responses, Ulid Cursor)> PageAsync<TResponse>
    (
        this IQueryable<TResponse> queryable,
        ICursorPage page,
        CancellationToken cancellationToken
    )
        where TResponse : class, IHasCursor
    {
        var responsesWithCursor = await queryable
            .Take(page.PageSize + AdditionalRecordForCursor)
            .ToListAsync(cancellationToken);

        var cursor = Ulid.Empty;
        if (responsesWithCursor.Count > page.PageSize)
        {
            cursor = responsesWithCursor.Last().Id;
            responsesWithCursor = responsesWithCursor.SkipLast(1).ToList();
        }

        return (responsesWithCursor, cursor);
    }

    public static async Task<bool> AnyAsync<TEntity>
    (
        this IQueryable<TEntity> queryable,
        Ulid id,
        CancellationToken cancellationToken
    )
        where TEntity : class, IEntityBase
    {
        return await queryable
           .Where(entity => entity.Id == id)
           .AnyAsync(cancellationToken);
    }
}
