
namespace Paris.RMS.Persistences.Configurations.Products;

internal sealed class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ConfigureEntityBase(false);

        builder.Property(pc => pc.Name)
            .HasMaxLength(DefaultVarCharLength)
            .IsRequired();

        builder.Property(pc => pc.ParentId)
            .HasMaxLength(DefaultIdLength);
    }
}
