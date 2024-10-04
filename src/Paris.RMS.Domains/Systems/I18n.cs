namespace Paris.RMS.Domains.Systems;

public sealed class I18n : EntityBase
{
    private I18n()
    {
    }

    private I18n(string enUs, string frFr, string key, string viVn)
    {
        EnUs = enUs;
        FrFr = frFr;
        Key = key;
        ViVn = viVn;
    }

    public string EnUs { get; private set; } = string.Empty;
    public string FrFr { get; private set; } = string.Empty;
    public string Key { get; private set; } = string.Empty;
    public string ViVn { get; private set; } = string.Empty;

    public static I18n Create(string enUs, string frFr, string key, string viVn)
        => new(enUs, frFr, key, viVn);

    public void Update(string enUs, string frFr, string key, string viVn)
    {
        EnUs = enUs;
        FrFr = frFr;
        Key = key;
        ViVn = viVn;
    }
}
