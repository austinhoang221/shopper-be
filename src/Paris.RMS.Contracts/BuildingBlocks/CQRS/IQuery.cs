namespace Paris.RMS.Contracts.BuildingBlocks.CQRS;

/// <summary>
/// Represents the query interface
/// </summary>
/// <typeparam name="TResponse">The query response type</typeparam>
public interface IQuery<out TResponse> : IRequest<IResult<TResponse>>
    where TResponse : IResponse
{
}

/// <summary>
/// Represents the query interface
/// </summary>
/// <typeparam name="TResponse">The query response type</typeparam>
public interface IListQuery<out TResponse> : IRequest<IResult<IReadOnlyCollection<TResponse>>>
    where TResponse : IResponse
{
}
