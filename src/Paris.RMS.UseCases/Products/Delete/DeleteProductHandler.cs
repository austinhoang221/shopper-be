namespace Paris.RMS.UseCases.Products.Delete;

public sealed class DeleteProductHandler(
    IProductRepository productRepository,
    IValidator validator)
    : ICommandHandler<DeleteProductCommand, DeleteProductResponse>
{
    public async Task<IResult<DeleteProductResponse>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        bool isExist = await productRepository.IsExist(request.Id);

        validator
            .If(isExist, NotFound<Product>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<DeleteProductResponse>();
        }

        return Result.Success(new DeleteProductResponse(request.Id));
    }
}
