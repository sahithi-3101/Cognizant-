namespace JwtAuthDemo.Models;

/// <summary>
/// Represents an application user.
/// NOTE: This is a simplified in-memory model for demo purposes only.
/// In a real system, replace this with a proper user store (e.g. ASP.NET Core Identity + a database)
/// and NEVER store plain-text passwords.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
}
