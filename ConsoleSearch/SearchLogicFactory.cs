namespace ConsoleSearch;

public class SearchLogicFactory
{
    public static ISearchLogic GetSearchLogic(IDatabase db)
    {
        return new SearchLogic(db);
    }
}