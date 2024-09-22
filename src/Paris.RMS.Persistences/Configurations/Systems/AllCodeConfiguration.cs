namespace Paris.RMS.Persistences.Configurations.Systems;

internal sealed class AllCodeConfiguration : IEntityTypeConfiguration<AllCode>
{
    public void Configure(EntityTypeBuilder<AllCode> builder)
    {
        builder.Property(a => a.CdName).HasMaxLength(DefaultVarCharLength);

        builder.Property(a => a.CdType).HasMaxLength(DefaultVarCharLength);

        builder.Property(a => a.CdVal).HasMaxLength(DefaultVarCharLength);

        builder.Property(a => a.LstOdr).HasMaxLength(DefaultVarCharLength);

        builder.ConfigureEntityBase(false);
    }
}
