namespace Paris.RMS.UseCases.Attachments.Create;

public sealed class CreateAttachmentsCommand(List<IFormFile> files)
    : ICommand
{
    public List<IFormFile> Files { get; } = files;
}

public sealed class CreateAttachmentsHandler
    : ICommandHandler<CreateAttachmentsCommand>
{
    public Task<IResult> Handle(CreateAttachmentsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
