using Microsoft.AspNetCore.Identity;

namespace Paris.RMS.Persistences.Databases;

public class UsersSeed(
    ILogger<UsersSeed> logger,
    UserManager<ApplicationUser> userManager)
    : IDbSeeder<ParisRmsDbContext>
{
    public async Task SeedAsync(ParisRmsDbContext context)
    {
        var alice = await userManager.FindByNameAsync("alice");

        if (alice is null
            && logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("alice already exists");
        }

        alice = ApplicationUser.Create(Guid.NewGuid().ToString(), "XXXXXXXXXXXX1881", "123", "12/24", "Alice Smith",
                1, "15703 NE 61st Ct", "Redmond", "WA", "U.S.", "98052", "Alice", "Smith", "alice", "AliceSmith@email.com",
                true, "1234567890");

        var result = userManager.CreateAsync(alice, "Pass123$").Result;

        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }

        if (logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("alice created");
        }

        var bob = await userManager.FindByNameAsync("bob");

        if (bob is null
            && logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("bob already exists");
        }

        bob = ApplicationUser.Create(Guid.NewGuid().ToString(), "XXXXXXXXXXXX1881", "456", "12/24", "Bob Smith",
                1, "15703 NE 61st Ct", "Redmond", "WA", "U.S.", "98052", "Bob", "Smith", "bob", "BobSmith@email.com",
                true, "1234567890");

        result = await userManager.CreateAsync(bob, "Pass123$");

        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }

        if (logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("bob created");
        }
    }
}
