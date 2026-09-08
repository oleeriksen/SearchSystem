namespace SearchAPI.Logic;

public class DatabaseFactory
{
    public static IDatabase GetDatabase(string dbType)
    {
        if (dbType.Equals("sqlite"))
            return new DatabaseSqlite();
        return new DatabasePostgres();
    }
}