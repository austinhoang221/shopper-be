
namespace Paris.RMS.UseCases.Products.Get;

public sealed class GetProductHandler(
    IProductRepository productRepository,
    IValidator validator)
    : IQueryHandler<GetProductQuery, GetProductResponse>
{
    public async Task<IResult<GetProductResponse>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.FindAsync(request.Id);

        validator
            .If(product is null, NotFound<Product>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<GetProductResponse>();
        }

        return Result.Success(new GetProductResponse(product!.Id, product.CategoryId, product.CostPrice, product.Name,
            product.ProductCd, product.SellingPrice, product.Stock, product.SupplierId, product.TxDesc, product.Unit,
            product.Weight));
    }
}
