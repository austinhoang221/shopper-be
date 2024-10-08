namespace Paris.RMS.UseCases.Systems.AllCodes.Get;

public sealed class GetAllCodeQuery(string id)
    : IQuery<GetAllCodeResponse>
{
    public string Id { get; } = id;
}
