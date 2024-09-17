namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public class EntityBase : IEntityBase, IPrimaryKey<string>
{
    public string Id { get; set; } = Ulid.NewUlid().ToString();

    public DateTimeOffset CreationTime { get; set; }

    public DateTimeOffset? LastModificationTime { get; set; }
}
