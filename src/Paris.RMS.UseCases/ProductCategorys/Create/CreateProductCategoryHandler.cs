namespace Paris.RMS.UseCases.ProductCategorys.Create;

internal sealed class CreateProductCategoryHandler(IProductCategoryRepository productCategoryRepository)
    : ICommandHandler<CreateProductCategoryCommand, CreateProductCategoryResponse>
{
    public async Task<IResult<CreateProductCategoryResponse>> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
    {
        var productCategory = ProductCategory.Create(request.Name, request.ParentId);

        productCategoryRepository.Insert(productCategory);

        await Task.CompletedTask;

        return Result.Success(new CreateProductCategoryResponse(productCategory.Id, productCategory.Name, productCategory.ParentId)); ;
    }
}
