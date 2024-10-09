namespace Paris.RMS.Domains.Products;

public sealed class ProductTag : EntityBase
{
    private ProductTag() { }

    private ProductTag(Ulid productId, string tagName)
    {
        ProductId = productId;
        TagName = tagName;
    }

    public Ulid ProductId { get; private set; }
    public string TagName { get; private set; } = string.Empty;

    public static ProductTag Create(Ulid productId, string tagName)
        => new(productId, tagName);

    public void Update(Ulid productId, string tagName)
    {
        ProductId = productId;
        TagName = tagName;
    }
}
