namespace Paris.RMS.Persistences.Repositories;

internal abstract class RepositoryBase<TEntity>(IDbContext context)
    where TEntity : EntityBase
{
    protected DbSet<TEntity> Entity => context.Set<TEntity>();

    public async Task<TEntity?> FindAsync(string id)
        => await context.FindAsync<TEntity>(id);

    public async Task<IReadOnlyCollection<TEntity>> List()
        => await context.List<TEntity>();

    public async Task<bool> IsExist(string id)
        => await context.IsExist<TEntity>(id);

    public void Delete(TEntity entity)
        => context.Delete(entity);

    public async Task DeleteAsync(string id)
     => await context.DeleteAsync<TEntity>(id);

    public void DeleteRange(IReadOnlyCollection<TEntity> entities)
        => context.DeleteRange(entities);

    public void Insert(TEntity entity)
        => context.Insert(entity);

    public void InsertRange(IReadOnlyCollection<TEntity> entities)
        => context.InsertRange(entities);
}
