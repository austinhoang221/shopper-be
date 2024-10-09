namespace Paris.RMS.Contracts.BuildingBlocks.DDD.Specifications;

internal static class SpecificationUtilities
{
    internal static SpecificationWithMapping<TEntity, TResponse> AsMappingSpecification<TEntity, TResponse>(this Specification<TEntity> specification)
        where TEntity : class, IEntityBase
    {
        return (SpecificationWithMapping<TEntity, TResponse>)specification;
    }
}
