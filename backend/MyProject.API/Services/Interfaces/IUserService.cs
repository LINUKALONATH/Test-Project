using MyProject.API.DTOs;

namespace MyProject.API.Services.Interfaces;

public interface IUserService
{
    Task<IReadOnlyList<UserDto>> GetAllAsync();
}
