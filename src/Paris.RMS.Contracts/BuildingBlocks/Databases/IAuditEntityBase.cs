namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IAuditEntityBase : IHasCreatorUserId, IHasLastModificationUserId, IHasDeletionUserId
{
}
