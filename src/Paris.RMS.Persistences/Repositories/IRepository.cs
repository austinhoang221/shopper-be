namespace Paris.RMS.Persistences.Repositories;

public interface IRepository<TEntity>
    where TEntity : EntityBase
{
    Task<TEntity?> FindAsync(string id);

    void Insert(TEntity entity);

    void InsertRange(IReadOnlyCollection<TEntity> entities);

    void Update(TEntity entity);

    void UpdateRange(IReadOnlyCollection<TEntity> entities);

    void Delete(TEntity entity);

    void DeleteRange(IReadOnlyCollection<TEntity> entities);

    Task DeleteAsync(string id);
}
