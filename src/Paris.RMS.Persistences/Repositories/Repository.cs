namespace Paris.RMS.Persistences.Repositories;

public class Repository<TEntity>(ParisRmsDbContext context) : IRepository<TEntity>
    where TEntity : EntityBase
{
    public void Delete(TEntity entity)
    {
        context.Set<TEntity>().Remove(entity);
    }

    public async Task DeleteAsync(string id)
    {
        await context.Set<TEntity>()
            .Where(e => e.Id == id)
            .ExecuteDeleteAsync();
    }

    public void DeleteRange(IReadOnlyCollection<TEntity> entities)
    {
        context.Set<TEntity>().RemoveRange(entities);
    }

    public async Task<TEntity?> FindAsync(string id)
    {
        return await context.Set<TEntity>().FindAsync(new { Id = id });
    }

    public void Insert(TEntity entity)
    {
        context.Set<TEntity>().Add(entity);
    }

    public void InsertRange(IReadOnlyCollection<TEntity> entities)
    {
        context.Set<TEntity>().AddRange(entities);
    }

    public void Update(TEntity entity)
    {
        context.Set<TEntity>().Update(entity);
    }

    public void UpdateRange(IReadOnlyCollection<TEntity> entities)
    {
        context.Set<TEntity>().UpdateRange(entities);
    }
}
