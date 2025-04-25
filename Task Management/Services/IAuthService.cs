namespace TaskManagementAPI;

public interface IAuthService
{
    string? Authenticate(UserLogin login);
}
