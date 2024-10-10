using Paris.RMS.UseCases.ProductCategorys.Get;
using Paris.RMS.UseCases.ProductCategorys.List;

namespace Paris.RMS.API.Products;

[AllowAnonymous]
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
}
