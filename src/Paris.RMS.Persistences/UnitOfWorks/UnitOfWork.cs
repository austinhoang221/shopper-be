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
public sealed class UnitOfWork(IUserContextService userContext, IDbContext context)
    : IUnitOfWork
{
    private const string DefaultUsername = "Unknown";

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
    {
        return context
            .BeginTransactionAsync(cancellationToken);
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return context
            .CreateExecutionStrategy();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        UpdateAuditableEntitiesBase();
        UpdateEntitiesBase();

        await context.SaveChangesAsync(cancellationToken);
    }

    public ChangeTracker ChangeTracker => context.ChangeTracker;

    private void UpdateAuditableEntitiesBase()
    {
        IEnumerable<EntityEntry<AuditEntityBase>> entries =
            context
                .ChangeTracker
                .Entries<AuditEntityBase>()
                .Where(entry => entry.State is Added or Modified or Deleted);

        foreach (EntityEntry<AuditEntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.CreatorUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.LastModificationUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Deleted)
            {
                entityEntry.Property(a => a.DeletionTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.DeletionUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }
        }
    }

    private void UpdateEntitiesBase()
    {
        IEnumerable<EntityEntry<EntityBase>> entries =
            context
                .ChangeTracker
                .Entries<EntityBase>()
                .Where(entry => entry.State is Added or Modified)
                ;

        foreach (EntityEntry<EntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
            }
        }
    }
}

public sealed class UnitOfWork<TContext>
(
    IDbContext dbContext,
    IUserContextService userContext
)
    : IUnitOfWork<TContext>
    where TContext : IDbContext
{
    private const string DefaultUsername = "Unknown";

    public IDbContext Context => dbContext;

    public ChangeTracker ChangeTracker => dbContext.ChangeTracker;

    TContext IUnitOfWork<TContext>.Context => throw new NotImplementedException();

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
    {
        return Context
            .BeginTransactionAsync(cancellationToken);
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return Context
            .CreateExecutionStrategy();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        UpdateAuditableEntitiesBase();
        UpdateEntitiesBase();

        await dbContext.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditableEntitiesBase()
    {
        IEnumerable<EntityEntry<AuditEntityBase>> entries =
            dbContext
                .ChangeTracker
                .Entries<AuditEntityBase>()
                .Where(entry => entry.State is Added or Modified or Deleted);

        foreach (EntityEntry<AuditEntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.CreatorUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.LastModificationUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }

            if (entityEntry.State is Deleted)
            {
                entityEntry.Property(a => a.DeletionTime).CurrentValue = SystemDateTimeOffset.UtcNow;
                entityEntry.Property(a => a.DeletionUserId).CurrentValue = userContext.UserId ?? DefaultUsername;
            }
        }
    }

    private void UpdateEntitiesBase()
    {
        IEnumerable<EntityEntry<EntityBase>> entries =
            dbContext
                .ChangeTracker
                .Entries<EntityBase>()
                .Where(entry => entry.State is Added or Modified);

        foreach (EntityEntry<EntityBase> entityEntry in entries)
        {
            if (entityEntry.State is Added)
            {
                entityEntry.Property(a => a.CreationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
            }

            if (entityEntry.State is Modified)
            {
                entityEntry.Property(a => a.LastModificationTime).CurrentValue = SystemDateTimeOffset.UtcNow;
            }
        }
    }
}

