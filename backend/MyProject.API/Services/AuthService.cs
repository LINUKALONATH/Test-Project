using MyProject.API.DTOs;
using MyProject.API.Services.Interfaces;

namespace MyProject.API.Services;

public sealed class AuthService : IAuthService
{
    public Task<string?> LoginAsync(LoginDto request) =>
        Task.FromResult<string?>(string.IsNullOrWhiteSpace(request.Email) ? null : "development-token");
}
