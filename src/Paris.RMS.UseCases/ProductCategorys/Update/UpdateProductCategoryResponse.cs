namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryResponse(string id, string name, string? parentId, string icon, string visible)
    : IResponse
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
