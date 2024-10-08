namespace Paris.RMS.UseCases.Systems.AllCodes.Delete;

public sealed class DeleteAllCodeCommand(string id)
    : ICommand
{
    public string Id { get; } = id;
}
