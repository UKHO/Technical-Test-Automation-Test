using System.Data;

namespace UKHO.Navigation.Books.API.Data;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}