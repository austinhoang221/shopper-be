namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryResponse(Ulid id, string name, Ulid? parentId, string icon, string visible)
    : IResponse
{
    public Ulid Id { get; } = id;
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
}
