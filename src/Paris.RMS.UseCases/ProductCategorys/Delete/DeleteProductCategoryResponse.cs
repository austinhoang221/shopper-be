
namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryResponse(string id)
    : IResponse
{
    public string Id { get; } = id;
}
