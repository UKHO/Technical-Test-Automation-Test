using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API;

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

    public IList<Book> FindMatchingBooks(IList<Book> listOfBooks)
    {
        var matchingBookings = new List<Book>();

        foreach (var book in listOfBooks)
        {
            if (book.Id == _book.Id)
            {
                matchingBookings.Add(book);
            }
        }

        return matchingBookings;
    }
}
