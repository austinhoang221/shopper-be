namespace Paris.RMS.Domains.Products.DomainEvents;

internal sealed class ProductCategoryDeletedDomainEvent(Ulid productCategoryId) : DomainEvent
{
    public Ulid ProductCategoryId { get; } = productCategoryId;
}
