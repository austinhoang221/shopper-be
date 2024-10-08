using Paris.RMS.Contracts.Utilities;

namespace Paris.RMS.UseCases.ProductCategorys.List;

public sealed class ListProductCategoryResponse(string id, string name, string? parentId,
    string icon, string visible)
    : IResponse, INode<ListProductCategoryResponse>
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
    public string Icon { get; } = icon;
    public string Visible { get; } = visible;
    public IEnumerable<ListProductCategoryResponse> Children { get; set; } = [];
}
