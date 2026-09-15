using Microsoft.AspNetCore.Mvc;
using MyProject.API.DTOs;

namespace MyProject.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginDto request) => Ok(new { token = "development-token", email = request.Email });

    [HttpPost("register")]
    public IActionResult Register(RegisterDto request) => Ok(new { email = request.Email, displayName = request.DisplayName });
}
