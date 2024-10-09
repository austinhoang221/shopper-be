namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

public interface IHasCursor
{
    public Ulid Id { get; }
}
