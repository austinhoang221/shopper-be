
namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository,
    IValidator validator)
    : ICommandHandler<DeleteProductCategoryCommand, DeleteProductCategoryResponse>
{
    public async Task<IResult<DeleteProductCategoryResponse>> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
    {
        bool isExist = await productCategoryRepository.IsExist(request.Id);

        validator
            .If(isExist, NotFound<ProductCategory>(request.Id));

        if (validator.IsInvalid)

        {
            return validator.Failure<DeleteProductCategoryResponse>();
        }

        await productCategoryRepository.DeleteAsync(request.Id);

        return Result.Success(new DeleteProductCategoryResponse(request.Id));
    }
}
