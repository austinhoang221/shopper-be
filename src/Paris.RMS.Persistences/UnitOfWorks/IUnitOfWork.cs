namespace Paris.RMS.Persistences.UnitOfWorks;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken);
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
    IExecutionStrategy CreateExecutionStrategy();
    ChangeTracker ChangeTracker { get; }
}

public interface IUnitOfWork<out TContext> : IUnitOfWork
    where TContext : IDbContext
{
    TContext Context { get; }
}
