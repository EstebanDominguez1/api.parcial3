using api.parcial1.Interfaces;
using api.parcial1.Dto;

namespace api.parcial1.Repositories;

public class UsersInMemoryRepository : IUserRepository
{
    private readonly List<User> _users = new List<User>
    {
        new()
        {
            Id       = 1,
            Fullname = "Esteban Dominguez",
            Username = "e.dominguez",
            Password = "123456"
        }
    };

    public async Task<User?> GetUserByCredentials(string username, string password)
    {
        return _users.FirstOrDefault(p => p.Username.Equals(username) && p.Password.Equals(password));
    }
}
