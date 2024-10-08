namespace Paris.RMS.UseCases.ProductCategorys.Create;

public sealed class CreateProductCategoryCommand(string name, string? parentId, string icon)
    : ICommand<CreateProductCategoryResponse>
{
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
}
