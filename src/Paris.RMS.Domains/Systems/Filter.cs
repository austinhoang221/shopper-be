namespace Paris.RMS.Domains.Systems;

public sealed class Filter : EntityBase
{
    public string DefVal { get; set; } = string.Empty;
    public string FldCode { get; set; } = string.Empty;
    public string FldName { get; set; } = string.Empty;
    public string FldType { get; set; } = string.Empty;
    public string LookupCmdSql { get; set; } = string.Empty;
    public string ObjName { get; set; } = string.Empty;
    public int Position { get; set; }
    public string SearchCode { get; set; } = string.Empty;
}
