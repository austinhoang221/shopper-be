namespace Paris.RMS.UseCases.ProductCategorys.Get;

public sealed class GetProductCategoryQuery(Ulid id)
    : IQuery<GetProductCategoryResponse>
{
    public Ulid Id { get; } = id;
}
