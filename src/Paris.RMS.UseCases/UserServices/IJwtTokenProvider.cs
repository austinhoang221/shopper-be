namespace Paris.RMS.UseCases.UserServices;

public interface IJwtTokenProvider
{
    string GenerateJwt(ApplicationUser user);
}
