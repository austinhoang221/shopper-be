namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public abstract class EntityBase : HasDomainEventsBase, IEntityBase
{
    public Ulid Id { get; set; } = Ulid.NewUlid();

    public DateTimeOffset CreationTime { get; set; }

    public DateTimeOffset? LastModificationTime { get; set; }
}
