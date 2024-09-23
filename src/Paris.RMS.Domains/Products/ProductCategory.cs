namespace Paris.RMS.Domains.Products;

public sealed class ProductCategory : EntityBase
{
    private ProductCategory() { }

    private ProductCategory(string name, string? parentId)
    {
        Name = name;
        ParentId = parentId;
    }

    public string Name { get; private set; } = string.Empty;
    public string? ParentId { get; private set; }

    public static ProductCategory Create(string name, string? parentId)
        => new(name, parentId);

    public void Update(string name, string? parentId)
    {
        Name = name;
        ParentId = parentId;
    }

    public void Delete()
    {
        RegisterDomainEvent(new ProductCategoryDeletedDomainEvent(Id));
    }
}
