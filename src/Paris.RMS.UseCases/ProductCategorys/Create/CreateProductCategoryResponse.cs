namespace Paris.RMS.UseCases.ProductCategorys.Create;

public sealed class CreateProductCategoryResponse(Ulid id, string name, Ulid? parentId, string icon, string visible)
    : ICreatedResponse
{
    public Ulid Id { get; } = id;
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
