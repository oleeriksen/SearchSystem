using Microsoft.AspNetCore.Mvc;
using Shared.Model;

namespace LoadBalancer.Controllers;

[ApiController]
[Route("api")]
public class LoadBalancerController : ControllerBase
{
    private static int next = 0;
    private static string[] instances = Environment.GetEnvironmentVariable("instances").Split(';');

    private static Lock locker = new();
    [HttpGet]
    [Route("search/{query}/{maxAmount}")]
    public void Search(string query, int maxAmount)
    {
        string url;
        lock (locker)
        {
             url = $"{instances[next]}/api/search/{query}/{maxAmount}";
             next = (next + 1) % instances.Length;
        }
        Response.Redirect(url);
    }
}