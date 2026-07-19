using JwtAuthDemo.Models;

namespace JwtAuthDemo.Services;

/// <summary>
/// Minimal in-memory user store for demo/testing purposes.
/// Replace with a real database-backed repository (e.g. EF Core + ASP.NET Core Identity) in production.
/// Default seeded credentials: username "admin" / password "Admin@123"
/// </summary>
public static class UserStore
{
    public static readonly List<User> Users = new()
    {
        new User
        {
            Id = 1,
            Username = "admin",
            PasswordHash = PasswordHasher.Hash("Admin@123"),
            Role = "Admin"
        }
    };

    public static User? Validate(string username, string password)
    {
        var user = Users.FirstOrDefault(u =>
            string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));

        if (user is null)
        {
            return null;
        }

        return PasswordHasher.Verify(password, user.PasswordHash) ? user : null;
    }
}
