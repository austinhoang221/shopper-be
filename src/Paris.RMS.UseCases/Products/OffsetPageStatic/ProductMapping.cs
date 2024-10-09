namespace Paris.RMS.UseCases.Products.OffsetPageStatic;

public static class ProductMapping
{
    public static Expression<Func<Product, ProductOffsetPageStaticResponse>> ProductResponse =>
        p => new ProductOffsetPageStaticResponse(
            p.Id, p.CategoryId, p.CostPrice, p.Name,
            p.ProductCd, p.SellingPrice, p.Stock, p.SupplierId, p.TxDesc,
            p.Unit, p.Weight
        );
}
