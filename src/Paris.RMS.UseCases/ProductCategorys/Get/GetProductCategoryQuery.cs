
namespace Paris.RMS.UseCases.ProductCategorys.Get;

public sealed class GetProductCategoryQuery(string id)
    : IQuery<GetProductCategoryResponse>
{
    public string Id { get; } = id;
}
