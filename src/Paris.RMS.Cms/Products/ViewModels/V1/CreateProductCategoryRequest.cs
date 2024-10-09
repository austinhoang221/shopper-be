namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class CreateProductCategoryRequest(string name, Ulid? parentId, string icon)
{
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
}
