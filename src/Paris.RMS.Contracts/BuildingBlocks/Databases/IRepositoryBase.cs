using Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task<TEntity?> FindAsync(Ulid id);

    Task<IReadOnlyCollection<TEntity>> List();

    Task<bool> IsExist(Ulid id);

    void Delete(TEntity entity);

    Task DeleteAsync(Ulid id);

    void DeleteRange(IReadOnlyCollection<TEntity> entities);

    void Insert(TEntity entity);

    void InsertRange(IReadOnlyCollection<TEntity> entities);

    Task<(IList<TResponse> Responses, int TotalCount)> PageAsync<TResponse>
    (
        IOffsetPage page,
        CancellationToken cancellationToken,
        IFilter<TEntity>? filter = null,
        ISortBy<TEntity>? sort = null,
        Expression<Func<TEntity, TResponse>>? mapping = null,
        params Expression<Func<TEntity, object>>[] includes
    );

    Task<(IList<TResponse> Responses, Ulid Cursor)> PageAsync<TResponse>
    (
        ICursorPage page,
        CancellationToken cancellationToken,
        IFilter<TEntity>? filter = null,
        ISortBy<TEntity>? sort = null,
        Expression<Func<TEntity, TResponse>>? mapping = null,
        params Expression<Func<TEntity, object>>[] includes
    )
        where TResponse : class, IHasCursor;
}
