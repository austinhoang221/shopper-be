namespace Paris.RMS.Persistences.Configurations.Systems;

internal sealed class FilterConfiguration : IEntityTypeConfiguration<Filter>
{
    public void Configure(EntityTypeBuilder<Filter> builder)
    {
        builder.Property(f => f.DefVal).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.FldCode).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.FldName).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.FldType).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.LookupCmdSql);

        builder.Property(f => f.ObjName).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.SearchCode);

        builder.Property(f => f.Position).HasColumnType(UnsignedTinyInt(4));

        builder.ConfigureEntityBase(false);
    }
}
