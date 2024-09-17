using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Paris.RMS.Persistences.UnitOfWorks;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken);
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
    IExecutionStrategy CreateExecutionStrategy();
}

public interface IUnitOfWork<out TContext> : IUnitOfWork
    where TContext : DbContext
{
    TContext Context { get; }
}
