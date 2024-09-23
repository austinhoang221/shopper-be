
namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository,
    IValidator validator)
    : ICommandHandler<DeleteProductCategoryCommand>
{
    public async Task<IResult> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
    {
        bool isExist = await productCategoryRepository.IsExist(request.Id);

        validator
            .If(isExist, NotFound<ProductCategory>(request.Id));

        if (validator.IsInvalid)

        {
            return validator.Failure();
        }

        await productCategoryRepository.DeleteAsync(request.Id);

        return Result.Success();
    }
}
