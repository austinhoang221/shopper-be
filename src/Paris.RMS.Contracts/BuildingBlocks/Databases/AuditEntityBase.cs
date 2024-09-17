namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public abstract class AuditEntityBase : IAuditEntityBase
{
    public string CreatorUserId { get; set; } = string.Empty;

    public DateTimeOffset CreationTime { get; set; }

    public string? LastModificationUserId { get; set; }

    public DateTimeOffset? LastModificationTime { get; set; }

    public string? DeletionUserId { get; set; }

    public DateTimeOffset? DeletionTime { get; set; }

    public bool IsDelete { get; set; }
}
