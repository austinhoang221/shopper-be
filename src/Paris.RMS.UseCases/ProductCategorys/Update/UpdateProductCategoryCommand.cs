namespace Paris.RMS.UseCases.ProductCategorys.Update;

public sealed class UpdateProductCategoryCommand(string id, string name, string? parentId)
    : ICommand<UpdateProductCategoryResponse>
{
    public string Id { get; } = id;
    public string Name { get; } = name;
    public string? ParentId { get; } = parentId;
}
