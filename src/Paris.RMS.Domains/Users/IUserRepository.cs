namespace Paris.RMS.Domains.Users;

public interface IUserRepository
{
    Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken);

    Task<bool> IsEmailTakenAsync(string email, CancellationToken cancellationToken);
}
