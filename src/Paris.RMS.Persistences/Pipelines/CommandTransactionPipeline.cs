namespace Paris.RMS.Persistences.Pipelines;

public sealed class CommandTransactionPipeline<TCommandRequest, TCommandResponse>(IUnitOfWork unitOfWork)
: CommandTransactionPipelineBase<TCommandResponse>(unitOfWork),
IPipelineBehavior<TCommandRequest, TCommandResponse>
where TCommandRequest : class, IRequest<TCommandResponse>, ICommand
where TCommandResponse : class, IResult
{
    public async Task<TCommandResponse> Handle(TCommandRequest command, RequestHandlerDelegate<TCommandResponse> next, CancellationToken cancellationToken)
    {
        var executionStrategy = UnitOfWork.CreateExecutionStrategy();
        return await executionStrategy.ExecuteAsync(cancellationToken => BeginTransactionAsync(next, cancellationToken), cancellationToken);
    }
}
