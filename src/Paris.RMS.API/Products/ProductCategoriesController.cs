using Paris.RMS.API.Products.ViewModels.V1;
using Paris.RMS.UseCases.ProductCategorys.Create;
using Paris.RMS.UseCases.ProductCategorys.Delete;
using Paris.RMS.UseCases.ProductCategorys.List;
using Paris.RMS.UseCases.ProductCategorys.Update;

namespace Paris.RMS.API.Products;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/product-categories")]
public class ProductCategoriesController(IMediator mediator) : ApiController(mediator)
{
    [HttpGet]
    [ProducesResponseType<IReadOnlyCollection<ListProductCategoryResponse>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
        => await Result.Success(new ListProductCategoryQuery())
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, BadRequest);

    [HttpPost]
    [ProducesResponseType<CreateProductCategoryResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateProductCategoryRequest request, CancellationToken cancellationToken)
        => await Result.Success(new CreateProductCategoryCommand(request.Name, request.ParentId))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, "Get");

    [HttpPut("{id}")]
    [ProducesResponseType<UpdateProductCategoryResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateProductCategoryRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UpdateProductCategoryCommand(id, request.Name, request.ParentId))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(OK, BadRequest);

    [HttpDelete("{id}")]
    [ProducesResponseType<NoContent>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        => await Result.Success(new DeleteProductCategoryCommand(id))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(NoContent, BadRequest);
}
