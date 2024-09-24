namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryCommand(string id)
    : ICommand
{
    public string Id { get; } = id;
}
