namespace Paris.RMS.Persistences.Configurations;

public static class ConfigurationExtensions
{
    public static EntityTypeBuilder<TEntity> ConfigureAuditableEntity<TEntity>(this EntityTypeBuilder<TEntity> builder, bool useUpdatedOnAsConcurrencyToken = true)
        where TEntity : class, IAuditEntityBase
    {
        builder.Property(o => o.CreatorUserId)
            .HasColumnType(ConfigurationConstants.VarChar(30));

        builder.Property(o => o.CreationTime)
            .HasColumnType(ConfigurationConstants.DateTimeOffset(2));

        builder.Property(o => o.LastModificationUserId)
            .HasColumnType(ConfigurationConstants.VarChar(30))
            .IsRequired(false);

        if (useUpdatedOnAsConcurrencyToken)
        {
            builder.Property(o => o.LastModificationTime)
                .HasColumnType(ConfigurationConstants.DateTimeOffset(7))
                .IsConcurrencyToken(true)
                .IsRequired(false);

            return builder;
        }

        builder.Property(o => o.LastModificationTime)
            .HasColumnType(ConfigurationConstants.DateTimeOffset(2))
            .IsRequired(false);

        builder.Property(o => o.IsDelete)
            .HasColumnType(ConfigurationConstants.Bit)
            .HasDefaultValue(false);

        builder.Property(o => o.DeletionTime)
            .HasColumnType(ConfigurationConstants.DateTimeOffset(2))
            .IsRequired(false);

        return builder;
    }

    public static EntityTypeBuilder<TEntity> ConfigureEntityBase<TEntity>(this EntityTypeBuilder<TEntity> builder, bool useUpdatedOnAsConcurrencyToken = true)
        where TEntity : class, IEntityBase
    {
        builder.Property(o => o.CreationTime)
            .HasColumnType(ConfigurationConstants.DateTimeOffset(2));

        if (useUpdatedOnAsConcurrencyToken)
        {
            builder.Property(o => o.LastModificationTime)
                .HasColumnType(ConfigurationConstants.DateTimeOffset(7))
                .IsConcurrencyToken(true)
                .IsRequired(false);

            return builder;
        }

        builder.Property(o => o.LastModificationTime)
            .HasColumnType(ConfigurationConstants.DateTimeOffset(2))
            .IsRequired(false);

        return builder;
    }
}
