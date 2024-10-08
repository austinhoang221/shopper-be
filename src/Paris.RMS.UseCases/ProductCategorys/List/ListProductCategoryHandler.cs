using Paris.RMS.Contracts.Utilities;

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
            .GenerateForest(pc => pc.ParentId ?? string.Empty, pc => pc.Id,
            pc => new ListProductCategoryResponse(pc.Id, pc.Name, pc.ParentId, pc.Icon, pc.Visible), pc => pc.Id, string.Empty);

        return Result.Success(productCategoryForest.ToList());
    }
}
