using Microsoft.AspNetCore.Mvc;
using MyProject.API.DTOs;

namespace MyProject.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<UserDto>> Get() => Ok(new[]
    {
        new UserDto(1, "admin@example.com", "Administrator")
    });
}
