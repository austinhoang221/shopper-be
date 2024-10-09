namespace Paris.RMS.UseCases.ProductCategorys.Create;

public sealed class CreateProductCategoryCommand(string name, Ulid? parentId, string icon)
    : ICommand<CreateProductCategoryResponse>
{
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
}
