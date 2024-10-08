﻿using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Paris.RMS.Infrastructures.Services.JwtTokens;

internal sealed class BearerAuthenticationOptionsSetup(IOptions<AuthenticationOptions> authenticationOptions) : IPostConfigureOptions<JwtBearerOptions>
{
    private readonly AuthenticationOptions _authenticationOptions = authenticationOptions.Value;

    public void PostConfigure(string? name, JwtBearerOptions options)
    {
        options.TokenValidationParameters.ValidIssuer = _authenticationOptions.Issuer;
        options.TokenValidationParameters.ValidAudience = _authenticationOptions.Audience;
        options.TokenValidationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationOptions.SecretKey));

        //ClockSkew determines additional time for token to live
        //By default it is set to 5min. In almost every scenario it should be overwritten to value from 5s - 30s.
        options.TokenValidationParameters.ClockSkew = TimeSpan.FromSeconds(_authenticationOptions.ClockSkew);
    }
}
