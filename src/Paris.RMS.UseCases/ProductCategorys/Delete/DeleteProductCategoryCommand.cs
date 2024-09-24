namespace Paris.RMS.UseCases.ProductCategorys.Delete;

public sealed class DeleteProductCategoryCommand(string id)
    : ICommand<DeleteProductCategoryResponse>
{
    public string Id { get; } = id;
}
