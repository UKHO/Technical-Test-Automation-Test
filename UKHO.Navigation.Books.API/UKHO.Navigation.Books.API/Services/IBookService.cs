using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Services;

public interface IBookService
{
    public Task<bool> CreateAsync(Book book);

    public Task<Book?> GetByIdAsync(string book);

    public Task<IEnumerable<Book>> GetAllAsync();

    public Task<IEnumerable<Book>> SearchByTitleAsync(string searchTerm);

    public Task<bool> UpdateAsync(Book book);

    public Task<bool> DeleteAsync(string id);
}