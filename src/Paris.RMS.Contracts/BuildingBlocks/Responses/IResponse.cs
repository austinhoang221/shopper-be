namespace Paris.RMS.Contracts.BuildingBlocks.Responses;

public interface IResponse : IResponse<string>
{

}

public interface IResponse<TIdentity>
{
    TIdentity Id { get; }
}
