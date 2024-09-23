using Paris.RMS.UseCases.Products.Update;

namespace Paris.RMS.API.Products.ViewModels.V1;

public sealed class UpdateProductRequest(string id, string categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
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

    public UpdateProductCommand ToCommand()
    => new(Id, CategoryId, CostPrice, Name, ProductCd,
        SellingPrice, Stock, SupplierId, TxDesc, Unit, Weight);
}
