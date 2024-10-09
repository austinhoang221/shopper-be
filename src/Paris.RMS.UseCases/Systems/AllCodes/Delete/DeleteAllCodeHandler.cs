namespace Paris.RMS.UseCases.Systems.AllCodes.Delete;

public sealed class DeleteAllCodeHandler(
    IAllCodeRepository allCodeRepository,
    IValidator validator)
    : ICommandHandler<DeleteAllCodeCommand>
{
    public async Task<IResult> Handle(DeleteAllCodeCommand request, CancellationToken cancellationToken)
    {
        bool isExist = await allCodeRepository.IsExist(request.Id);

        validator
            .If(!isExist, NotFound<AllCode>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure();
        }

        return Result.Success();
    }
}
