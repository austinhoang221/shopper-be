namespace Paris.RMS.Domains.Systems;

public sealed class CmdMenu : EntityBase
{
    public string CmdName { get; set; } = string.Empty;
    public string CmdParent { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string ObjName { get; set; } = string.Empty;
}
