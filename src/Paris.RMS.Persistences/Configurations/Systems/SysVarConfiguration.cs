namespace Paris.RMS.Persistences.Configurations.Systems;

internal sealed class SysVarConfiguration : IEntityTypeConfiguration<SysVar>
{
    public void Configure(EntityTypeBuilder<SysVar> builder)
    {
        builder.Property(f => f.VarDesc).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.VarName).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.VarValue).HasMaxLength(DefaultVarCharLength);

        builder.ConfigureEntityBase(false);
    }
}
