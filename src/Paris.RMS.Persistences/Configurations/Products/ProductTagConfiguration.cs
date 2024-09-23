namespace Paris.RMS.Persistences.Configurations.Products;

internal sealed class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> builder)
    {
        builder.ConfigureEntityBase();

        builder.Property(pt => pt.ProductId)
            .HasMaxLength(DefaultIdLength)
            .IsRequired();

        builder.Property(pt => pt.TagName)
            .HasMaxLength(DefaultVarCharLength)
            .IsRequired();
    }
}
