namespace Paris.RMS.Persistences.Repositories;

internal abstract class RepositoryBase<TEntity>(IDbContext context)
    where TEntity : EntityBase
{
    protected DbSet<TEntity> Entity => context.Set<TEntity>();

    public async Task<TEntity?> FindAsync(Ulid id)
        => await context.FindAsync<TEntity>(id);

    public async Task<IReadOnlyCollection<TEntity>> List()
        => await context.List<TEntity>();

    public async Task<bool> IsExist(Ulid id)
        => await context.IsExist<TEntity>(id);

    public void Delete(TEntity entity)
        => context.Delete(entity);

    public async Task DeleteAsync(Ulid id)
     => await context.DeleteAsync<TEntity>(id);

    public void DeleteRange(IReadOnlyCollection<TEntity> entities)
        => context.DeleteRange(entities);

    public void Insert(TEntity entity)
        => context.Insert(entity);

    public void InsertRange(IReadOnlyCollection<TEntity> entities)
        => context.InsertRange(entities);

    public async Task<(IList<TResponse> Responses, int TotalCount)> PageAsync<TResponse>
    (
        IOffsetPage page,
        CancellationToken cancellationToken,
        IFilter<TEntity>? filter = null,
        ISortBy<TEntity>? sort = null,
        Expression<Func<TEntity, TResponse>>? mapping = null,
        params Expression<Func<TEntity, object>>[] includes
    )
    {
        var specification = CommonSpecification.WithMapping.Create(
            filter, null, sort, mapping: mapping, includes: includes
        );

        return await context
            .Set<TEntity>()
            .UseSpecification(specification)
            .PageAsync(page, cancellationToken);
    }

    public async Task<(IList<TResponse> Responses, Ulid Cursor)> PageAsync<TResponse>
    (
        ICursorPage page,
        CancellationToken cancellationToken,
        IFilter<TEntity>? filter = null,
        ISortBy<TEntity>? sort = null,
        Expression<Func<TEntity, TResponse>>? mapping = null,
        params Expression<Func<TEntity, object>>[] includes
    )
        where TResponse : class, IHasCursor
    {
        Expression<Func<TEntity, bool>> cursorFilter = entity => entity.Id.CompareTo(page.Cursor) >= 0;

        var specification = CommonSpecification.WithMapping.Create(
            filter, cursorFilter, sort, mapping: mapping, includes: includes
        );

        return await context
            .Set<TEntity>()
            .UseSpecification(specification)
            .PageAsync(page, cancellationToken);
    }
}
