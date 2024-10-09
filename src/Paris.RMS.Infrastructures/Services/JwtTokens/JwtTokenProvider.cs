namespace Paris.RMS.Infrastructures.Services.JwtTokens;

internal sealed class JwtTokenProvider(IOptionsMonitor<AuthenticationOptions> options, TimeProvider timeProvider)
    : IJwtTokenProvider
{
    private readonly AuthenticationOptions authenticationOptions = options.CurrentValue;

    public string GenerateJwt(ApplicationUser user)
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Name, user.UserName!),
            new(JwtRegisteredClaimNames.Email, user.Email!),
        ];

        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationOptions.SecretKey));

        var signingCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);

        var expires = timeProvider.GetUtcNow().AddDays(authenticationOptions.DaysToExpire);

        var token = new JwtSecurityToken
        (
            issuer: authenticationOptions.Issuer,
            audience: authenticationOptions.Audience,
            claims: claims,
            expires: expires.DateTime,
            signingCredentials: signingCredentials
        );

        var tokenHandler = new JwtSecurityTokenHandler();
        return tokenHandler.WriteToken(token);
    }
}
