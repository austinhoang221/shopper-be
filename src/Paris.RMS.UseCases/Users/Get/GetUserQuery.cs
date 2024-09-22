namespace Paris.RMS.UseCases.Users.Get;

public sealed class GetUserQuery(string id)
    : IQuery<GetUserResponse>
{
    public string Id { get; } = id;
}
