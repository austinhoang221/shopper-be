namespace Paris.RMS.Persistences.Configurations.Systems;

internal sealed class CmdMenuConfiguration : IEntityTypeConfiguration<CmdMenu>
{
    public void Configure(EntityTypeBuilder<CmdMenu> builder)
    {
        builder.Property(f => f.CmdName).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.CmdParent).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.Icon).HasMaxLength(DefaultVarCharLength);

        builder.Property(f => f.ObjName).HasMaxLength(DefaultVarCharLength);

        builder.ConfigureEntityBase(false);
    }
}
