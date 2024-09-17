namespace Paris.RMS.Persistences.Configurations;

public static class ConfigurationConstants
{
    public const string UniqueIdentifier = nameof(UniqueIdentifier);
    public const string TinyInt = nameof(TinyInt);
    public const string Bit = nameof(Bit);
    public static string DateTimeOffset(int lenght) => $"{nameof(DateTimeOffset)}({lenght})";
    public static string NChar(int lenght) => $"{nameof(NChar)}({lenght})";
    public static string VarChar(int lenght) => $"{nameof(VarChar)}({lenght})";
    public static string Char(int lenght) => $"{nameof(Char)}({lenght})";
    public static string Binary(int lenght) => $"{nameof(Binary)}({lenght})";
}
