namespace Paris.RMS.Contracts.BuildingBlocks.DDD.Specifications;

public interface IDynamicFilter : IFilter
{
    IList<FilterByEntry> FilterProperties { get; init; }
    static abstract IReadOnlyCollection<string> AllowedFilterProperties { get; }
    static abstract IReadOnlyCollection<string> AllowedFilterOperations { get; }
}

public interface IDynamicFilter<TEntity> : IFilter<TEntity>, IDynamicFilter
    where TEntity : EntityBase
{
}
