namespace Paris.RMS.Contracts.BuildingBlocks.DDD;

public interface IDomainEvent : INotification
{
    Ulid Id { get; init; }

    DateTimeOffset OccurredTime { get; }
}
