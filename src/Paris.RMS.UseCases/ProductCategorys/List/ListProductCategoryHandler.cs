namespace Paris.RMS.UseCases.ProductCategorys.List;

public sealed class ListProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository
    )
    : IListQueryHandler<ListProductCategoryQuery, ListProductCategoryResponse>
{
    public async Task<IResult<IReadOnlyCollection<ListProductCategoryResponse>>> Handle(ListProductCategoryQuery request, CancellationToken cancellationToken)
    {
        var productCategories = await productCategoryRepository.List();

        return Result.Success(productCategories.Select(pc => new ListProductCategoryResponse(pc.Id, pc.Name, pc.ParentId, pc.Icon, pc.Visible)).ToList());
    }
}
