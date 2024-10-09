namespace Paris.RMS.Domains.Products;

public interface IProductRepository : IRepositoryBase<Product>
{
    Task DeleteByProductCategoryIdAsync(Ulid productCategoryId);
}
