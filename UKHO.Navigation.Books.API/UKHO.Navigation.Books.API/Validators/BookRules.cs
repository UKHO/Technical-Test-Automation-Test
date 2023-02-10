using UKHO.Navigation.Books.API.Models;

namespace UKHO.Navigation.Books.API.Validators;

public class BookRules
{
    private readonly Book _book;

    public BookRules(Book book)
    {
        _book = book;
    }

    public bool IsIdValid()
    {
        var id = _book.Id;

        return Guid.TryParse(id, out _);
    }

    public bool IsTitleValid()
    {
        var title = _book.Title;

        return string.IsNullOrWhiteSpace(title) && IsStandardTextFieldLength(title);
    }
    
    public bool IsAuthorValid()
    {
        var author = _book.Author;

        return string.IsNullOrWhiteSpace(author) && IsStandardTextFieldLength(author);
    }

    public bool IsPageCountValid()
    {
        var pageCount = _book.PageCount;

        return pageCount is > 0 and < 9999;
    }

    public bool IsReleaseDate()
    {
        var releaseDate = _book.ReleaseDate;

        return releaseDate != default;
    }

    private static bool IsStandardTextFieldLength(string value)
    {
        return value.Length is > 5 and < 999;
    }
}
