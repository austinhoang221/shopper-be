namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class CreateProductCategoryRequest(string name, string? parentId)
{
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
