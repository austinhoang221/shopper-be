using Paris.RMS.API.Products.ViewModels.V1;
using Paris.RMS.UseCases.Products.Create;
using Paris.RMS.UseCases.Products.Delete;
using Paris.RMS.UseCases.Products.List;
using Paris.RMS.UseCases.Products.Update;

namespace Paris.RMS.API.Products;

[ApiVersion("1.0")]
public class ProductsController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    [ProducesResponseType<IReadOnlyCollection<ListProductQuery>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
        => await Result.Success(new ListProductQuery())
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(Ok, BadRequest);

    [HttpPost]
    [ProducesResponseType<CreateProductResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        => await Result.Success(new CreateProductCommand(request.CategoryId, request.CostPrice, request.Name,
            request.ProductCd, request.SellingPrice, request.Stock, request.SupplierId, request.TxDesc, request.Unit, request.Weight))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, "Get");

    [HttpPut("{id}")]
    [ProducesResponseType<UpdateProductResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateProductRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UpdateProductCommand(id, request.CategoryId, request.CostPrice, request.Name,
            request.ProductCd, request.SellingPrice, request.Stock, request.SupplierId, request.TxDesc, request.Unit, request.Weight))
        .CallHandler(command => Mediator.Send(command))
        .Match(Ok, BadRequest);

    [HttpDelete("{id}")]
    [ProducesResponseType<IActionResult>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        => await Result.Success(new DeleteProductCommand(id))
        .CallHandler(command => Mediator.Send(command))
        .Match(Ok, BadRequest);
}
