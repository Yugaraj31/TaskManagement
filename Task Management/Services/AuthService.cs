using System.Data;

namespace TaskManagementAPI;

public class AuthService : IAuthService
{
    private readonly ITokenService _tokenService;

    public AuthService(ITokenService tokenService)
    {
        _tokenService = tokenService;
    }

    public string? Authenticate(UserLogin login)
    {
        if (login.Username == "yugaraj" && login.Password == "pass")
            return _tokenService.GenerateToken(login.Username, Role.Admin.ToString());
        if (login.Username == "ajith" && login.Password == "pass")
            return _tokenService.GenerateToken(login.Username, Role.User.ToString());
        if (login.Username == "abdul" && login.Password == "pass")
            return _tokenService.GenerateToken(login.Username, Role.Manager.ToString());
        return null;
    }
}
