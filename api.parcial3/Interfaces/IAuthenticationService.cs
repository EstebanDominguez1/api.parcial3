using api.parcial1.Dto;

namespace api.parcial1.Interfaces;

public interface IAuthenticationService
{
    Task<bool> Authenticate(string username, string password);
    Task<string> GenerateJwt(User user);
}