namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryResponse(string id, string name, string? parentId)
    : IResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
