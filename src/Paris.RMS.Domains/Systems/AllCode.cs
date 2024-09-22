namespace Paris.RMS.Domains.Systems;

public sealed class AllCode : EntityBase
{
    public string CdName { get; set; } = string.Empty;
    public string CdType { get; set; } = string.Empty;
    public string CdVal { get; set; } = string.Empty;
    public int LstOdr { get; set; }
}
