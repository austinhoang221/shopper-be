using Paris.RMS.Domains.Systems;
using Paris.RMS.Domains.Systems.Repositories;

namespace Paris.RMS.UseCases.Systems.AllCodes.Create;

public sealed class CreateAllCodeHandler(
    IAllCodeRepository allCodeRepository)
    : ICommandHandler<CreateAllCodeCommand, CreateAllCodeResponse>
{
    public async Task<IResult<CreateAllCodeResponse>> Handle(CreateAllCodeCommand request, CancellationToken cancellationToken)
    {
        var allCode = AllCode.Create(request.CdName, request.CdType, request.CdVal, request.LstOdr);

        allCodeRepository.Insert(allCode);

        await Task.CompletedTask;

        return Result.Success(new CreateAllCodeResponse(allCode.Id, allCode.CdName, allCode.CdType, allCode.CdVal, allCode.LstOdr));
    }
}
