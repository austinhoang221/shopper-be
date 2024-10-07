namespace Paris.RMS.UseCases.ProductCategorys.Create;

public sealed class CreateProductCategoryResponse(string id, string name, string? parentId)
    : ICreatedResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
