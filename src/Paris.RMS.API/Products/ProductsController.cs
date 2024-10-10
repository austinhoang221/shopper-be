using Paris.RMS.UseCases.Products.Get;
using Paris.RMS.UseCases.Products.List;
using Paris.RMS.UseCases.Products.OffsetPageStatic;

namespace Paris.RMS.API.Products;

[AllowAnonymous]
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
    [ProducesResponseType<IReadOnlyCollection<ListProductResponse>>(StatusCodes.Status200OK)]
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
    public async Task<IActionResult> Get(Ulid id, CancellationToken cancellationToken)
        => await Result.Success(new GetProductQuery(id))
        .CallHandler(query => Mediator.Send(query, cancellationToken))
        .Match(OK, NotFound);

    /// <summary>
    /// Get products by offset paging
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// 
    /// </remarks>
    /// <response code="200">Returns the product's page</response>
    /// <response code="400">Return the <see cref="ProblemDetails"/> object contains the list of errors</response>
    /// 
    [HttpPost("offset")]
    [ProducesResponseType<OffsetPageResponse<ProductOffsetPageStaticResponse>>(StatusCodes.Status200OK)]
    [ProducesResponseType<ProblemDetails>(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> OffsetPaging(ProductOffsetPageStaticQuery request)
        => await Result.Success(request)
        .CallHandler(query => Mediator.Send(query))
        .Match(Ok, BadRequest);
}
