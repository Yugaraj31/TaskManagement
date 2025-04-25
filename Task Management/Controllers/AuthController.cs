using Microsoft.AspNetCore.Mvc;

namespace TaskManagementAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService) => _authService = authService;

    [HttpPost("login")]
    public IActionResult Login(UserLogin login)
    {
        var token = _authService.Authenticate(login);
        return token == null ? Unauthorized() : Ok(new { token });
    }
}