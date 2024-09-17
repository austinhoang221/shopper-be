namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasCreationTime
{
    DateTimeOffset CreationTime { get; }
}
