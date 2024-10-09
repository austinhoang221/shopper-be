namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class UpdateProductCategoryRequest(string name, Ulid? parentId, string icon, string visible)
{
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
