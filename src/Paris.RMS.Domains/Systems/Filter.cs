namespace Paris.RMS.Domains.Systems;

public sealed class Filter : EntityBase
{
    private Filter()
    {
    }

    private Filter(string defVal, string fldCode, string fldName,
        string fldType, string lookupCmdSql, string objName,
        int position, string searchCode)
    {
        DefVal = defVal;
        FldCode = fldCode;
        FldName = fldName;
        FldType = fldType;
        LookupCmdSql = lookupCmdSql;
        ObjName = objName;
        Position = position;
        SearchCode = searchCode;
    }

    public string DefVal { get; private set; } = string.Empty;
    public string FldCode { get; private set; } = string.Empty;
    public string FldName { get; private set; } = string.Empty;
    public string FldType { get; private set; } = string.Empty;
    public string LookupCmdSql { get; private set; } = string.Empty;
    public string ObjName { get; private set; } = string.Empty;
    public int Position { get; private set; }
    public string SearchCode { get; private set; } = string.Empty;

    public static Filter Create(string defVal, string fldCode, string fldName,
        string fldType, string lookupCmdSql, string objName,
        int position, string searchCode)
        => new(defVal, fldCode, fldName, fldType, lookupCmdSql, objName, position, searchCode);

    public void Update(string defVal, string fldCode, string fldName,
        string fldType, string lookupCmdSql, string objName,
        int position, string searchCode)
    {
        DefVal = defVal;
        FldCode = fldCode;
        FldName = fldName;
        FldType = fldType;
        LookupCmdSql = lookupCmdSql;
        ObjName = objName;
        Position = position;
        SearchCode = searchCode;
    }
}
