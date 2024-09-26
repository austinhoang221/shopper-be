namespace Paris.RMS.Persistences.Databases;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>()
        where TEntity : EntityBase;

    Task<TEntity?> FindAsync<TEntity>(string id)
        where TEntity : EntityBase;

    Task<IReadOnlyCollection<TEntity>> List<TEntity>()
        where TEntity : EntityBase;

    Task<bool> IsExist<TEntity>(string id)
        where TEntity : EntityBase;

    void Insert<TEntity>(TEntity entity)
        where TEntity : EntityBase;

    void InsertRange<TEntity>(IReadOnlyCollection<TEntity> entities)
        where TEntity : EntityBase;

    void Delete<TEntity>(TEntity entity)
        where TEntity : EntityBase;

    void DeleteRange<TEntity>(IReadOnlyCollection<TEntity> entities)
        where TEntity : EntityBase;

    Task DeleteAsync<TEntity>(string id)
        where TEntity : EntityBase;

    Task SaveChangesAsync(CancellationToken cancellationToken);

    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);

    IExecutionStrategy CreateExecutionStrategy();

    ChangeTracker ChangeTracker { get; }
}
