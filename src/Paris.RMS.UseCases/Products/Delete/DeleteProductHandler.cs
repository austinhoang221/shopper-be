namespace Paris.RMS.UseCases.Products.Delete;

public sealed class DeleteProductHandler(
    IProductRepository productRepository,
    IValidator validator)
    : ICommandHandler<DeleteProductCommand>
{
    public async Task<IResult> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        bool isExist = await productRepository.IsExist(request.Id);

        validator
            .If(isExist, NotFound<Product>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure();
        }

        return Result.Success();
    }
}
