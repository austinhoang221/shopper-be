namespace Paris.RMS.UseCases.Products.List;

public sealed class ListProductHandler(IProductRepository productRepository)
    : IListQueryHandler<ListProductQuery, ListProductResponse>
{
    public async Task<IResult<IReadOnlyCollection<ListProductResponse>>> Handle(ListProductQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.List();

        return Result.Success(products
            .Select(p =>
                new ListProductResponse(p.Id, p.CategoryId, p.CostPrice, p.Name,
                    p.ProductCd, p.SellingPrice, p.Stock, p.SupplierId, p.TxDesc,
                    p.Unit, p.Weight))
            .ToList());
    }
}
