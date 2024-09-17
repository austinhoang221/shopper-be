namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasDeletionTime : ISoftDeletable
{
    DateTimeOffset? DeletionTime { get; }
}
