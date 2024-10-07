namespace Paris.RMS.Persistences.Pipelines;

public sealed class CommandWithResponseTransactionPipeline<TCommandRequest, TCommandResponse>(IUnitOfWork unitOfWork)
    : CommandTransactionPipelineBase<TCommandResponse>(unitOfWork),
    IPipelineBehavior<TCommandRequest, TCommandResponse>
    where TCommandRequest : class, IRequest<TCommandResponse>
    where TCommandResponse : class, IResult<IResponse>
{
    public async Task<TCommandResponse> Handle(TCommandRequest command, RequestHandlerDelegate<TCommandResponse> next, CancellationToken cancellationToken)
    {
        var executionStrategy = UnitOfWork.CreateExecutionStrategy();
        return await executionStrategy.ExecuteAsync(cancellationToken => BeginTransactionAsync(next, cancellationToken), cancellationToken);
    }
}
