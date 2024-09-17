namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasLastModificationTime
{
    DateTimeOffset? LastModificationTime { get; }
}
