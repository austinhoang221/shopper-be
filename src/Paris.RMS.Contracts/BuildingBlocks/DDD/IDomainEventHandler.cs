namespace Paris.RMS.Contracts.BuildingBlocks.DDD;

public interface IDomainEventHandler<in TEvent> : INotificationHandler<TEvent>
where TEvent : IDomainEvent
{
}
