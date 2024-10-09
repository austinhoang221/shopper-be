using Paris.RMS.UseCases.Products.Update;

namespace Paris.RMS.Cms.Products.ViewModels.V1;

public sealed class UpdateProductRequest(Ulid categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
{
    public Ulid CategoryId { get; } = categoryId;
    public decimal CostPrice { get; } = costPrice;
    public string Name { get; } = name;
    public string ProductCd { get; } = productCd;
    public decimal SellingPrice { get; } = sellingPrice;
    public int Stock { get; } = stock;
    public string SupplierId { get; } = supplierId;
    public string TxDesc { get; } = txDesc;
    public string Unit { get; } = unit;
    public decimal Weight { get; } = weight;


    public UpdateProductCommand ToCommand(Ulid id)
    => new(id, CategoryId, CostPrice, Name, ProductCd,
        SellingPrice, Stock, SupplierId, TxDesc, Unit, Weight);
}
