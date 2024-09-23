namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public abstract class EntityBase : HasDomainEventsBase, IEntityBase
{
    public string Id { get; set; } = Ulid.NewUlid().ToString();

    public DateTimeOffset CreationTime { get; set; }

    public DateTimeOffset? LastModificationTime { get; set; }
}
