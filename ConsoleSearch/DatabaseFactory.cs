using System;

namespace ConsoleSearch;

public class DatabaseFactory
{
    public static IDatabase GetDataBase(DatabaseType dbType)
    {
        switch (dbType)
        { 
            case DatabaseType.SQLITE: return new DatabaseSqlite();
            case DatabaseType.POSTGRES: return new DatabasePostgres();
            default: throw new Exception("Illegal type of database");
        }
    }
}