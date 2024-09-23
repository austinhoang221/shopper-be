namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository,
    IValidator validator)
    : ICommandHandler<UpdateProductCategoryCommand, UpdateProductCategoryResponse>
{
    public async Task<IResult<UpdateProductCategoryResponse>> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
    {
        ProductCategory? productCategory = await productCategoryRepository.FindAsync(request.Id);

        validator
            .If(productCategory is null, NotFound<ProductCategory>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<UpdateProductCategoryResponse>();
        }

        productCategory!.Update(request.Name, request.ParentId);

        return Result.Success(new UpdateProductCategoryResponse(productCategory.Id, productCategory.Name, productCategory.ParentId));
    }
}
