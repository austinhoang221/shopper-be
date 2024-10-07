namespace Paris.RMS.UseCases.Systems.AllCodes.Create;

public sealed class CreateAllCodeResponse(string id, string cdName, string cdType, string cdVal, int lstOdr)
    : ICreatedResponse
{
    public string Id { get; } = id;
    public string CdName { get; } = cdName;
    public string CdType { get; } = cdType;
    public string CdVal { get; } = cdVal;
    public int LstOdr { get; } = lstOdr;
}
