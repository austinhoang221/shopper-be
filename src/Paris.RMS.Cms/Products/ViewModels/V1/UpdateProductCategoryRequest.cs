namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class UpdateProductCategoryRequest(string name, string? parentId, string icon, string visible)
{
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
