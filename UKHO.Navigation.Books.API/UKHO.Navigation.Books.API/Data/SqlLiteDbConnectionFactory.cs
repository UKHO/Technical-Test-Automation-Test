using System.Data;
using Microsoft.Data.Sqlite;

namespace UKHO.Navigation.Books.API.Data;

public class SqlLiteDbConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public SqlLiteDbConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IDbConnection> CreateConnectionAsync()
    {
        var connection = new SqliteConnection(_connectionString);
        await connection.OpenAsync();
        return connection;
    }
}