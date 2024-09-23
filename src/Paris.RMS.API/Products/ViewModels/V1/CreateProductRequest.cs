using Azure.Core;
using Paris.RMS.UseCases.Products.Create;

namespace Paris.RMS.API.Products.ViewModels.V1;

public sealed class CreateProductRequest(string categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
{
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

    public CreateProductCommand ToCommand()
    => new(CategoryId, CostPrice, Name, ProductCd,
        SellingPrice, Stock, SupplierId, TxDesc, Unit, Weight);
}
