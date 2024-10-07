namespace Paris.RMS.UseCases.Systems.AllCodes.Create;

public sealed class CreateAllCodeCommand(string cdName, string cdType, string cdVal, int lstOdr)
    : ICommand<CreateAllCodeResponse>
{
    public string CdName { get; } = cdName;
    public string CdType { get; } = cdType;
    public string CdVal { get; } = cdVal;
    public int LstOdr { get; } = lstOdr;
}
