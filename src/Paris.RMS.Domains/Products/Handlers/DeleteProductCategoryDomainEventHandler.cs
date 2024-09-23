namespace Paris.RMS.Domains.Products.Handlers;

internal sealed class DeleteProductCategoryDomainEventHandler(
    IProductRepository productRepository,
    ILogger<DeleteProductCategoryDomainEventHandler> logger)
    : IDomainEventHandler<ProductCategoryDeletedDomainEvent>
{
    public async Task Handle(ProductCategoryDeletedDomainEvent domainEvent, CancellationToken cancellationToken)
    {
        logger.LogInformation("Handling ProductCategory Deleted event for {ProductCategoryId}", domainEvent.ProductCategoryId);

        await productRepository.DeleteByProductCategoryIdAsync(domainEvent.ProductCategoryId);
    }
}
