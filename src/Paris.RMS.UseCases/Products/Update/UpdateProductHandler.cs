namespace Paris.RMS.UseCases.Products.Update;

public sealed class UpdateProductHandler(
    IProductRepository productRepository,
    IValidator validator)
    : ICommandHandler<UpdateProductCommand, UpdateProductResponse>
{
    public async Task<IResult<UpdateProductResponse>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.FindAsync(request.Id);

        validator
            .If(product is null, NotFound<Product>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<UpdateProductResponse>();
        }

        product!.Update(request.CategoryId, request.CostPrice, request.Name,
            request.ProductCd, request.SellingPrice, request.Stock,
            request.SupplierId, request.TxDesc, request.Unit,
            request.Weight);

        return Result.Success(new UpdateProductResponse(product.Id, product.CategoryId, product.CostPrice, product.Name,
            product.ProductCd, product.SellingPrice, product.Stock,
            product.SupplierId, product.TxDesc, product.Unit,
            product.Weight));
    }
}
