namespace Paris.RMS.Persistences.Configurations.Systems;

internal sealed class I18nConfiguration : IEntityTypeConfiguration<I18n>
{
    public void Configure(EntityTypeBuilder<I18n> builder)
    {
        builder.Property(f => f.Key).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.EnUs);

        builder.Property(f => f.FrFr);

        builder.Property(f => f.ViVn);

        builder.ConfigureEntityBase(false);
    }
}
