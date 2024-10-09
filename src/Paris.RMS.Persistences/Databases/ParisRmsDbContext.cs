namespace Paris.RMS.Persistences.Databases;

public sealed class ParisRmsDbContext(
    DbContextOptions<ParisRmsDbContext> options)
    : IdentityDbContext<ApplicationUser, IdentityRole<Ulid>, Ulid>(options), IDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder
            .Properties<Ulid>()
            .HaveConversion<UlidToStringConverter>();
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
    {
        return await Database
            .BeginTransactionAsync(cancellationToken);
    }

    public IExecutionStrategy CreateExecutionStrategy()
    {
        return Database
            .CreateExecutionStrategy();
    }

    public new DbSet<TEntity> Set<TEntity>()
        where TEntity : EntityBase
        => base.Set<TEntity>();

    public async Task<TEntity?> FindAsync<TEntity>(Ulid id)
        where TEntity : EntityBase
        => await Set<TEntity>().Where(e => e.Id == id).SingleOrDefaultAsync();

    public async Task<IReadOnlyCollection<TEntity>> List<TEntity>()
        where TEntity : EntityBase
        => await Set<TEntity>().ToListAsync();

    public async Task<bool> IsExist<TEntity>(Ulid id)
        where TEntity : EntityBase
        => await Set<TEntity>().AnyAsync(x => x.Id == id);

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

    public async Task DeleteAsync<TEntity>(Ulid id)
        where TEntity : EntityBase
        => await Set<TEntity>()
        .Where(e => e.Id == id)
        .ExecuteDeleteAsync();

    public new async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await base.SaveChangesAsync(cancellationToken);
    }
}
