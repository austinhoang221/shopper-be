namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class CreateProductCategoryRequest(string name, string? parentId, string icon)
{
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
}
