namespace Paris.RMS.Contracts.BuildingBlocks.CQRS.CusorPages;

public interface ICursorPageQueryHandler<TQuery, TResponse, TFilter, TSortBy, TPage> : ICursorPageQueryHandler<TQuery, TResponse, TPage>
    where TQuery : ICursorPageQuery<TResponse, TFilter, TSortBy, TPage>
    where TResponse : IResponse
    where TFilter : IFilter
    where TSortBy : ISortBy
    where TPage : ICursorPage
{
}

public interface ICursorPageQueryHandler<TQuery, TResponse, TPage> : IQueryHandler<TQuery, CursorPageResponse<TResponse>>
    where TQuery : ICursorPageQuery<TResponse, TPage>
    where TResponse : IResponse
    where TPage : ICursorPage
{
}
