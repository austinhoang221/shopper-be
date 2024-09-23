namespace Paris.RMS.UseCases.Products.Create;

public sealed class CreateProductHandler(IProductRepository productRepository)
    : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<IResult<CreateProductResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = Product.Create(request.CategoryId, request.CostPrice, request.Stock, request.Name,
            request.ProductCd, request.SellingPrice, request.SupplierId, request.TxDesc,
            request.Unit, request.Weight);

        productRepository.Insert(product);

        await Task.CompletedTask;

        return Result.Success(new CreateProductResponse(product.Id, product.CategoryId, product.CostPrice, product.Name,
            product.ProductCd, product.SellingPrice, product.Stock, product.SupplierId, product.TxDesc,
            product.Unit, product.Weight));
    }
}
