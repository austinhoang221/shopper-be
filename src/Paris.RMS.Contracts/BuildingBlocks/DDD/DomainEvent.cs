namespace Paris.RMS.Contracts.BuildingBlocks.DDD;

/// <summary>
/// DomainEvents are records of something that already occurred in our system.
/// Event names should be in the past.
/// </summary>
/// <param name="Id">DomainEvent id</param>
public abstract class DomainEvent : IDomainEvent
{
    public Ulid Id { get; init; } = Ulid.NewUlid();

    public DateTimeOffset OccurredTime { get; set; } = DateTimeOffset.UtcNow;
}

//We rise the domain event by the AggregateRoot, for instance after something has succeeded.
//The DomainEvents are handled using MediatR (they are just a notifications with a ulid Id)
//"<EventName>DomainEventHandler" are consumers of the domain events and they are present in the Application layer
