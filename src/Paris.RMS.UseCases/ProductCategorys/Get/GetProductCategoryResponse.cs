
namespace Paris.RMS.UseCases.ProductCategorys.Get;

public sealed class GetProductCategoryResponse(string id, string name, string? parentId)
    : IResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
