namespace Paris.RMS.Persistences.Configurations;

public static class ConfigurationConstants
{
    public const string UniqueIdentifier = nameof(UniqueIdentifier);
    public const string TinyInt = nameof(TinyInt);
    public const string Bit = nameof(Bit);
    public const int DefaultVarCharLength = 255;
    public const int DefaultIdLength = 26;

    public static string DateTimeOffset(int lenght) => $"{nameof(DateTimeOffset)}({lenght})";
    public static string TimeStamp(int lenght) => $"{nameof(TimeStamp)}({lenght})";
    public static string NChar(int lenght) => $"{nameof(NChar)}({lenght})";
    public static string VarChar(int lenght) => $"{nameof(VarChar)}({lenght})";
    public static string Char(int lenght) => $"{nameof(Char)}({lenght})";
    public static string Binary(int lenght) => $"{nameof(Binary)}({lenght})";
    public static string UnsignedTinyInt(int length) => $"TINYINT({length}) UNSIGNED";
    public static string Decimal(int precision, int scale) => $"{nameof(Decimal)}({precision},{scale})";
}
