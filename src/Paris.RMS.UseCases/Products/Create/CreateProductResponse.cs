namespace Paris.RMS.UseCases.Products.Create;

public sealed class CreateProductResponse(string id, string categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
    : ICreatedResponse
{
    public string Id { get; } = id;
    public string CategoryId { get; } = categoryId;
    public decimal CostPrice { get; } = costPrice;
    public string Name { get; } = name;
    public string ProductCd { get; } = productCd;
    public decimal SellingPrice { get; } = sellingPrice;
    public int Stock { get; } = stock;
    public string SupplierId { get; } = supplierId;
    public string TxDesc { get; } = txDesc;
    public string Unit { get; } = unit;
    public decimal Weight { get; } = weight;
}
