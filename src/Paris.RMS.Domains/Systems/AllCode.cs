namespace Paris.RMS.Domains.Systems;

public sealed class AllCode : EntityBase
{
    private AllCode()
    {
    }

    private AllCode(string cdName, string cdType, string cdVal, int lstOdr)
    {
        CdName = cdName;
        CdType = cdType;
        CdVal = cdVal;
        LstOdr = lstOdr;
    }

    public string CdName { get; private set; } = string.Empty;
    public string CdType { get; private set; } = string.Empty;
    public string CdVal { get; private set; } = string.Empty;
    public int LstOdr { get; private set; }

    public static AllCode Create(string cdName, string cdType, string cdVal, int lstOdr)
        => new(cdName, cdType, cdVal, lstOdr);

    public void Update(string cdName, string cdType, string cdVal, int lstOdr)
    {
        CdName = cdName;
        CdType = cdType;
        CdVal = cdVal;
        LstOdr = lstOdr;
    }
}
