namespace Paris.RMS.Contracts.BuildingBlocks.Responses;

public interface IResponse
{

}
public interface ICreatedResponse<TIdentity>
{
    TIdentity Id { get; }
}

public interface ICreatedResponse : ICreatedResponse<string>, IResponse
{

}
