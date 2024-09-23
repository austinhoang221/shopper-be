namespace Paris.RMS.Domains.Products;

public sealed class Product : EntityBase
{
    private Product() { }

    private Product(string categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
    {
        CategoryId = categoryId;
        CostPrice = costPrice;
        Name = name;
        ProductCd = productCd;
        SellingPrice = sellingPrice;
        Stock = stock;
        SupplierId = supplierId;
        TxDesc = txDesc;
        Unit = unit;
        Weight = weight;
    }

    public string CategoryId { get; private set; } = string.Empty;
    public decimal CostPrice { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string ProductCd { get; private set; } = string.Empty;
    public decimal SellingPrice { get; private set; }
    public int Stock { get; private set; }
    public string SupplierId { get; private set; } = string.Empty;
    public string TxDesc { get; private set; } = string.Empty;
    public string Unit { get; private set; } = string.Empty;
    public decimal Weight { get; private set; }

    public static Product Create(string categoryId, decimal costPrice, int stock,
        string name, string productCd, decimal sellingPrice, string supplierId, string txDesc, string unit,
        decimal weight)
        => new(categoryId, costPrice, name, productCd, sellingPrice, stock, supplierId, txDesc, unit, weight);

    public void Update(string categoryId, decimal costPrice,
        string name, string productCd, decimal sellingPrice,
        int stock, string supplierId, string txDesc, string unit,
        decimal weight)
    {
        CategoryId = categoryId;
        CostPrice = costPrice;
        Name = name;
        ProductCd = productCd;
        SellingPrice = sellingPrice;
        Stock = stock;
        SupplierId = supplierId;
        TxDesc = txDesc;
        Unit = unit;
        Weight = weight;
    }

    public void Delete()
    {
        RegisterDomainEvent(new ProductDeletedDomainEvent(Id));
    }
}
