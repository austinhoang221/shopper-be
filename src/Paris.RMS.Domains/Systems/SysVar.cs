namespace Paris.RMS.Domains.Systems;

public sealed class SysVar : EntityBase
{
    public bool EditAllow { get; set; } = false;
    public string VarDesc { get; set; } = string.Empty;
    public string VarName { get; set; } = string.Empty;
    public string VarValue { get; set; } = string.Empty;

}
