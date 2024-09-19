namespace Paris.RMS.Persistences.Databases;

public class UsersSeed(
    ILogger<UsersSeed> logger,
    UserManager<ApplicationUser> userManager)
    : IDbSeeder<ParisRmsDbContext>
{
    public async Task SeedAsync(ParisRmsDbContext context)
    {
        var admin = await userManager.FindByNameAsync("admin");

        if (admin is not null)
        {
            logger.LogInformation("admin already exists");
            return;
        }

        admin = ApplicationUser.Create("admin", "admin", "administrator", "admin@gmail.com", "0123456789");

        await userManager.CreateAsync(admin!, "Pass123$");

        if (logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("admin created");
        }
    }
}
