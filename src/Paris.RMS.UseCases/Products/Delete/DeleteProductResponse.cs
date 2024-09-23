namespace Paris.RMS.UseCases.Products.Delete;

public sealed class DeleteProductResponse(string id)
    : IResponse
{
    public string Id { get; } = id;
}
