namespace Paris.RMS.Contracts.BuildingBlocks.DDD.Specifications;

public interface IFilter
{
}

public interface IFilter<TEntity> : IFilter
    where TEntity : class, IEntityBase
{
    IQueryable<TEntity> Apply(IQueryable<TEntity> queryable);
}
