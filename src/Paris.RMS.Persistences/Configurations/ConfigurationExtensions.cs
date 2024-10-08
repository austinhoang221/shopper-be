﻿using Microsoft.EntityFrameworkCore;

namespace Paris.RMS.Persistences.Configurations;

public static class ConfigurationExtensions
{
    public static EntityTypeBuilder<TEntity> ConfigureAuditableEntity<TEntity>(this EntityTypeBuilder<TEntity> builder, bool useUpdatedOnAsConcurrencyToken = true)
        where TEntity : class, IAuditEntityBase
    {
        builder.Property(o => o.CreatorUserId)
            .HasColumnType(VarChar(DefaultIdLength));

        builder.Property(o => o.CreationTime)
            .HasColumnType(TimeStamp(2));

        builder.Property(o => o.LastModificationUserId)
            .HasColumnType(VarChar(DefaultIdLength))
            .IsRequired(false);

        if (useUpdatedOnAsConcurrencyToken)
        {
            builder.Property(o => o.LastModificationTime)
                .HasColumnType(TimeStamp(6))
                .IsConcurrencyToken(true)
                .IsRequired(false);

            return builder;
        }

        builder.Property(o => o.LastModificationTime)
            .HasColumnType(TimeStamp(2))
            .IsRequired(false);

        builder.Property(o => o.IsDelete)
            .HasColumnType(Bit)
            .HasDefaultValue(false);

        builder.Property(o => o.DeletionTime)
            .HasColumnType(TimeStamp(2))
            .IsRequired(false);

        return builder;
    }

    public static EntityTypeBuilder<TEntity> ConfigureEntityBase<TEntity>(this EntityTypeBuilder<TEntity> builder, bool useUpdatedOnAsConcurrencyToken = true)
        where TEntity : class, IEntityBase
    {
        builder
            .Property(e => e.Id)
            .HasConversion<UlidToStringConverter>();

        builder.Property(o => o.Id)
            .HasColumnType(VarChar(DefaultIdLength));

        builder.HasKey(o => o.Id);

        builder.Property(o => o.CreationTime)
            .HasColumnType(TimeStamp(2));

        if (useUpdatedOnAsConcurrencyToken)
        {
            builder.Property(o => o.LastModificationTime)
                .HasColumnType(TimeStamp(6))
                .IsConcurrencyToken(true)
                .IsRequired(false);

            return builder;
        }

        builder.Property(o => o.LastModificationTime)
            .HasColumnType(TimeStamp(2))
            .IsRequired(false);

        return builder;
    }
}
