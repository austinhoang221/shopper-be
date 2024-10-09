namespace Paris.RMS.UseCases.Systems.AllCodes.Delete;

public sealed class DeleteAllCodeCommand(Ulid id)
    : ICommand
{
    public Ulid Id { get; } = id;
}
