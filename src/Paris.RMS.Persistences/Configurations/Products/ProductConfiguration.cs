namespace Paris.RMS.Persistences.Configurations.Products;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ConfigureEntityBase(false);

        builder.Property(p => p.CategoryId)
            .HasMaxLength(DefaultIdLength)
            .IsRequired();

        builder.Property(p => p.Name)
            .HasMaxLength(DefaultVarCharLength)
            .IsRequired();

        builder.Property(p => p.ProductCd)
            .HasMaxLength(DefaultVarCharLength);

        builder.Property(p => p.CostPrice)
            .HasColumnType(Decimal(10, 2))
            .IsRequired();

        builder.Property(p => p.SellingPrice)
            .HasColumnType(Decimal(10, 2))
            .IsRequired();

        builder.Property(p => p.Stock)
            .IsRequired();

        builder.Property(p => p.SupplierId)
            .HasMaxLength(DefaultIdLength)
            .IsRequired();

        builder.Property(p => p.TxDesc)
            .IsRequired();

        builder.Property(p => p.Unit)
            .HasMaxLength(DefaultVarCharLength)
            .IsRequired();

        builder.Property(p => p.Weight)
            .HasColumnType(Decimal(10, 2))
            .IsRequired();
    }
}
