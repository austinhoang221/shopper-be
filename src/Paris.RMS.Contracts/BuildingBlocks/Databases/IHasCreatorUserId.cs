namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasCreatorUserId : IHasCreationTime
{
    string CreatorUserId { get; }
}
