using Shared.Model;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Logic;
using System.IO;

namespace SearchAPI.Controllers;

[ApiController]
[Route("api/search")]
public class SearchController : ControllerBase
{
    private static IDatabase mDatabase = DatabaseFactory.GetDatabase(Environment.GetEnvironmentVariable("database"));
    
    [HttpGet]
    [Route("{query}/{maxAmount}")]
    public SearchResult Search(string query, int maxAmount)
    {
        var logic = new SearchLogic(mDatabase);
        var result = logic.Search(query.Split(","), maxAmount);
        return result;
    }
    
    
}
