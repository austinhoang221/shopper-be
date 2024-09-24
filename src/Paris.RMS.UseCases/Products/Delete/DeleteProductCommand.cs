namespace Paris.RMS.UseCases.Products.Delete;

public sealed class DeleteProductCommand(string id)
    : ICommand
{
    public string Id { get; } = id;
}
