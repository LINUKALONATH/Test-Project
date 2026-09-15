using MyProject.API.DTOs;
using MyProject.API.Services.Interfaces;

namespace MyProject.API.Services;

public sealed class UserService : IUserService
{
    public Task<IReadOnlyList<UserDto>> GetAllAsync() =>
        Task.FromResult<IReadOnlyList<UserDto>>([new(1, "admin@example.com", "Administrator")]);
}
