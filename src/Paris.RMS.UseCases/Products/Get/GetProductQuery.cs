
namespace Paris.RMS.UseCases.Products.Get;

public sealed class GetProductQuery(string id)
    : IQuery<GetProductResponse>
{
    public string Id { get; } = id;
}
