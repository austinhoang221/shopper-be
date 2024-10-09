
namespace Paris.RMS.UseCases.Products.Get;

public sealed class GetProductQuery(Ulid id)
    : IQuery<GetProductResponse>
{
    public Ulid Id { get; } = id;
}
