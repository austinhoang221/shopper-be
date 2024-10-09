using Paris.RMS.Cms.Products.ViewModels.V1;
using Paris.RMS.UseCases.ProductCategorys.Create;
using Paris.RMS.UseCases.ProductCategorys.Delete;
using Paris.RMS.UseCases.ProductCategorys.Get;
using Paris.RMS.UseCases.ProductCategorys.List;
using Paris.RMS.UseCases.ProductCategorys.Update;

namespace Paris.RMS.Cms.Products;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/product-categories")]
public class ProductCategoriesController(IMediator mediator) : ApiController(mediator)
{
    /// <summary>
    /// Get the list of product category categories
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the list of product category categories</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpGet]
    [ProducesResponseType<IReadOnlyCollection<ListProductCategoryResponse>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
        => await Result.Success(new ListProductCategoryQuery())
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, BadRequest);

    /// <summary>
    /// Get the product category categories by id
    /// </summary>
    /// <param name="id">The id of product category</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the product category</response>
    /// <response code="404">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpGet("{id}")]
    [ProducesResponseType<GetProductCategoryResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Ulid id, CancellationToken cancellationToken)
        => await Result.Success(new GetProductCategoryQuery(id))
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, NotFound);

    /// <summary>
    /// Create the new product category
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the newly created product category</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpPost]
    [ProducesResponseType<CreateProductCategoryResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateProductCategoryRequest request, CancellationToken cancellationToken)
        => await Result.Success(new CreateProductCategoryCommand(request.Name, request.ParentId, request.Icon))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, nameof(Get));

    /// <summary>
    /// Update the product category by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the updated product category</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpPut("{id}")]
    [ProducesResponseType<UpdateProductCategoryResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(Ulid id, [FromBody] UpdateProductCategoryRequest request, CancellationToken cancellationToken)
        => await Result.Success(new UpdateProductCategoryCommand(id, request.Name, request.ParentId, request.Icon, request.Visible))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(OK, BadRequest);

    /// <summary>
    /// Delete the product category by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="204">Return the 204 status code</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpDelete("{id}")]
    [ProducesResponseType<NoContent>(StatusCodes.Status204NoContent)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Delete(Ulid id, CancellationToken cancellationToken)
        => await Result.Success(new DeleteProductCategoryCommand(id))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(NoContent, BadRequest);
}
