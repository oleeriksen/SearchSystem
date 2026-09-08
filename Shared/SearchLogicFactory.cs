namespace Shared;

public class SearchLogicFactory
{
    public static ISearchLogic CreateSearchLogic()
    {
        return new SearchLogicProxy();
    }
}