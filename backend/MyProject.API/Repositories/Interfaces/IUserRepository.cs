using MyProject.API.Models;

namespace MyProject.API.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IReadOnlyList<User>> GetAllAsync();
}
