namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryCommand(Ulid id)
    : ICommand
{
    public Ulid Id { get; } = id;
}
