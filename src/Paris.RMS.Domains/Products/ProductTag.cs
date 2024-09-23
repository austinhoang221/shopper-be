namespace Paris.RMS.Domains.Products;

public sealed class ProductTag : EntityBase
{
    private ProductTag() { }

    private ProductTag(string productId, string tagName)
    {
        ProductId = productId;
        TagName = tagName;
    }

    public string ProductId { get; private set; } = string.Empty;
    public string TagName { get; private set; } = string.Empty;

    public static ProductTag Create(string productId, string tagName)
        => new(productId, tagName);

    public void Update(string productId, string tagName)
    {
        ProductId = productId;
        TagName = tagName;
    }
}
