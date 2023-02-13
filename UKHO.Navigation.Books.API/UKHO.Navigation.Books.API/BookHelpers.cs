using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public class BookHelpers
{
    private readonly Book _book;

    public BookHelpers(Book book)
    {
        _book = book;
    }
    
    public bool IsPageCountValid()
    {
        var pageCount = _book.PageCount;

        return pageCount is > 0 and < 9999;
    }

    public IList<Book> GetBooksById(Guid id, IList<Book> listOfBooks)
    {
        var matchingBookings = new List<Book>();

        foreach (var book in listOfBooks)
        {
            if (book.Id == id.ToString())
            {
                matchingBookings.Add(book);
            }
        }

        return matchingBookings;
    }
}
