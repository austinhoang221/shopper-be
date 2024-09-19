using Microsoft.Extensions.Configuration;

namespace Paris.RMS.Infrastructures.Services.JwtTokens;

internal sealed class AuthenticationOptionsSetup(IConfiguration configuration) : IConfigureOptions<AuthenticationOptions>
{
    public void Configure(AuthenticationOptions options)
    {
        configuration
            .GetSection(AuthenticationOptions.Name)
            .Bind(options);
    }
}
