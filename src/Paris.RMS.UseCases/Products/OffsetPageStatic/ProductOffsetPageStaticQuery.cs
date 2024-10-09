namespace Paris.RMS.UseCases.Products.OffsetPageStatic;

public sealed class ProductOffsetPageStaticQuery(OffsetPage page)
    : IOffsetPageQuery<ProductOffsetPageStaticResponse, ProductStaticFilter, ProductStaticSortBy, OffsetPage>
{
    public OffsetPage Page { get; } = page;

    public ProductStaticFilter? Filter { get; init; }

    public ProductStaticSortBy? SortBy { get; init; }
}
