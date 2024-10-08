namespace Paris.RMS.UseCases.ProductCategorys.Create;

public sealed class CreateProductCategoryResponse(string id, string name, string? parentId, string icon, string visible)
    : ICreatedResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
