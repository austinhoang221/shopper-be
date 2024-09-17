namespace Paris.RMS.Persistences.UnitOfWorks;

//UnitOfWork class to handler transactions
//Benefits:
//1. We do not want to pollute the application layer with entity framework
//2. We do not expose any implementation details when we inject IUnitOfWork interface
//a) since we use the repository pattern with UnitOfWork, the repositories do not contain SaveChanges method.
//This force us to call SaveChanges at the end of our business transactions from the UnitOfWork.
//So this removes the responsibility of SavingChanges from the repositories and moves it to the UnitOfWork
//b) since we use IUnitOfWork interface we can provide a mock for this interface
//3. Move the logic from the interceptors to the UnitOfWork
public sealed class UnitOfWork<TContext>
(
    TContext dbContext,
    IUserContextService userContext
)
    : IUnitOfWork<TContext>
        where TContext : DbContext
{
    private const string DefaultUsername = "Unknown";
    private readonly TContext _dbContext = dbContext;
    private readonly IUserContextService _userContext = userContext;

    public TContext Context => _dbContext;

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
    {
        return Context
            .Database
            .BeginTransactionAsync(cancellationToken);
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return Context
            .Database
            .CreateExecutionStrategy();
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        UpdateAuditableEntitiesBase();
        UpdateEntitiesBase();

        return _dbContext.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditableEntitiesBase()
    {
        IEnumerable<EntityEntry<IAuditEntityBase>> entries =
            _dbContext
                .ChangeTracker
                .Entries<IAuditEntityBase>()
                .Where(entry => entry.State is Added or Modified or Deleted);

        foreach (EntityEntry<IAuditEntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = DateTimeOffset.UtcNow;
                entityEntry.Property(a => a.CreatorUserId).CurrentValue = _userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = DateTimeOffset.UtcNow;
                entityEntry.Property(a => a.LastModificationUserId).CurrentValue = _userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Deleted)
            {
                entityEntry.Property(a => a.DeletionTime).CurrentValue = DateTimeOffset.UtcNow;
                entityEntry.Property(a => a.DeletionUserId).CurrentValue = _userContext.UserId ?? DefaultUsername;
            }
        }
    }

    private void UpdateEntitiesBase()
    {
        IEnumerable<EntityEntry<IEntityBase>> entries =
            _dbContext
                .ChangeTracker
                .Entries<IEntityBase>()
                .Where(entry => entry.State is Added or Modified or Deleted);

        foreach (EntityEntry<IEntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = DateTimeOffset.UtcNow;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = DateTimeOffset.UtcNow;
            }
        }
    }
}
