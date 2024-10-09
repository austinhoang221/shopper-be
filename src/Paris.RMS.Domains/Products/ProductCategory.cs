using Paris.RMS.Domains.Products.Constants;

namespace Paris.RMS.Domains.Products;

public sealed class ProductCategory : EntityBase
{
    private ProductCategory() { }

    public ProductCategory(string name, Ulid? parentId, string icon)
    {
        Name = name;
        ParentId = parentId;
        Icon = icon;
        Visible = ProductCategoryConstants.VisibleDefault;
    }

    public string Name { get; private set; } = string.Empty;
    public Ulid? ParentId { get; private set; }
    public string Icon { get; set; } = string.Empty;
    public string Visible { get; set; } = ProductCategoryConstants.VisibleDefault;

    public static ProductCategory Create(string name, Ulid? parentId, string icon)
        => new(name, parentId, icon);

    public void Update(string name, Ulid? parentId, string icon, string visible)
    {
        Name = name;
        ParentId = parentId;
        Icon = icon;
        Visible = visible;
    }

    public void Delete()
    {
        RegisterDomainEvent(new ProductCategoryDeletedDomainEvent(Id));
    }
}
