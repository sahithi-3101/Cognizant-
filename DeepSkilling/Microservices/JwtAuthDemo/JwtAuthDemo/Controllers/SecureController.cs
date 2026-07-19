using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    /// <summary>
    /// Requires a valid JWT bearer token. Returns claims of the authenticated user.
    /// </summary>
    [Authorize]
    [HttpGet("profile")]
    public IActionResult GetProfile()
    {
        var claims = User.Claims.Select(c => new { c.Type, c.Value });
        return Ok(new
        {
            message = "You are authenticated.",
            username = User.Identity?.Name,
            claims
        });
    }

    /// <summary>
    /// Requires a valid JWT bearer token AND the "Admin" role.
    /// </summary>
    [Authorize(Roles = "Admin")]
    [HttpGet("admin-only")]
    public IActionResult AdminOnly()
    {
        return Ok(new { message = $"Hello {User.Identity?.Name}, you have Admin access." });
    }
}
