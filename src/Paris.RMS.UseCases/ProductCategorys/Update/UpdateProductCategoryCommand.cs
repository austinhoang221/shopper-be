namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryCommand(Ulid id, string name, Ulid? parentId, string icon, string visible)
    : ICommand<UpdateProductCategoryResponse>
{
    public Ulid Id { get; } = id;
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
