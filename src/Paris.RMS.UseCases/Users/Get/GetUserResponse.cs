using System;
namespace Paris.RMS.UseCases.Users.Get;

public sealed class GetUserResponse(string id, string email)
    : IResponse
{
    public string Id { get; } = id;
    public string Email { get; } = email;
}
