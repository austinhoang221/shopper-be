namespace Paris.RMS.Domains.Products.DomainEvents;

internal sealed class ProductDeletedDomainEvent(string productId) : DomainEvent
{
    public string ProductId { get; } = productId;
}
