using Paris.RMS.Domains.Systems.Repositories;

namespace Paris.RMS.Persistences.Repositories.Systems;

internal class AllCodeRepository(IDbContext context) : RepositoryBase<AllCode>(context), IAllCodeRepository
{
}
