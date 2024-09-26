namespace Paris.RMS.Persistences.Pipelines;

public abstract class QueryTransactionPipelineBase<TQueryResponse>
where TQueryResponse : IResult
{
    protected readonly IUnitOfWork UnitOfWork;

    protected QueryTransactionPipelineBase(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
        UnitOfWork
            .ChangeTracker
            .QueryTrackingBehavior = NoTracking;
    }

    protected async Task<TQueryResponse> BeginTransactionAsync(RequestHandlerDelegate<TQueryResponse> next, CancellationToken cancellationToken)
    {
        using var transaction = await UnitOfWork.BeginTransactionAsync(cancellationToken);
        return await next();
    }
}
