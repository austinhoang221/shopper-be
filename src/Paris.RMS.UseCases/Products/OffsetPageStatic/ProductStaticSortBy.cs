namespace Paris.RMS.UseCases.Products.OffsetPageStatic;

public sealed class ProductStaticSortBy : ISortBy<Product>
{
    public SortDirection? Name { get; init; }
    public SortDirection? SchoolCode { get; init; }
    public SortDirection? SchoolLevelCode { get; init; }

    public SortDirection? ThenName { get; init; }
    public SortDirection? ThenSchoolCode { get; init; }
    public SortDirection? ThenSchoolLevelCode { get; init; }

    public IQueryable<Product> Apply(IQueryable<Product> queryable)
    {
        return queryable;
    }
}
