namespace Paris.RMS.Persistences.Databases;

public sealed class DatabaseOptions
{
    public const string Name = nameof(DatabaseOptions);
    public int MaxRetryCount { get; set; }
    public int MaxRetryDelay { get; set; }
    public int CommandTimeout { get; set; }
}
