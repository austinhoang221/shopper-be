namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasLastModificationUserId : IHasLastModificationTime
{
    string? LastModificationUserId { get; }
}
