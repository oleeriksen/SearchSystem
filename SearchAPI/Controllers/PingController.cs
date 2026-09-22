using Microsoft.AspNetCore.Mvc;

namespace SearchAPI.Controllers;

[ApiController]
[Route("ping")]
public class PingController : ControllerBase
{
    [HttpGet]
    public string? Ping()
    {
        string? id = Environment.GetEnvironmentVariable("id");
        return $"Search API - instance {id}";
    }
    
}