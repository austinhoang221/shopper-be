namespace Paris.RMS.Contracts.BuildingBlocks.EventBus.Abstractions;

public interface IEventBusBuilder
{
    public IServiceCollection Services { get; }
}
