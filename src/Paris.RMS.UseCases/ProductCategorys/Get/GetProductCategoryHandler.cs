
namespace Paris.RMS.UseCases.ProductCategorys.Get;

public sealed class GetProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository,
    IValidator validator)
    : IQueryHandler<GetProductCategoryQuery, GetProductCategoryResponse>
{
    public async Task<IResult<GetProductCategoryResponse>> Handle(GetProductCategoryQuery request, CancellationToken cancellationToken)
    {
        ProductCategory? productCategory = await productCategoryRepository.FindAsync(request.Id);

        validator
            .If(productCategory is null, NotFound<ProductCategory>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<GetProductCategoryResponse>();
        }

        return Result.Success(new GetProductCategoryResponse(productCategory!.Id, productCategory.Name, productCategory.ParentId));
    }
}
