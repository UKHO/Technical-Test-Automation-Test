using Dapper;
using UKHO.Navigation.Books.API.Data;
using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Services;

public class BookService : IBookService
{
    private readonly IDbConnectionFactory _connectionFactory;

    public BookService(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<bool> CreateAsync(Book book)
    {
        if (await DoesBookExist(book) is false) return false;

        using var connection = await _connectionFactory.CreateConnectionAsync();
        
        var result = await connection.ExecuteAsync(
            @"INSERT INTO Books (Id, Title, Author, ShortDescription, PageCount, ReleaseDate) 
                     VALUES (@Id, @Title, @Author, @ShortDescription, @PageCount, @ReleaseDate)", book);

        return result > 0;
    }

    public async Task<Book?> GetByIdAsync(string id)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        return connection
            .QuerySingleOrDefault<Book>
            ("SELECT * FROM Books WHERE Id = @Id LIMIT 1",
                new { Id = id });
    }

    public async Task<IEnumerable<Book>> GetAllAsync()
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        return await connection.QueryAsync<Book>("SELECT * FROM Books");
    }

    public async Task<IEnumerable<Book>> SearchByTitleAsync(string searchTerm)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        return await connection
            .QueryAsync<Book>("SELECT * FROM Books WHERE Title like '%' || @SearchTerm || '%'",
            new { SearchTerm = searchTerm });
    }

    public async Task<bool> UpdateAsync(Book book)
    {
        if (await DoesBookExist(book) is false) return false;

        using var connection = await _connectionFactory.CreateConnectionAsync();

        var result = await connection.ExecuteAsync(
            @"UPDATE Books SET 
            Title = @Title, 
            Author = @Author, 
            ShortDescription = @ShortDescription,
            PageCount = @PageCount,
            ReleaseDate = @ReleaseDate
            WHERE Id = @Id", book);

        return result > 0;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();

        var result = await connection.ExecuteAsync(
            @"DELETE FROM Books WHERE Id = @Id", new { Id = id });

        return result > 0;
    }

    private async Task<bool> DoesBookExist(Book book) => await GetByIdAsync(book.Id) is null;
    
}