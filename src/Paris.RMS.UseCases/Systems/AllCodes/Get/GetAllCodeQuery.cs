namespace Paris.RMS.UseCases.Systems.AllCodes.Get;

public sealed class GetAllCodeQuery(Ulid id)
    : IQuery<GetAllCodeResponse>
{
    public Ulid Id { get; } = id;
}
