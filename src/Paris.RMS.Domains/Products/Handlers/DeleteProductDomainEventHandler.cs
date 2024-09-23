namespace Paris.RMS.Domains.Products.Handlers;

internal sealed class DeleteProductDomainEventHandler(
    IProductTagRepository productTagRepository,
    ILogger<DeleteProductDomainEventHandler> logger) : IDomainEventHandler<ProductDeletedDomainEvent>
{
    public async Task Handle(ProductDeletedDomainEvent domainEvent, CancellationToken cancellationToken)
    {
        logger.LogInformation("Handling Product Deleted event for {ProductId}", domainEvent.ProductId);

        await productTagRepository.DeleteByProductId(domainEvent.ProductId);
    }
}
