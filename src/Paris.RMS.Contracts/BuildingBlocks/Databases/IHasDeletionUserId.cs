namespace Paris.RMS.Contracts.BuildingBlocks.Databases;

public interface IHasDeletionUserId : IHasDeletionTime
{
    string? DeletionUserId { get; }
}
