namespace Paris.RMS.UseCases.Products.Delete;

public sealed class DeleteProductCommand(Ulid id)
    : ICommand
{
    public Ulid Id { get; } = id;
}
