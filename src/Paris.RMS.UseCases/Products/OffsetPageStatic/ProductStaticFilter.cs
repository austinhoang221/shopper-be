namespace Paris.RMS.UseCases.Products.OffsetPageStatic;

public sealed class ProductStaticFilter : IFilter<Product>
{
    public IQueryable<Product> Apply(IQueryable<Product> queryable)
    {
        return queryable;
    }
}
