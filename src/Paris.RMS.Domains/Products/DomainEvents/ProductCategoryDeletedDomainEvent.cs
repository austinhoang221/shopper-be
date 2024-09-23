namespace Paris.RMS.Domains.Products.DomainEvents;

internal sealed class ProductCategoryDeletedDomainEvent(string productCategoryId) : DomainEvent
{
    public string ProductCategoryId { get; } = productCategoryId;
}
