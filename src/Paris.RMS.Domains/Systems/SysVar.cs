namespace Paris.RMS.Domains.Systems;

public sealed class SysVar : EntityBase
{
    public SysVar()
    {
    }

    public SysVar(bool editAllow, string varDesc, string varName, string varValue)
    {
        EditAllow = editAllow;
        VarDesc = varDesc;
        VarName = varName;
        VarValue = varValue;
    }

    public bool EditAllow { get; private set; } = false;
    public string VarDesc { get; private set; } = string.Empty;
    public string VarName { get; private set; } = string.Empty;
    public string VarValue { get; private set; } = string.Empty;

    public static SysVar Create(bool editAllow, string varDesc, string varName, string varValue)
        => new(editAllow, varDesc, varName, varValue);

    public void Update(bool editAllow, string varDesc, string varName, string varValue)
    {
        EditAllow = editAllow;
        VarDesc = varDesc;
        VarName = varName;
        VarValue = varValue;
    }
}
