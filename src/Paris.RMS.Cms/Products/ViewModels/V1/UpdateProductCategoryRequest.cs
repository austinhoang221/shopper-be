namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class UpdateProductCategoryRequest(string name, string? parentId)
{
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
