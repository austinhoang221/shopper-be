using static Paris.RMS.Contracts.Utilities.PageUtilities;

namespace Paris.RMS.UseCases.Products.OffsetPageStatic;

public class ProductOffsetPageStaticHandler(IProductRepository productRepository)
    : IOffsetPageQueryHandler<ProductOffsetPageStaticQuery, ProductOffsetPageStaticResponse,
        ProductStaticFilter, ProductStaticSortBy, OffsetPage>
{
    public async Task<IResult<OffsetPageResponse<ProductOffsetPageStaticResponse>>> Handle(ProductOffsetPageStaticQuery request, CancellationToken cancellationToken)
    {
        var page = await productRepository
            .PageAsync(request.Page, cancellationToken, filter: request.Filter, sort: request.SortBy, mapping: ProductMapping.ProductResponse);

        return page
            .ToPageResponse(request.Page)
            .ToResult();
    }
}
