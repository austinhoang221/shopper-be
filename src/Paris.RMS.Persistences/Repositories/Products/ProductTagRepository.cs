namespace Paris.RMS.Persistences.Repositories.Products;

internal class ProductTagRepository(IDbContext context) : RepositoryBase<ProductTag>(context), IProductTagRepository
{
    public async Task DeleteByProductId(Ulid productId)
    {
        await Entity
            .Where(pt => pt.ProductId == productId)
            .ExecuteDeleteAsync();
    }
}
