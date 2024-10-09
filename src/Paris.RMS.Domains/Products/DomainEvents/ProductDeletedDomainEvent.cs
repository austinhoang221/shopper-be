namespace Paris.RMS.Domains.Products.DomainEvents;

internal sealed class ProductDeletedDomainEvent(Ulid productId) : DomainEvent
{
    public Ulid ProductId { get; } = productId;
}
