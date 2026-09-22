
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Coordinator.Service;
using Shared.Model;

namespace Coordinator.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class CoordinatorController : ControllerBase
    {
        private static CoordinatorService mService = new();

        [EnableCors("policy")]
        [HttpGet]
        [Route("{query}/{maxAmount}")]
        public SearchResult Get(string query, int maxAmount)
        {
            return mService.Get(query, maxAmount);
        }

        [HttpGet]
        [Route("ping")]
        public string? Ping()
        {
            return "Coordinator";
        }
    }
}

