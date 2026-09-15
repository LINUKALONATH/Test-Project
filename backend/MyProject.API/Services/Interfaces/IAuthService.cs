using MyProject.API.DTOs;

namespace MyProject.API.Services.Interfaces;

public interface IAuthService
{
    Task<string?> LoginAsync(LoginDto request);
}
