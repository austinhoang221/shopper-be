namespace Paris.RMS.Persistences.Repositories.Products;

internal class ProductCategoryRepository(IDbContext context) : RepositoryBase<ProductCategory>(context), IProductCategoryRepository
{
}
