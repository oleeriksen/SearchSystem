using System.Threading.Tasks;
using Shared.Model;

namespace Shared;

public interface ISearchLogic
{
    Task<SearchResult> Search(string[] query, int maxAmount);
    Task<string> GetFileContent(string url);
}