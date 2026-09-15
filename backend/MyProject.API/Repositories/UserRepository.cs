using MyProject.API.Models;
using MyProject.API.Repositories.Interfaces;

namespace MyProject.API.Repositories;

public sealed class UserRepository : IUserRepository
{
    public Task<IReadOnlyList<User>> GetAllAsync() =>
        Task.FromResult<IReadOnlyList<User>>([new() { Id = 1, Email = "admin@example.com", DisplayName = "Administrator" }]);
}
