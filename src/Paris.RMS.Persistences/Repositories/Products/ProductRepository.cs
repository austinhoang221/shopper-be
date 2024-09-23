namespace Paris.RMS.Persistences.Repositories.Products;

internal class ProductRepository(IDbContext context) : RepositoryBase<Product>(context), IProductRepository
{
    public async Task DeleteByProductCategoryIdAsync(string productCategoryId)
    {
        await Entity
            .Where(p => p.CategoryId == productCategoryId)
            .ExecuteDeleteAsync();
    }
}
