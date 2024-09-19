using System.ComponentModel.DataAnnotations;

namespace Paris.RMS.Domains.Users;

public class ApplicationUser : IdentityUser
{
    private ApplicationUser(string username, string name, string lastName, string email, string phoneNumber)
    {
        Id = Ulid.NewUlid().ToString();
        UserName = username;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    private ApplicationUser() { }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;

    public static ApplicationUser Create(string username, string name, string lastName, string email, string phoneNumber)
        => new(username, name, lastName, email, phoneNumber);
}
