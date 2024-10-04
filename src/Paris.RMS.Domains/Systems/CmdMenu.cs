namespace Paris.RMS.Domains.Systems;

public sealed class CmdMenu : EntityBase
{
    private CmdMenu() { }

    private CmdMenu(string cmdName, string cmdParent, string icon, string objName)
    {
        CmdName = cmdName;
        CmdParent = cmdParent;
        Icon = icon;
        ObjName = objName;
    }

    public string CmdName { get; private set; } = string.Empty;
    public string CmdParent { get; private set; } = string.Empty;
    public string Icon { get; private set; } = string.Empty;
    public string ObjName { get; private set; } = string.Empty;

    public static CmdMenu Create(string cmdName, string cmdParent, string icon, string objName)
        => new(cmdName, cmdParent, icon, objName);

    public void Update(string cmdName, string cmdParent, string icon, string objName)
    {
        CmdName = cmdName;
        CmdParent = cmdParent;
        Icon = icon;
        ObjName = objName;
    }
}
