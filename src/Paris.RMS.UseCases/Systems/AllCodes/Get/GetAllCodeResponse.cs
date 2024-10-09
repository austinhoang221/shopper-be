namespace Paris.RMS.UseCases.Systems.AllCodes.Get;

public sealed class GetAllCodeResponse(Ulid id, string cdName, string cdType, string cdVal, int lstOdr)
    : IResponse
{
    public Ulid Id { get; } = id;
    public string CdName { get; } = cdName;
    public string CdType { get; } = cdType;
    public string CdVal { get; } = cdVal;
    public int LstOdr { get; } = lstOdr;
}
