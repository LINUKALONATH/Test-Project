using Microsoft.AspNetCore.Mvc;

namespace MyProject.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { message = "Dashboard API is ready." });
}
