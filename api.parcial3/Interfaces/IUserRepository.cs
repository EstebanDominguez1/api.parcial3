using api.parcial1.Dto;

namespace api.parcial1.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByCredentials(string username, string password);
}
