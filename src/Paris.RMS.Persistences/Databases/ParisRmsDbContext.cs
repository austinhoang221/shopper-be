namespace Paris.RMS.Persistences.Databases;

public sealed class ParisRmsDbContext(DbContextOptions<ParisRmsDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public new DbSet<TEntity> Set<TEntity>()
        where TEntity : EntityBase
        => base.Set<TEntity>();

    public async Task<TEntity?> FindAsync<TEntity>(string id)
        where TEntity : EntityBase
        => await Set<TEntity>().FindAsync(new { Id = id });

    public void Insert<TEntity>(TEntity entity)
        where TEntity : EntityBase
        => Set<TEntity>().Add(entity);

    public void InsertRange<TEntity>(IReadOnlyCollection<TEntity> entities)
        where TEntity : EntityBase
        => Set<TEntity>().AddRange(entities);

    public void Delete<TEntity>(TEntity entity) where TEntity : EntityBase
        => Set<TEntity>().Remove(entity);

    public void DeleteRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : EntityBase
        => Set<TEntity>().RemoveRange(entities);

    public async Task DeleteAsync<TEntity>(string id)
        where TEntity : EntityBase
        => await Set<TEntity>()
        .Where(e => e.Id == id)
        .ExecuteDeleteAsync();
}
