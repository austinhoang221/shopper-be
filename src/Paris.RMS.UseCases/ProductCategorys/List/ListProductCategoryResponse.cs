namespace Paris.RMS.UseCases.ProductCategorys.List;

public sealed class ListProductCategoryResponse(Ulid id, string name, Ulid? parentId,
    string icon, string visible)
    : IResponse, INode<ListProductCategoryResponse>
{
    public Ulid Id { get; } = id;
    public string Name { get; } = name;
    public Ulid? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
    public IEnumerable<ListProductCategoryResponse> Children { get; set; } = [];
}
