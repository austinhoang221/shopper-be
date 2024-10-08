using Paris.RMS.Domains.Systems;
using Paris.RMS.Domains.Systems.Repositories;

namespace Paris.RMS.UseCases.Systems.AllCodes.Get;

public sealed class GetAllCodeHandler(IAllCodeRepository allCodeRepository,
    IValidator validator)
    : IQueryHandler<GetAllCodeQuery, GetAllCodeResponse>
{
    public async Task<IResult<GetAllCodeResponse>> Handle(GetAllCodeQuery request, CancellationToken cancellationToken)
    {
        var allCode = await allCodeRepository.FindAsync(request.Id);

        validator
            .If(allCode is null, NotFound<AllCode>(request.Id));

        if (validator.IsInvalid)
        {
            return validator.Failure<GetAllCodeResponse>();
        }

        return Result.Success(new GetAllCodeResponse(allCode!.Id, allCode.CdName, allCode.CdType, allCode.CdVal, allCode.LstOdr));
    }
}
