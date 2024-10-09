namespace Paris.RMS.Contracts.BuildingBlocks.CQRS;

/// <summary>
/// Represents the query handler interface
/// </summary>
/// <typeparam name="TQuery">The query type</typeparam>
/// <typeparam name="TResponse">The query response type</typeparam>
public interface IListQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, IResult<IReadOnlyCollection<TResponse>>>
    where TQuery : IListQuery<TResponse>
    where TResponse : IResponse
{
}
