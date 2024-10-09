namespace Paris.RMS.Contracts.BuildingBlocks.DDD.Specifications;

public interface IDynamicSortBy : ISortBy
{
    IList<SortByEntry> SortProperties { get; init; }
    static abstract IReadOnlyCollection<string> AllowedSortProperties { get; }
}

public interface IDynamicSortBy<TEntity> : ISortBy<TEntity>, IDynamicSortBy
    where TEntity : EntityBase
{
}
