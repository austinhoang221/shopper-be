namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    Task<TEntity?> FindAsync(string id);

    Task<IReadOnlyCollection<TEntity>> List();

    Task<bool> IsExist(string id);

    void Delete(TEntity entity);

    Task DeleteAsync(string id);

    void DeleteRange(IReadOnlyCollection<TEntity> entities);

    void Insert(TEntity entity);

    void InsertRange(IReadOnlyCollection<TEntity> entities);
}
