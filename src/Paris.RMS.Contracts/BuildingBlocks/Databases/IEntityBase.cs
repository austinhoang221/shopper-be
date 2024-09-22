namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IEntityBase : IPrimaryKey<string>, IHasCreationTime, IHasLastModificationTime
{
}
