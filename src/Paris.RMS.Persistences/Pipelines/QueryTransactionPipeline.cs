namespace Paris.RMS.Persistences.Pipelines;

public sealed class QueryTransactionPipeline<TQueryRequest, TQueryResponse>(IUnitOfWork unitOfWork)
: QueryTransactionPipelineBase<TQueryResponse>(unitOfWork), IPipelineBehavior<TQueryRequest, TQueryResponse>
where TQueryRequest : class, IRequest<TQueryResponse>, IQuery<IResponse>
where TQueryResponse : class, IResult<IResponse>
{
    public async Task<TQueryResponse> Handle(TQueryRequest request, RequestHandlerDelegate<TQueryResponse> next, CancellationToken cancellationToken)
    {
        var executionStrategy = UnitOfWork.CreateExecutionStrategy();
        return await executionStrategy.ExecuteAsync(cancellationToken => BeginTransactionAsync(next, cancellationToken), cancellationToken);
    }
}
