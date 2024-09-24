using Paris.RMS.API.Products.ViewModels.V1;
using Paris.RMS.UseCases.Products.Create;
using Paris.RMS.UseCases.Products.Delete;
using Paris.RMS.UseCases.Products.Get;
using Paris.RMS.UseCases.Products.List;
using Paris.RMS.UseCases.Products.Update;

namespace Paris.RMS.API.Products;

[ApiVersion("1.0")]
public class ProductsController(IMediator mediator) : ApiController(mediator)
{
    /// <summary>
    /// Get the list of products
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the list of products</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpGet]
    [ProducesResponseType<IReadOnlyCollection<ListProductQuery>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> List(CancellationToken cancellationToken)
        => await Result.Success(new ListProductQuery())
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, BadRequest);

    /// <summary>
    /// Get the product by id
    /// </summary>
    /// <param name="id">The id of product</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the product</response>
    /// <response code="404">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpGet("{id}")]
    [ProducesResponseType<GetProductResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(string id, CancellationToken cancellationToken)
        => await Result.Success(new GetProductQuery(id))
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, NotFound);

    /// <summary>
    /// Create the new product
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the newly created product</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpPost]
    [ProducesResponseType<CreateProductResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request, CancellationToken cancellationToken)
        => await Result.Success(request.ToCommand())
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(CreatedAtAction, BadRequest, nameof(Get));

    /// <summary>
    /// Update the product by id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the updated product</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpPut("{id}")]
    [ProducesResponseType<UpdateProductResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateProductRequest request, CancellationToken cancellationToken)
        => await Result.Success(request.ToCommand(id))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(OK, BadRequest);

    /// <summary>
    /// Delete the product by id
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
    public async Task<IActionResult> Delete(string id, CancellationToken cancellationToken)
        => await Result.Success(new DeleteProductCommand(id))
        .CallHandler(command => Mediator.Send(command, cancellationToken))
        .Match(NoContent, BadRequest);
}
