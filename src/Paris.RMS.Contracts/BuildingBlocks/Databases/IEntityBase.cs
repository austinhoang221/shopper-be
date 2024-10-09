namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IEntityBase : IPrimaryKey<Ulid>, IHasCreationTime, IHasLastModificationTime
{
}
