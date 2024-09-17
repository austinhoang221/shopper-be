namespace Paris.RMS.Persistences.Databases;

public sealed class ConnectionStringOptions
{
    public const string Name = nameof(ConnectionStringOptions);

    public string ParisRmsConnection { get; set; } = string.Empty;

    public string AdminParisRmsConnection { get; set; } = string.Empty;
}
