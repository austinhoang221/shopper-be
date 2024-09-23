
namespace Paris.RMS.UseCases.ProductCategorys.List;

public sealed class ListProductCategoryResponse(string id, string name, string? parentId)
    : IResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
