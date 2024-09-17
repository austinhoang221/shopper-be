using System.Security.Claims;

namespace Paris.RMS.UseCases.UserServices;

public interface IUserContextService
{
    ClaimsPrincipal? User { get; }
    string? UserId { get; }
    string? CustomerId { get; }
    string? Username { get; }
}
