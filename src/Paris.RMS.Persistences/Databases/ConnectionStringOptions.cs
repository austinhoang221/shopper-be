namespace Paris.RMS.Persistences.Databases;

public sealed class ConnectionStringOptions
{
    public const string Name = "ConnectionStrings";

    public string ParisRmsConnection { get; set; } = string.Empty;
}
