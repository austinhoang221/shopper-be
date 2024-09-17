namespace Paris.RMS.Contracts.BuildingBlocks.EventBus.Events;

public class IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Ulid.NewUlid();
        CreationDate = DateTimeOffset.UtcNow;
    }

    [JsonInclude]
    public Ulid Id { get; set; }

    [JsonInclude]
    public DateTimeOffset CreationDate { get; set; }
}
