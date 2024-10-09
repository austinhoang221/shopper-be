namespace Paris.RMS.Contracts.BuildingBlocks.Responses;

public interface ICreatedResponse<TIdentity>
{
    TIdentity Id { get; }
}

public interface ICreatedResponse : ICreatedResponse<Ulid>, IResponse
{

}
