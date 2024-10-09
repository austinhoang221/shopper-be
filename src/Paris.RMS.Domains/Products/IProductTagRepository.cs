namespace Paris.RMS.Domains.Products;

public interface IProductTagRepository : IRepositoryBase<ProductTag>
{
    Task DeleteByProductId(Ulid productId);
}
