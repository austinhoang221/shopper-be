namespace Paris.RMS.UseCases.ProductCategorys.List;

public sealed class ListProductCategoryHandler(
    IProductCategoryRepository productCategoryRepository
    )
    : IListQueryHandler<ListProductCategoryQuery, ListProductCategoryResponse>
{
    public async Task<IResult<IReadOnlyCollection<ListProductCategoryResponse>>> Handle(ListProductCategoryQuery request, CancellationToken cancellationToken)
    {
        var productCategories = await productCategoryRepository.List();

        var productCategoryForest = productCategories
            .GenerateForest(pc => pc.ParentId ?? Ulid.Empty, pc => pc.Id,
            pc => new ListProductCategoryResponse(pc.Id, pc.Name, pc.ParentId, pc.Icon, pc.Visible), pc => pc.Id, Ulid.Empty);

        return Result.Success(productCategoryForest.ToList());
    }
}
